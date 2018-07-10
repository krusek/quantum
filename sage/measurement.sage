load("operators.sage")

class Measurement:
  @classmethod
  def _d_measure(self, q, index):
    qcount = q.length
    zeros = filter(lambda y: flag_value(y, qcount, index) == False, xrange(q.size))
    ones = filter(lambda y: flag_value(y, qcount, index) == True, xrange(q.size))
    p1 = self.__projector(q.size, ones)
    pn1 = self.__projector(q.size, zeros)
    v1 = p1 * q.v
    vn1 = pn1 * q.v
    n1 = my_norm(v1)
    nn1 = my_norm(vn1)
    try:
      if n1 != 0:
        v1 = simplify(v1 / n1)
      if nn1 != 0:
        vn1 = simplify(vn1 / nn1)
    except:
      pass
    q1 = Qubits(q.length)
    qn1 = Qubits(q.length)
    q1.v = v1
    qn1.v = vn1
    return [(1, n1^2, q1), (-1, nn1^2, qn1)]

  @classmethod
  def measure(self, q, index):
    rnd = random.random()
    return self.r_measure(q, index, rnd)

  @classmethod
  def r_measure(self, q, index, rnd):
    m = self._d_measure(q, index)
    if rnd > m[0][1]:
      return (m[1][0], m[1][2])
    else:
      return (m[0][0], m[0][2])

  @classmethod
  def __projector(self, size, zeros):
    i = matrix.identity(QQbar, size)
    l = list(i)
    for z in zeros:
      l[z] = tuple([0]*size)
    return matrix(QQbar, l)
