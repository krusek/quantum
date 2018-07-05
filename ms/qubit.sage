def binary_tuple(number, length):
  s = "{0:b}".format(number)
  if len(s) < length:
    s = "0" * (length - len(s)) + s
  return tuple(map(lambda x: int(x), list(s)))

def from_binary_tuple(tpl):
  sl = "".join(map(lambda x: str(x), tpl))
  return int(sl, 2)

class Qubits:
  def __init__(self, length):
    self.length = length
    self.size = 2**length
    ns = map(lambda x: "{0:d}".format(x+1), xrange(self.size))
    self.group = "(" + ",".join(ns) + ")"
    self.v = matrix([[0]]*self.size)
    self.v[0,0] = 1

  def flag(self, number, index):
    tpl = binary_tuple(number, self.length)
    return tpl[index] == 1

  def invert(self, number, index):
    tpl = list(binary_tuple(number, self.length))
    tpl[index] = abs(tpl[index] - 1)
    return from_binary_tuple(tpl)

  def __repr__(self):
    nonzero = self.monomials()
    item = map(lambda x: self.monomial_string(x[0], x[1]), nonzero)
    return " + ".join(item)

  def monomials(self):
    en = self.list()
    return filter(lambda x: x[1] != 0, en)

  def list(self):
    return list(enumerate(self.v.columns()[0]))

  def binary_string(self, number):
    s = "{0:b}".format(number)
    if len(s) < self.length:
      s = "0" * (self.length - len(s)) + s
    return s

  def monomial_string(self, m, v):
    s = v
    if type(v) == Integer:
      s = "{0:d}".format(v)
    return "{0:s} |{1:s}>".format(s, self.binary_string(m))

class Gates:
  @classmethod
  def X(self, q, index):
    identity = matrix.identity(q.size)
    zeros = filter(lambda y: q.flag(y, index) == False, xrange(q.size))
    ones = map(lambda y: q.invert(y, index), zeros)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    q.v = identity.with_permuted_rows(tau) * q.v
    return q

  @classmethod
  def Y(self, q, index):
    identity = matrix.identity(q.size)
    zeros = filter(lambda y: q.flag(y, index) == False, xrange(q.size))
    ones = map(lambda y: q.invert(y, index), zeros)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    perm = identity.with_permuted_rows(tau)
    for index in zeros+ones:
      scale = i
      if index in ones:
        scale = -1*scale
      perm = perm.with_rescaled_row(index, scale)
    q.v = perm * q.v
    return q

  @classmethod
  def Z(self, q, index):
    perm = matrix.identity(q.size)
    ones = filter(lambda y: q.flag(y, index) == True, xrange(q.size))
    for index in ones:
      perm = perm.with_rescaled_row(index, -1)
    q.v = perm * q.v
    return q

  @classmethod
  def __Hrow(self, q, row, index):
    flag = q.flag(row, index)
    invert = q.invert(row, index)
    r = [0]*q.size
    r[invert] = 1
    if flag:
      r[row] = -1
    else:
      r[row] = 1
    return r

  @classmethod
  def H(self, q, index):
    rows = [self.__Hrow(q, ix, index) for ix in xrange(q.size)]
    m = matrix(QQbar, rows)
    m = (m.transpose())*2^(-1/2)
    q.v = m * q.v
    return q

  @classmethod
  def CNOT(self, q, control, ix2):
    identity = matrix.identity(q.size)
    ones = filter(lambda x: q.flag(x, control) and q.flag(x, ix2), xrange(q.size))
    zeros = map(lambda x: q.invert(x, ix2), ones)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    perm = identity.with_permuted_rows(tau)
    q.v = perm * q.v
    return q


class Solution:
  def assert_signs(self, q, signs):
    mons = q.monomials()
    signed = map(lambda m: (m[0], self.sign(m[1])), mons)
    assert signed == signs, "signs not equal: {0:s}, {1:s}".format(signs, q)

  def sign(self, x):
    if x < 0:
      return -1
    if x > 0:
      return 1
    return 0

class PlusMinusSolution(Solution):
  def plus_minus_state(self, q, sign):
    assert q.length == 1
    if sign < 0:
      Gates.X(q,0)
    Gates.H(q,0)

  def test_plus_minus_state(self):
    print("generating plus minus states")
    expectations = [
      [(0,1), (1,1)],
      [(0,1), (1,-1)]
    ]
    for exp, sign in zip(expectations, [1, -1]):
      q = Qubits(1)
      self.plus_minus_state(q, sign)
      self.assert_signs(q, exp)
    print("plus minus states solved")

class BellSolution(Solution):
  def bell_state(self, q, index):
    assert q.length == 2
    Gates.H(q, 0)
    Gates.CNOT(q, 0, 1)
    if index % 2 == 1:
      Gates.Z(q, 1)
    if index >= 2:
      Gates.X(q, 1)

  def test_bell_states(self):
    print("checking bell states")
    expectations = [
      [(0,1),(3,1)],
      [(0,1),(3,-1)],
      [(1,1),(2,1)],
      [(1,1),(2,-1)],
    ]
    for ix, ex in enumerate(expectations):
      q = Qubits(2)
      self.bell_state(q, ix)
      self.assert_signs(q, ex)
    print("bell states equal")

class GHZSolution(Solution):
  def ghz_state(self, q):
    l = q.length
    Gates.H(q, 0)
    for ix in xrange(1, l):
      Gates.CNOT(q, 0, ix)

  def test_ghz_states(self):
    print("testing ghz states")
    total = 5
    expectations = map(lambda x: [(0,1), (2^x-1, 1)], xrange(1, total+1))
    for exp, ix in zip(expectations, xrange(1, total + 1)):
      q = Qubits(ix)
      self.ghz_state(q)
      self.assert_signs(q, exp)
    print("ghz states equal")

def run_all_solutions():
  PlusMinusSolution().test_plus_minus_state()
  BellSolution().test_bell_states()
  GHZSolution().test_ghz_states()
