from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

half = Integer(1)/Integer(2)

"""
This file contains several subclasses of the Solution class. I used it as a playground to solve
various problems from:
http://codeforces.com/contest/1002

It now can serve as a sort of a test harness to ensure that refactors still work correctly. There
is a method run_all_solutions that will run all the tests in this file.
"""

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
    expectations = map(lambda x: [(0,1), (2**x-1, 1)], xrange(1, total+1))
    for exp, ix in zip(expectations, xrange(1, total + 1)):
      q = Qubits(ix)
      self.ghz_state(q)
      print q
      print exp
      self.assert_signs(q, exp)
    print("ghz states equal")

class SolutionA1(Solution):
  def generate_superposition(self, qs):
    for ix in range(qs.length):
      Gates.H(qs, ix)

  def assert_qubits(self, qs):
    coeff = sqrt(Integer(1)/qs.size)
    ll = [(ix, coeff) for ix in range(qs.size)]
    actual = qs.list()
    assert ll == actual, "{0:s} and {1:s} not equal".format(ll, actual)

  def test_superposition(self):
    for ix in range(1, 5):
      print "superposition for {0:d}".format(ix)
      qs = Qubits(ix)
      self.generate_superposition(qs)
      print qs
      self.assert_qubits(qs)

class SolutionA2(Solution):
  def test_superposition(self):
    q = Qubits(5)
    self.superposition(q, [True, False, False, True, True])
    self.assert_signs(q, [(0,1),(19,1)])
  
  def superposition(self, q, bits):
    Gates.H(q, 0)
    for ix in range(1, len(bits)):
      if bits[ix]:
        Gates.CNOT(q, 0, ix)

class SolutionA3(Solution):
  def test_superposition(self):
    q = Qubits(5)
    self.superposition_bitstrings(q, [True, False, False, True, True], [True, True, False, False, True])
    self.assert_signs(q, [(19, 1), (25, 1)])

    q = Qubits(5)
    self.superposition_bitstrings(q, [False, False, False, True, True], [False, True, False, False, True])
    self.assert_signs(q, [(3, 1), (9, 1)])

    q = Qubits(1)
    self.superposition_bitstrings(q, [True], [False])
    self.assert_signs(q, [(0,1), (1,1)])
    

  def __find_one_zero(self, bits1, bits2):
    """returns ix, bitsa, bitsb where ix is the first different index and bitsa has a 1 there."""
    for ix in range(len(bits1)):
      if bits1[ix] != bits2[ix]:
        return (ix, bits1, bits2) if bits1[ix] else (ix, bits2, bits1)
    return (-1, bits1, bits2)

  def superposition_bitstrings(self, q, bits1, bits2):
    ix, bitsa, bitsb = self.__find_one_zero(bits1, bits2)
    Gates.H(q, ix)
    for ii in range(0, len(bits1)):
      if ix == ii:
        continue
      if bitsb[ii]:
        Gates.X(q, ii)
        Gates.CNOT(q, ix, ii)

      if bitsa[ii]:
        Gates.CNOT(q, ix, ii)

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

class SolutionB1(Solution):
  def test_state_distinction(self):
    q = Qubits.w(5)
    assert self.state_distinction(q) == 1

    q = Qubits(5)
    assert self.state_distinction(q) == 0
  
  def state_distinction(self, q):
    for ix in range(q.length):
      if Measurement.measure(q, ix) == -1:
        return 1
    return 0

class SolutionB2(Solution):
  def check_state(self, q, rnd):
    l = q.length
    if l % 2 == 1:
      m = Measurement.rr_measure(q, l-1, rnd)
      if m == -1:
        m = Measurement.measure(q, 0)
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
    m = Measurement.measure(q, 0)
    if m == -1:
      return 1
    else:
      return 0

  def test_check_state(self):
    for size in [3,4]:
      for rnd in [0.1, 0.9]:
        q = Qubits.w(size)
        print("w{0:d} state for rnd = {1:f}".format(size, rnd))
        assert self.check_state(q, rnd) == 1, "incorrect w{0:d} state for m = {1:f}".format(size, rnd)

    for size in [3,4]:
      for rnd in [0.1, 0.9]:
        q = Qubits.ghz(size)
        print("ghz{0:d} state".format(size))
        assert self.check_state(q, rnd) == 0, "incorrect w{0:d} state for m = {1:f}".format(size, rnd)

class SolutionB3(Solution):
  @classmethod
  def s_state(self, ix):
    s = [
      [half, half, half, half],
      [half, -half, half, -half],
      [half, half, -half, -half],
      [half, -half, -half, half],
    ]
    q = Qubits(2)
    v = Matrix(s[ix])
    q.v = v
    return q

  def check_state(self, q):
    Gates.H(q, 0)
    Gates.H(q, 1)
    m = Measurement.measure(q, 0)
    mm = Measurement.measure(q, 1)
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
      [half, -half, -half, -half],
      [-half, half, -half, -half],
      [-half, -half, half, -half],
      [-half, -half, -half, half],
    ]
    q = Qubits(2)
    v = Matrix(s[ix])
    q.v = v
    return q

  def check_state(self, q):
    Gates.H(q, 0)
    Gates.CNOT(q, 0, 1)
    Gates.H(q, 0)
    m = Measurement.measure(q, 0)
    mm = Measurement.measure(q, 1)
    ii = 0 if m == -1 else 1
    i = 0 if mm == -1 else 1
    return i + 2*ii

  def test_s_states(self):
    for ix in range(4):
      s = SolutionB4.s_state(ix)
      assert self.check_state(s) == ix, "bad s state: {0:d}".format(ix)

class SolutionC1(Solution):
  def test_null(self):
    print "I don't know for sure what this algorithm does."

class SolutionC2(Solution):
  def test_null(self):
    print "I don't know for sure what this algorithm does."

class SolutionD1(Solution):
  def test_null(self):
    print "I don't know for sure what this algorithm does."

class SolutionD2(Solution):
  def test_null(self):
    print "I don't know for sure what this algorithm does."

class SolutionD3(Solution):
  def test_null(self):
    print "I don't know for sure what this algorithm does."

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
    oracle(q)
    for ix in xrange(n):
      Gates.H(q, ix)
    r = [True]*n
    for ix in xrange(n):
      m = Measurement.measure(q, ix)
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
    m = Measurement.measure(q, n)
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

# Contest preparation.
class SolutionE(Solution):
  def check_bell(self, q):
    Gates.CNOT(q, 0, 1)
    Gates.H(q, 0)
    m = Measurement.measure(q, 0)
    mm = Measurement.measure(q, 1)
    i = 0 if m == 1 else 1
    ii = 0 if mm == 1 else 1
    return i + 2*ii

  def test_check_bell(self):
    for ix in xrange(4):
      q = Qubits.bell(ix)
      assert self.check_bell(q) == ix, "incorrect for {0:d}".format(ix)

class QubitsAddRemove(Solution):
  def test_add_remove(self):
    q = Qubits.random_qubits(2)
    qq = q.clone()
    q.add_qubit()
    q.remove_qubit()
    self.assert_qubits(q, qq)

  def test_add_X_remove(self):
      q = Qubits.random_qubits(2)
      qq = q.clone()
      q.add_qubit()
      Gates.X(q, 0)
      q.remove_qubit()
      self.assert_qubits(q, qq)

  def test_add_CNOT_remove(self):
      q = Qubits.random_qubits(2)
      qq = q.clone()
      q.add_qubit()
      Gates.CNOT(q, 1, 0)
      q.remove_qubit()
      self.assert_qubits(q, qq)

def run_all_solutions():
  PlusMinusSolution().run_all_tests()
  BellSolution().run_all_tests()
  GHZSolution().run_all_tests()
  SolutionE().run_all_tests()
  SolutionA1().run_all_tests()
  SolutionA2().run_all_tests()
  SolutionA3().run_all_tests()
  SolutionA4().run_all_tests()
  SolutionB1().run_all_tests()
  SolutionB2().run_all_tests()
  SolutionB3().run_all_tests()
  SolutionB4().run_all_tests()
  SolutionC1().run_all_tests()
  SolutionC2().run_all_tests()
  SolutionD1().run_all_tests()
  SolutionD2().run_all_tests()
  SolutionD3().run_all_tests()
  SolutionE1().run_all_tests()
  QubitsAddRemove().run_all_tests()

if __name__ == '__main__':
  run_all_solutions()