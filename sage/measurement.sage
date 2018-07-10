load("operators.sage")

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
    lz = copy(l)
    lo = copy(l)
    for iz, io in zip(ones, zeros):
      lz[io] = 0
      lo[iz] = 0
    print lz, lo
    nz = list_norm_squared(lz)
    no = list_norm_squared(lo)
    dz = sqrt(nz) if nz != 0 else 1
    do = sqrt(no) if no != 0 else 1
    print (no, nz), (do, dz)
    lz = map(lambda x: x / dz, lz)
    lo = map(lambda x: x / do, lo)
    qz = Qubits(qcount)
    qo = Qubits(qcount)
    qz.v = vector(lz)
    qo.v = vector(lo)
    return [(1, nz, qz), (-1, no, qo)]

  @classmethod
  def measure(self, q, index):
    """
    The method performs a measurement using the Z gate at the given index. Based on the value of
    rnd it will either select all the states where the indexth qubit is 0 or 1. It also updates the
    value of the input qubit array, q.

    Returns:
      m - the selected eigenvalue
      q - the updated input qubit array
    """
    rnd = random.random()
    m, qq = self.r_measure(q, index, rnd)
    q.v = qq.v
    return (m, q)

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
