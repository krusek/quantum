load("qubit.sage")
load("operators.sage")

class Gates:
  """
  This class contains several class methods to apply Gates to qubit arrays. In order to attempt to
  mimic true quantum computing each gate changes the input qubit. For convenience they also return
  the qubit.

  NOTE:
  One could easily update the Gates to optionally return a new qubit rather than updating the input
  qubit.
  """
  @classmethod
  def oX(self, q, index):
    m = Operators.X(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def oY(self, q, index):
    m = Operators.Y(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def oZ(self, q, index):
    m = Operators.Z(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def oH(self, q, index):
    m = Operators.H(q.length, index)
    q.v = m * q.v
    return q

  @classmethod
  def oCNOT(self, q, control, ix2):
    m = Operators.CNOT(q.length, control, ix2)
    q.v = m * q.v
    return q

  @classmethod
  def oCCNOT(self, q, control1, control2, ix2):
    m = Operators.CCNOT(q.length, control1, control2, ix2)
    q.v = m * q.v
    return q

  @classmethod
  def __swap(self, q, ones, zeros, controls = [], multipliers = [1,1]):
    l = list(q.v)
    qcount = q.length
    for one, zero in zip(ones, zeros):
      flags = map(lambda control: flag_value(one, qcount, control) and flag_value(zero, qcount, control), controls)
      flag = reduce(lambda f, x: f and x, flags, True)
      if len(flags) > 0 and flag == False:
        continue
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
  def H(self, q, index):
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
  def X(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros)

  @classmethod
  def CX(self, q, control, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros, controls = [control])

  @classmethod
  def Z(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, ones, multipliers = [1, -1])

  @classmethod
  def Y(self, q, index):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros, multipliers = [i, -i])

  @classmethod
  def CNOT(self, q, control, ix2):
    return self.CX(q, control, ix2)

  @classmethod
  def CCNOT(self, q, control1, control2, ix2):
    ones, zeros = self.__ones_zeros(q.length, index)
    return self.__swap(q, ones, zeros, controls = [control1, control2])
