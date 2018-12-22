from sympy import *
import random
from qubit import Qubits
from gates import Gates
from helpers import *

class Pauli:
  def gate(self, q, index):
    pass
  
  def __repr__(self):
    return "I"
  
class PauliX(Pauli):
  def gate(self, q, index):
    Gates.X(q, index)
  
  def __repr__(self):
    return "X"
  
class PauliY(Pauli):
  def gate(self, q, index):
    Gates.Y(q, index)
  
  def __repr__(self):
    return "Y"
  
class PauliZ(Pauli):
  def gate(self, q, index):
    Gates.Z(q, index)
  
  def __repr__(self):
    return "Z"

def list_norm_squared(l):
  return reduce(lambda s, x: conjugate(x)*x + s, l, 0)

class Measurement:
  """
  This class contains class methods that can be used to perform measurements on qubits. Currently
  only Z measurement is defined, but I plan on adding other +/-1 measurements. For speed purposes
  it should be updated to not use projector matrices but instead to do the projection by hand.
  """

  @classmethod
  def _d_measure(self, q, index):
    """
    This is an internal helper method used for measurement. It is provided as public to aid in
    understanding how measurement works in quantum computation. This method returns a list
    containing tuples of eigenvalue, probability, and qubits. For example, suppose that
    q = 1/sqrt(3)|00> + 1/sqrt(3)|10> + 1/sqrt(3)|11>

    Then _d_measure(q, 0) will return
    [(1, 1/3, |00>), (-1, 2/3, 1/sqrt(2)|10> + 1/sqrt(2)|11>)]

    Returns:
      [(e1, p1, q1), (e2, p2, q2)]: A list of tuples eigenvalues, probabilities, and qubits.
    """
    return self._d_measurement(q, [PauliZ()], [index])
    qcount = q.length
    zeros = filter(lambda y: flag_value(y, qcount, index) == False, xrange(q.size))
    ones = filter(lambda y: flag_value(y, qcount, index) == True, xrange(q.size))
    l = list(q.v)
    lz = l[:]
    lo = l[:]
    for io, iz in zip(ones, zeros):
      lz[io] = Integer(0)
      lo[iz] = Integer(0)
    nz = list_norm_squared(lz)
    no = list_norm_squared(lo)
    dz = sqrt(nz) if nz != 0 else Integer(1)
    do = sqrt(no) if no != 0 else Integer(1)
    lz = map(lambda x: x / dz, lz)
    lo = map(lambda x: x / do, lo)
    qz = Qubits(qcount)
    qo = Qubits(qcount)
    qz.v = Matrix(lz)
    qo.v = Matrix(lo)
    return [(1, nz, qz), (-1, no, qo)]

  @classmethod
  def measure(self, q, index):
    """
    The method performs a measurement using the Z gate at the given index. Based on the value of
    rnd it will either select all the states where the indexth qubit is 0 or 1. It also updates the
    value of the input qubit array, q.

    Returns:
      m - the selected eigenvalue
    """
    return self.measurement(q, [PauliZ()], [index])
  
  @classmethod
  def measurement(self, q, paulis, idx):
    """
    This method performs measurements using arbitrary tensor products of Pauli operators. See
    measurements.pdf for an explanation and proof of how it works.

    Keyword arguments:
    q - the qubit array to measure
    paulis - array indicating which operators to use for the measurement.
    idx - an array of indices indicating which qubits in q to measure. Assumed to be the same length as paulis
    """
    rnd = random.random()
    return self.rr_measurement(q, paulis, idx, rnd)

  @classmethod
  def rr_measure(self, q, index, rnd):
    """
    The method performs a measurement using the Z gate at the given index. Based on the value of
    rnd it will either select all the states where the indexth qubit is 0 or 1. It also updates the
    value of the input qubit array, q.

    Returns:
      m - the selected eigenvalue
    """
    m, qq = self.r_measure(q, index, rnd)
    q.v = qq.v
    return m

  @classmethod
  def rr_measurement(self, q, paulis, idx, rnd):
    m, qq = self.r_measurement(q, paulis, idx, rnd)
    q.v = qq.v
    return m

  @classmethod
  def r_measure(self, q, index, rnd):
    """
    This is a helper method that will pick one of the measurements based on rnd.

    Returns
      (eigenvalue, qubit array): The eigenvalue and qubit array selected based on rnd.
    """
    m = self._d_measure(q, index)
    if rnd > m[0][1]:
      return (m[1][0], m[1][2])
    else:
      return (m[0][0], m[0][2])
  
  @classmethod
  def r_measurement(self, q, paulis, idx, rnd):
    m = self._d_measurement(q, paulis, idx)
    if rnd > m[0][1]:
      return (m[1][0], m[1][2])
    else:
      return (m[0][0], m[0][2])

  @classmethod
  def _d_measurement(self, q, paulis, idx):
    qm = q.clone()
    for (p, ix) in zip(paulis, idx):
      p.gate(qm, ix)
    lm = list(qm.v)
    ll = list(q.v)
    lz = map(lambda ix: (lm[ix] + ll[ix])/Integer(2), range(len(lm)))
    lo = map(lambda ix: (-lm[ix] + ll[ix])/Integer(2), range(len(lm)))
    vz = Matrix(lz)
    vo = Matrix(lo)
    nz = my_norm(vz)**2
    no = my_norm(vo)**2
    qz = Qubits(q.length)
    qo = Qubits(q.length)
    if nz != 0:
      qz.v = vz / sqrt(nz)
    if no != 0:
      qo.v = vo / sqrt(no)
    
    rr = [(1, nz, qz), (-1, no, qo)]
    return rr



  @classmethod
  def ZX(self, q, ix, iy):
    qm = q.clone()
    Gates.Z(qm, ix)
    Gates.X(qm, iy)
    lm = list(qm.v)
    ll = list(q.v)
    lz = map(lambda ix: (lm[ix] + ll[ix])/2, range(len(lm)))
    lo = map(lambda ix: (lm[ix] - ll[ix])/2, range(len(lm)))
    vz = Matrix(lz)
    vo = Matrix(lo)
    nz = my_norm(vz)**2
    no = my_norm(vo)**2
    qz = Qubits(q.length)
    qo = Qubits(q.length)
    if nz != 0:
      qz.v = vz / sqrt(nz)
    if no != 0:
      qo.v = vo / sqrt(no)
    return [(nz, qz), (no, qo)]
