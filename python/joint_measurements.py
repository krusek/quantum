# -*- coding: utf-8 -*-
from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import *
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *
from random import choice

class JointMeasurementTest(Solution):
  """// "Joint Measurements" quantum kata is a series of exercises designed
    // to get you familiar with programming in Q#.
    // It covers the joint parity measurements and using them for distinguishing quantum states
    // or for performing multi-qubit gates.
    
    // Each task is wrapped in one operation preceded by the description of the task.
    // Each task (except tasks in which you have to write a test) has a unit test associated with it,
    // which initially fails. Your goal is to fill in the blank (marked with // ... comment)
    // with some Q# code to make the failing test pass.
    
    // The tasks are given in approximate order of increasing difficulty; harder ones are marked with asterisks."""

  def test_04_ghz_or_w_state(self):
    """// Task 4. |0..0⟩ + |1..1⟩ or W state ?
    // Input: An even number of qubits (stored in an array) which are guaranteed to be
    //        either in superposition of states |0..0⟩ and |1..1⟩
    //        or in W state ( https://en.wikipedia.org/wiki/W_state ).
    // Output: 0 if qubits were in W state,
    //         1 if they were in the second superposition.
    // The state of the qubits at the end of the operation should be the same as the starting state."""
    for ix in range(2, 8, 2):
      for tp in [0, 1]:
        if tp == 1:
          q = Qubits.w(ix)
        else:
          q = Qubits.ghz(ix)
        qq = q.clone()
        m = self.ghz_or_w_state(q)
        assert m == tp, "wrong superposition chosen"
        self.assert_qubits(q, qq)
  
  def ghz_or_w_state(self, q):
    idx = list(range(q.length))
    paulis = map(lambda _: PauliZ(), idx)
    if Measurement.measurement(q, paulis, idx) == -1:
      return 1
    else:
      return 0

  def test_05_different_basis(self):
    """// Task 5. Parity measurement in different basis
    // Input: Two qubits (stored in an array) which are guaranteed to be
    //        either in superposition α|00⟩ + β|01⟩ + β|10⟩ + α|11⟩
    //        or in superposition α|00⟩ - β|01⟩ + β|10⟩ - α|11⟩.
    // Output: 0 if qubits were in the first superposition,
    //         1 if they were in the second superposition.
    // The state of the qubits at the end of the operation should be the same as the starting state."""
    
    for _ in range(10):
      for mul in [1, -1]:
        a, b = self.random_unit_vector(2)
        a = a / sqrt(2.0)
        b = b / sqrt(2.0)
        q = Qubits.create(2, [(0,a), (1, mul*b),(2, b), (3, mul*a)])
        qq = q.clone()
        d = self.different_basis(q)
        self.assert_qubits(q, qq)
        expected = 0 if mul == 1 else 1
        assert d == expected

  def different_basis(self, q):
    if Measurement.measurement(q, [PauliX(),PauliX()], [0, 1]) == -1:
      return 1
    else:
      return 0

  def test_06_controlled_x(self):
    """// Task 6. Controlled X gate with |0⟩ target
    // Input: Two unentangled qubits (stored in an array of length 2).
    //        The first qubit will be in state |ψ⟩ = α |0⟩ + β |1⟩, the second - in state |0⟩
    //        (this can be written as two-qubit state (α|0⟩ + β|1⟩) ⊕ |0⟩).
    // Goal:  Change the two-qubit state to α |00⟩ + β |11⟩ using only single-qubit gates and joint measurements.
    //        Do not use two-qubit gates.
    // You do not need to allocate extra qubits."""
    for _ in range(20):
      for rnd in [0.1, 0.9]:
        a,b = self.random_unit_vector(2)
        q = Qubits.create(2, [(0, a), (2, b)])

        qq = q.clone()
        Gates.CNOT(qq, 0, 1)
        self.controlled_x(q, rnd)
        self.assert_qubits(q, qq)
  
  def controlled_x(self, q, rnd):
    Gates.Z(q, 0)
    if Measurement.rr_measurement(q, [PauliZ(), PauliX()], [0, 1], rnd) == -1:
      Gates.Z(q, 1)
    
    Gates.H(q, 1)
    Gates.Z(q, 0)

  def test_07_controlled_x_general(self):
    for ix in range(20):
      a,b, c, d = self.random_unit_vector(4)
      q = Qubits.create(2, [(0, a), (1, b), (2, c), (3, d)])
      target = Qubits.create(2, [(0, a), (1, b), (2, d), (3, c)])
      print("before", q)
      self.controlled_x_general(q)
      print("after", q)
      self.assert_qubits(q, target)

  def controlled_x_general(self, q):
    # Gates.CNOT(q, 0, 1)
    items = [0.1, 0.9]
    r1, r2, r3 = choice(items), choice(items), choice(items)
    bad = [[0.1, 0.9, 0.9], [0.9, 0.9, 0.1]]
    if [r1, r2, r3] in bad:
      r1, r2, r3 = [0.1, 0.1, 0.1]
    print(r1, r2, r3)
    q.add_qubit()
    #print "before measurement", q
    p1 = self.copy_qubit(q, 1, 0, r1)
    #print "after measurement", q
    Gates.H(q, 0)
    Gates.H(q, 2)
    p2 = Measurement.rr_measurement(q, [PauliZ(), PauliZ()], [0, 2], r2)
    Gates.H(q, 0)
    Gates.H(q, 2)
    if p2 == -1:
      Gates.Z(q, 1)
    if p1 != Measurement.rr_measurement(q, [PauliZ()], [0], r3):
      Gates.X(q, 2)
    #print "after CNOT", q
    q.remove_qubit()
  
  def copy_qubit(self, q, source, target, r):
    Gates.H(q, target)
    return Measurement.rr_measurement(q, [PauliZ(), PauliZ()], [target, source], r)


  def random_unit_vector(self, length):
    v = [0]*length
    a = Float(random.random())
    v[0] = a
    s = a**2
    for ix in range(1, length-1):
      bs = (1-s) * Float(random.random())
      b = sqrt(bs)
      v[ix] = b
      s = s + bs
    v[-1] = sqrt(1-s)
    return v





if __name__ == '__main__':
  JointMeasurementTest().run_all_tests()