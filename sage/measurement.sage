execfile("operators.sage")
from sympy import *


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
    rnd = random.random()
    m, qq = self.r_measure(q, index, rnd)
    q.v = qq.v
    return m

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
  def r_measure(self, q, index, rnd):
    """
    This is a helper method that will pick one of the measurements based on rnd.

    Returns
      (eigenvalue, qubit array): The eigenvalue and qubit array selected based on rnd.
    """
    m = self._d_measure(q, index)
    print "measurement: ", m
    if rnd > m[0][1]:
      return (m[1][0], m[1][2])
    else:
      return (m[0][0], m[0][2])
  
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
    print vz, "norm", nz
    print vo, "norm", no
    qz = Qubits(q.length)
    qo = Qubits(q.length)
    if nz != 0:
      qz.v = vz / sqrt(nz)
    if no != 0:
      qo.v = vo / sqrt(no)
    return [(nz, qz), (no, qo)]
