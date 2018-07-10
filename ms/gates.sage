load("qubit.sage")
load("operators.sage")

class Gates:
  @classmethod
  def X(self, q, index):
    m = Operators.X(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def Y(self, q, index):
    m = Operators.Y(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def Z(self, q, index):
    m = Operators.Z(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def H(self, q, index):
    m = Operators.H(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def CNOT(self, q, control, ix2):
    m = Operators.CNOT(q.length, control, ix2)
    q.v = m * q.v
    return q

  @classmethod
  def CCNOT(self, q, control1, control2, ix2):
    m = Operators.CCNOT(q.length, control1, control2, ix2)
    q.v = m * q.v
    return q

  @classmethod
  def __swap(self, q, ones, zeros, multipliers = [1,1]):
    l = list(q.v)
    for one, zero in zip(ones, zeros):
      t = l[one]
      l[one] = multipliers[0]*l[zero]
      l[zero] = multipliers[1]*t
    q.v = vector(l)
    return q

  @classmethod
  def __ones_zeros(self, qcount, index):
    size = 2^qcount
    zeros = filter(lambda y: flag_value(y, qcount, index) == False, xrange(size))
    ones = map(lambda y: invert_index(y, qcount, index), zeros)
    return (ones, zeros)

  @classmethod
  def sH(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    l = list(q.v)
    lz = copy(l)
    lo = copy(l)
    for one, zero in zip(ones, zeros):
      lo[zero] = 2^(-1/2)*lo[one]
      lo[one] = -lo[zero]
      lz[zero] = 2^(-1/2)*lz[zero]
      lz[one] = lz[zero]
    qo = Qubits(q.length)
    qo.v = vector(lo)
    qz = Qubits(q.length)
    qz.v = vector(lz)
    q.v = qo.v + qz.v
    return q


  @classmethod
  def sX(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros)

  @classmethod
  def sZ(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, ones, multipliers = [1, -1])

  @classmethod
  def sY(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros, multipliers = [i, -i])

  @classmethod
  def sCNOT(self, q, control, ix2):
    qcount = q.length
    size = 2^qcount
    ones = filter(lambda x: flag_value(x, qcount, control) and flag_value(x, qcount, ix2), xrange(size))
    zeros = map(lambda x: invert_index(x, qcount, ix2), ones)
    return self.__swap(q, ones, zeros)

  @classmethod
  def sCCNOT(self, q, control1, control2, ix2):
    qcount = q.length
    size = 2^qcount
    ones = filter(lambda x: flag_value(x, qcount, control1) and flag_value(x, qcount, control2) and flag_value(x, qcount, ix2), xrange(size))
    zeros = map(lambda x: invert_index(x, qcount, ix2), ones)
    return self.__swap(q, ones, zeros)
