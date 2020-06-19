# -*- coding: utf-8 -*-
from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

class SuperpositionTest(Solution):
  """//////////////////////////////////////////////////////////////////
    // Welcome!
    //////////////////////////////////////////////////////////////////
    
    // "Superposition" quantum kata is a series of exercises designed
    // to get you familiar with programming in Q#.
    // It covers the following topics:
    //  - basic single-qubit and multi-qubit gates,
    //  - superposition,
    //  - flow control and recursion in Q#.
    
    // Each task is wrapped in one operation preceded by the description of the task.
    // Each task (except tasks in which you have to write a test) has a unit test associated with it,
    // which initially fails. Your goal is to fill in the blank (marked with // ... comment)
    // with some Q# code to make the failing test pass.
    
    // The tasks are given in approximate order of increasing difficulty; harder ones are marked with asterisks."""
  
  """// Task 1. Plus state
    // Input: a qubit in |0⟩ state (stored in an array of length 1).
    // Goal: create a |+⟩ state on this qubit (|+⟩ = (|0⟩ + |1⟩) / sqrt(2))."""
  def test_01_plus_state(self):
    q = Qubits(1)
    self.plus_state(q)
    self.assert_signs(q, [(0,1),(1,1)])
  
  def plus_state(self, q):
    return Gates.H(q, 0)
  
  """// Task 2. Minus state
    // Input: a qubit in |0⟩ state (stored in an array of length 1).
    // Goal: create a |-⟩ state on this qubit (|-⟩ = (|0⟩ - |1⟩) / sqrt(2))."""
  def test_02_minus_state(self):
    q = Qubits(1)
    self.minus_state(q)
    self.assert_signs(q, [(0,1),(1,-1)])
  
  def minus_state(self, q):
    Gates.X(q, 0)
    self.plus_state(q)
  
  """// Task 3*. Unequal superposition
    // Inputs:
    //      1) a qubit in |0⟩ state (stored in an array of length 1).
    //      2) angle alpha, in radians, represented as Double
    // Goal: create a cos(alpha) * |0⟩ + sin(alpha) * |1⟩ state on this qubit."""
  def test_03_unequal_superposition(self):
    q = Qubits(1)
    self.unequal_superposition(q, -2*pi/3)
    self.assert_signs(q, [(0, cos(pi/3)), (1, sin(pi/3))])
  
  def unequal_superposition(self, q, alpha):
    Gates.RY(q, alpha, 0)
  
  """// Task 4. Superposition of all basis vectors on two qubits
    // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // Goal:  create the following state on these qubits: (|00⟩ + |01⟩ + |10⟩ + |11⟩) / 2."""
  def test_04_superposition(self):
    q = Qubits(2)
    self.superposition(q)
    self.assert_signs(q, [(0,1),(1,1),(2,1),(3,1)])
  
  def superposition(self, q):
    Gates.H(q, 0)
    Gates.H(q, 1)
  
  """// Task 5. Superposition of basis vectors with phases
    // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // Goal:  create the following state on these qubits: (|00⟩ + i*|01⟩ - |10⟩ - i*|11⟩) / 2."""
  def test_05_superposition_basis(self):
    q = Qubits(2)
    self.superposition_basis(q)
    self.assert_signs(q, [(0, half), (1, I/2), (2, -half), (3, -I/2)])
  
  def superposition_basis(self, q):
    self.superposition(q)
    Gates.Z(q, 0)
    Gates.R1(q, pi, 1)
  
  """// Task 6. Bell state
    // Input: two qubits in |00⟩ state (stored in an array of length 2).
    // Goal: create a Bell state |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2) on these qubits."""
  def test_06_bell_states(self):
    q = Qubits(2)
    self.bell_state(q)
    self.assert_signs(q, [(0,1), (3,1)])
  
  def bell_state(self, q):
    Gates.H(q, 0)
    return Gates.CNOT(q, 0, 1)
  
  """// Task 7. All Bell states
    // Inputs:
    //      1) two qubits in |00⟩ state (stored in an array of length 2)
    //      2) an integer index
    // Goal: create one of the Bell states based on the value of index:
    //       0: |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2)
    //       1: |Φ⁻⟩ = (|00⟩ - |11⟩) / sqrt(2)
    //       2: |Ψ⁺⟩ = (|01⟩ + |10⟩) / sqrt(2)
    //       3: |Ψ⁻⟩ = (|01⟩ - |10⟩) / sqrt(2)"""
  def test_07_all_bell_states(self):
    self.__bell_state_helper(0, [(0,1),(3,1)])
    self.__bell_state_helper(1, [(0,1),(3,-1)])
    self.__bell_state_helper(2, [(1,1),(2,1)])
    self.__bell_state_helper(3, [(1,1),(2,-1)])

  
  def __bell_state_helper(self, ix, signs):
    q = Qubits(2)
    self.all_bell_states(q, ix)
    self.assert_signs(q, signs)

  
  def all_bell_states(self, q, ix):
    Gates.H(q, 0)
    if ix >= 2:
      Gates.X(q, 1)
    Gates.CNOT(q, 0, 1)
    if ix % 2 == 1:
      Gates.Z(q, 0)
  
  """// Task 8. Greenberger–Horne–Zeilinger state
    // Input: N qubits in |0...0⟩ state.
    // Goal: create a GHZ state (|0...0⟩ + |1...1⟩) / sqrt(2) on these qubits."""
  def test_08_ghz_state(self):
    for ix in range(1, 5):
      q = Qubits(ix)
      self.ghz_state(q)
      self.assert_signs(q, [(0,1),(2**ix - 1, 1)])
  
  def ghz_state(self, q):
    Gates.H(q, 0)
    for ix in range(1,q.length):
      Gates.CNOT(q, 0, ix)
    return q
  
  """// Task 9. Superposition of all basis vectors
    // Input: N qubits in |0...0⟩ state.
    // Goal: create an equal superposition of all basis vectors from |0...0⟩ to |1...1⟩
    // (i.e. state (|0...0⟩ + ... + |1...1⟩) / sqrt(2^N) )."""
  def test_09_all_superposition(self):
    for ix in range(1, 5):
      q = Qubits(ix)
      self.all_superposition(q)
      signs = [*map(lambda x: (x, 1), range(0,2**ix))]
      self.assert_signs(q, signs)
  
  def all_superposition(self, q):
    for ix in range(q.length):
      Gates.H(q, ix)
  
  """// Task 10. Superposition of |0...0⟩ and given bit string
    // Inputs:
    //      1) N qubits in |0...0⟩ state
    //      2) bit string represented as Bool[]
    // Goal: create an equal superposition of |0...0⟩ and basis state given by the bit string.
    // Bit values false and true correspond to |0⟩ and |1⟩ states.
    // You are guaranteed that the qubit array and the bit string have the same length.
    // You are guaranteed that the first bit of the bit string is true.
    // Example: for bit string = [true, false] the qubit state required is (|00⟩ + |10⟩) / sqrt(2)."""
  def test_10_superposition_bitstring(self):
    self.assert_qubits(self.superposition_bitstring(Qubits(1), [True]), self.plus_state(Qubits(1)))
    self.assert_qubits(self.superposition_bitstring(Qubits(2), [True, True]), self.bell_state(Qubits(2)))
    self.assert_qubits(self.superposition_bitstring(Qubits(3), [True, True, True]), self.ghz_state(Qubits(3)))

    q = Qubits(2)
    b = [True, False]
    self.assert_signs(self.superposition_bitstring(q, b), [(0,1),(2,1)])

    q = Qubits(3)
    b = [True, False, True]
    self.assert_signs(self.superposition_bitstring(q, b), [(0,1),(5,1)])

    q = Qubits(6)
    b = [True, False, True, True, False, False]
    self.assert_signs(self.superposition_bitstring(q, b), [(0,1),(44,1)])

  def superposition_bitstring(self, q, bits):
    Gates.H(q, 0)
    for ix in range(1, len(bits)):
      if bits[ix]:
        Gates.CNOT(q, 0, ix)
    return q

  """// Task 11. Superposition of two bit strings
    // Inputs:
    //      1) N qubits in |0...0⟩ state
    //      2) two bit string represented as Bool[]s
    // Goal: create an equal superposition of two basis states given by the bit strings.
    // Bit values false and true correspond to |0⟩ and |1⟩ states.
    // Example: for bit strings [false, true, false] and [false, false, true]
    // the qubit state required is (|010⟩ + |001⟩) / sqrt(2).
    // You are guaranteed that the both bit strings have the same length as the qubit array,
    // and that the bit strings will differ in at least one bit."""
  def test_11_superposition_bitstrings(self):
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

  """// Task 12**. W state on 2^k qubits
    // Input: N = 2^k qubits in |0...0⟩ state.
    // Goal: create a W state (https://en.wikipedia.org/wiki/W_state) on these qubits.
    // W state is an equal superposition of all basis states on N qubits of Hamming weight 1.
    // Example: for N = 4, W state is (|1000⟩ + |0100⟩ + |0010⟩ + |0001⟩) / 2."""
  def test_12_w_state_2k(self):
    for k in range(3):
      l = 2**k
      q = Qubits(l)
      self.w_state_2k(q)
      #self.assert_qubits(q, Qubits.w(l))
  
  def w_state_2k(self, q):
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
  
  """// Task 13**. W state on arbitrary number of qubits
    // Input: N qubits in |0...0⟩ state (N is not necessarily a power of 2).
    // Goal: create a W state (https://en.wikipedia.org/wiki/W_state) on these qubits.
    // W state is an equal superposition of all basis states on N qubits of Hamming weight 1.
    // Example: for N = 3, W state is (|100⟩ + |010⟩ + |001⟩) / sqrt(3)."""
  def test_13_w_state(self):
    for k in range(2, 8):
      l = k
      q = Qubits(l)
      self.w_state(q)
      #self.assert_qubits(q, Qubits.w(l))
  
  def w_state(self, q):
    Gates.X(q, 0)
    power = 1
    missedpower = -1
    while power < q.length:
      oldpower = power
      power = power * 2
      if power > q.length:
        power = q.length
        missedpower = oldpower
      Gates.H(q, power - 1)
      for ix in range(oldpower-1):
        index = oldpower + ix
        if ix < q.length and index < q.length:
          Gates.CCNOT(q, ix, power - 1, index)
        if ix < q.length and index < q.length:
          Gates.CNOT(q, index, ix)
        if index < q.length:
          Gates.CNOT(q, index, power - 1)
      Gates.CNOT(q, power-1, oldpower-1)
    if missedpower > -1:
      Gates.CCNOT(q, 0, q.length - 1, 1)
      Gates.CCNOT(q, 1, 0, q.length - 1)
      m = Measurement.rr_measure(q, q.length - 1, 0)
      Gates.CCNOT(q, 1, 0, q.length - 1)
      Gates.CNOT(q, q.length - 1, 0)
      Gates.CNOT(q, q.length - 1, 1)
      return q
      # if m == 1:
      #   Gates.CCNOT(q, missedpower, 0, q.length - 1)
      #   Gates.CNOT(q, q.length - 1, missedpower)
      #   Gates.CNOT(q, q.length - 1, 0)
      #   return q
      # else:
      #   q.reset()
      #   return self.w_state(q)
  


if __name__ == '__main__':
  SuperpositionTest().run_all_tests()