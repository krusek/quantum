load("solution.sage")
load("measurement.sage")
load("gates.sage")
load("operators.sage")

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

class SolutionA4(Solution):
  def w_state(self, q):
    Gates.X(q, 0)
    power = 1
    while power < q.length:
      oldpower = power
      power = power * 2
      Gates.H(q, power - 1)
      for ix in range(oldpower-1):
        index = oldpower + ix
        Gates.CCNOT(q, ix, power - 1, index)
        Gates.CNOT(q, index, ix)
        Gates.CNOT(q, index, power - 1)
      Gates.CNOT(q, power-1, oldpower-1)
    return q

class SolutionE(Solution):
  def check_bell(self, q):
    Gates.CNOT(q, 0, 1)
    Gates.H(q, 0)
    m, q = Measurement.measure(q, 0)
    mm, q = Measurement.measure(q, 1)
    i = 0 if m == 1 else 1
    ii = 0 if mm == 1 else 1
    return i + 2*ii

  def test_check_bell(self):
    for ix in xrange(4):
      q = Qubits.bell(ix)
      assert self.check_bell(q) == ix, "incorrect for {0:d}".format(ix)

class SolutionB2(Solution):
  def check_state(self, q, rnd):
    l = q.length
    if l % 2 == 1:
      m, q = Measurement.r_measure(q, l-1, rnd)
      if m == -1:
        m, q = Measurement.measure(q, 0)
        if m == 1:
          return 1
        if m == -1:
          return 0
        return
      l = l - 1

    for ix in xrange(1, l):
      Gates.CNOT(q, ix, 0)
    for ix in xrange(1, l):
      Gates.CNOT(q, 0, ix)
    # if l % 2 == 1:
    #   Gates.H(q, 0)
    m, q = Measurement.measure(q, 0)
    if m == -1:
      return 1
    else:
      return 0

  def test_check_state(self):
    for size in [3,4]:
      for rnd in [0.1, 0.9]:
        q = Qubits.w(size)
        print("w{0:d} state for rnd = {1:s}".format(size, rnd))
        assert self.check_state(q, rnd) == 1, "incorrect w{0:d} state for m = {1:s}".format(size, rnd)

    for size in [3,4]:
      for rnd in [0.1, 0.9]:
        q = Qubits.ghz(size)
        print("ghz{0:d} state".format(size))
        assert self.check_state(q, rnd) == 0, "incorrect w{0:d} state for m = {1:s}".format(size, rnd)

class SolutionB3(Solution):
  @classmethod
  def s_state(self, ix):
    s = [
      [1/2, 1/2, 1/2, 1/2],
      [1/2, -1/2, 1/2, -1/2],
      [1/2, 1/2, -1/2, -1/2],
      [1/2, -1/2, -1/2, 1/2],
    ]
    q = Qubits(2)
    v = vector(s[ix])
    q.v = v
    return q

  def check_state(self, q):
    Gates.H(q, 0)
    Gates.H(q, 1)
    m, q = Measurement.measure(q, 0)
    mm, q = Measurement.measure(q, 1)
    ii = 0 if m == 1 else 1
    i = 0 if mm == 1 else 1
    return i + 2*ii

  def test_s_states(self):
    for ix in range(4):
      s = SolutionB3.s_state(ix)
      assert self.check_state(s) == ix, "bad s state: {0:d}".format(ix)

class SolutionB4(Solution):
  @classmethod
  def s_state(self, ix):
    s = [
      [1/2, -1/2, -1/2, -1/2],
      [-1/2, 1/2, -1/2, -1/2],
      [-1/2, -1/2, 1/2, -1/2],
      [-1/2, -1/2, -1/2, 1/2],
    ]
    q = Qubits(2)
    v = vector(s[ix])
    q.v = v
    return q

  def check_state(self, q):
    Gates.H(q, 0)
    Gates.CNOT(q, 0, 1)
    Gates.H(q, 0)
    m, q = Measurement.measure(q, 0)
    mm, q = Measurement.measure(q, 1)
    ii = 0 if m == -1 else 1
    i = 0 if mm == -1 else 1
    return i + 2*ii

  def test_s_states(self):
    for ix in range(4):
      s = SolutionB4.s_state(ix)
      assert self.check_state(s) == ix, "bad s state: {0:d}".format(ix)

class OracleE1:
  def __init__(self, bits):
    self.b = bits
    self.called = False

  def oracle(self, qs):
    assert qs.length == (len(self.b) + 1), "incorrect qubit length"
    assert self.called == False, "can only call oracle once"
    for ix, b in enumerate(self.b):
      if b:
        Gates.CNOT(qs, ix, qs.length - 1)
    self.called = True


class SolutionE1(Solution):
  def check_bva(self, n, oracle):
    q = Qubits(n+1)
    Gates.X(q, n)
    for ix in xrange(n+1):
      Gates.H(q, ix)
    print("preparred: ", q)
    oracle(q)
    print("ran oracle: ", q)
    for ix in xrange(n):
      Gates.H(q, ix)
    print("reorganized: ", q)
    r = [True]*n
    for ix in xrange(n):
      m, q = Measurement.measure(q, ix)
      print "measurement", m, q
      if m == -1:
        Gates.X(q, ix)
      r[ix] = (m != 1)
    return r

  def test_bva(self):
    bits = [True, True, True]
    oracle = OracleE1(bits).oracle
    value = self.check_bva(len(bits), oracle)
    assert value == bits, "incorrect returned bitstring"

class OracleE2:
  def __init__(self, bits):
    self.b = bits
    self.called = False

  def oracle(self, qs):
    assert qs.length == (len(self.b) + 1), "incorrect qubit length"
    for ix, b in enumerate(self.b):
      if b:
        Gates.CNOT(qs, ix, qs.length - 1)
      else:
        Gates.X(qs, ix)
        Gates.CNOT(qs, ix, qs.length - 1)
        Gates.X(qs, ix)


class SolutionE2(Solution):
  def check_bva(self, n, oracle):
    q = Qubits(n+1)
    oracle(q)
    m, q = Measurement.measure(q, n)
    v = 1 if m == -1 else 0
    r = [True]*n
    if n % 2 != v:
      r[-1] = False
    return r

  def test_bva(self):
    bits = [True, True, False]
    oracle = OracleE2(bits).oracle
    value = self.check_bva(len(bits), oracle)
    voracle = OracleE2(value).oracle
    q = Qubits(len(bits)+1)
    vv = voracle(q)
    bv = oracle(q)
    assert vv == bv, "incorrect returned bitstring"
    bits = [True, True, False, True]
    oracle = OracleE2(bits).oracle
    value = self.check_bva(len(bits), oracle)
    voracle = OracleE2(value).oracle
    q = Qubits(len(bits)+1)
    vv = voracle(q)
    bv = oracle(q)
    assert vv == bv, "incorrect returned bitstring"


def run_all_solutions():
  PlusMinusSolution().run_all_tests()
  BellSolution().run_all_tests()
  GHZSolution().run_all_tests()
  SolutionE().run_all_tests()
  SolutionA4().run_all_tests()
  SolutionB2().run_all_tests()
  SolutionB3().run_all_tests()
  SolutionB4().run_all_tests()
