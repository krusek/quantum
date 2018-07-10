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
    rnd = random.random()
    m, qq = self.r_measure(q, index, rnd)
    q.v = qq.v
    return (m, q)

  @classmethod
  def r_measure(self, q, index, rnd):
    m = self._d_measure(q, index)
    if rnd > m[0][1]:
      return (m[1][0], m[1][2])
    else:
      return (m[0][0], m[0][2])
