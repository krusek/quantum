# -*- coding: utf-8 -*-
from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

class MeasurementTest(Solution):
  """// "Measurements" quantum kata is a series of exercises designed
    // to get you familiar with programming in Q#.
    // It covers the following topics:
    //  - single-qubit measurements,
    //  - discriminating orthogonal and nonorthogonal states.
    
    // Each task is wrapped in one operation preceded by the description of the task.
    // Each task (except tasks in which you have to write a test) has a unit test associated with it,
    // which initially fails. Your goal is to fill in the blank (marked with // ... comment)
    // with some Q# code to make the failing test pass.
    
    // The tasks are given in approximate order of increasing difficulty; harder ones are marked with asterisks."""
  
  """// Task 1.1. |0⟩ or |1⟩ ?
    // Input: a qubit which is guaranteed to be in |0⟩ or |1⟩ state.
    // Output: true if qubit was in |1⟩ state, or false if it was in |0⟩ state.
    // The state of the qubit at the end of the operation does not matter."""
  def test_101_single_qubit(self):
    q = Qubits(1)
    assert self.single_qubit(q) == False
    q = Qubits(1)
    Gates.X(q, 0)
    assert self.single_qubit(q) == True

  def single_qubit(self, q):
    return Measurement.measure(q, 0) == -1

  """// Task 1.2. Set qubit to |0⟩ state
    // Input: a qubit in an arbitrary state.
    // Goal:  change the state of the qubit to |0⟩."""
  def test_102_reset_qubit(self):
    q = Qubits(1)
    self.reset_qubit(q)
    self.assert_signs(q, [(0,1)])
    q = Qubits(1)
    Gates.X(q, 0)
    self.reset_qubit(q)
    self.assert_signs(q, [(0,1)])
  
  def reset_qubit(self, q):
    if Measurement.measure(q, 0) == -1:
      Gates.X(q, 0)
  
  """// Task 1.3. |+⟩ or |-⟩ ?
    // Input: a qubit which is guaranteed to be in |+⟩ or |-⟩ state
    //        (|+⟩ = (|0⟩ + |1⟩) / sqrt(2), |-⟩ = (|0⟩ - |1⟩) / sqrt(2)).
    // Output: true if qubit was in |+⟩ state, or false if it was in |-⟩ state.
    // The state of the qubit at the end of the operation does not matter."""
  def test_103_check_plus_minus(self):
    q = Qubits(1)
    Gates.H(q, 0)
    assert self.check_plus_minus(q) == True
    q = Qubits(1)
    Gates.X(q, 0)
    Gates.H(q, 0)
    assert self.check_plus_minus(q) == False
  
  def check_plus_minus(self, q):
    Gates.H(q, 0)
    return not self.single_qubit(q)
  
  """// Task 1.4. |A⟩ or |B⟩ ?
    // Inputs:
    //      1) angle alpha, in radians, represented as Double
    //      2) a qubit which is guaranteed to be in |A⟩ or |B⟩ state
    //         |A⟩ =   cos(alpha) * |0⟩ + sin(alpha) * |1⟩,
    //         |B⟩ = - sin(alpha) * |0⟩ + cos(alpha) * |1⟩.
    // Output: true if qubit was in |A⟩ state, or false if it was in |B⟩ state.
    // The state of the qubit at the end of the operation does not matter."""
  def test_104_check_a_b(self):
    for aaa in [pi/6, pi/3, pi, pi + pi/3, pi + pi / 6]:
      q = Qubits.create(1, [(0, cos(aaa)), (1, sin(aaa))])
      assert self.check_a_b(q, aaa) == True

      q = Qubits.create(1, [(0, -sin(aaa)), (1, cos(aaa))])
      assert self.check_a_b(q, aaa) == False
  
  def check_a_b(self, q, alpha):
    Gates.Z(q, 0)
    Gates.RY(q, -2*alpha, 0)
    return not self.single_qubit(q)

  """// Task 1.5. |00⟩ or |11⟩ ?
    // Input: two qubits (stored in an array) which are guaranteed to be in |00⟩ or |11⟩ state.
    // Output: 0 if qubits were in |00⟩ state,
    //         1 if they were in |11⟩ state.
    // The state of the qubits at the end of the operation does not matter."""
  def test_105_zz_or_oo(self):
    q = Qubits(2)
    assert self.zz_or_oo(q) == False
    Gates.X(q, 0)
    Gates.X(q, 1)
    assert self.zz_or_oo(q) == True
  
  def zz_or_oo(self, q):
    return Measurement.measure(q, 0) == -1
  
  """// Task 1.6. Distinguish four basis states
    // Input: two qubits (stored in an array) which are guaranteed to be
    //        in one of the four basis states (|00⟩, |01⟩, |10⟩ or |11⟩).
    // Output: 0 if qubits were in |00⟩ state,
    //         1 if they were in |01⟩ state,
    //         2 if they were in |10⟩ state,
    //         3 if they were in |11⟩ state.
    // In this task and the subsequent ones the order of qubit states
    // in task description matches the order of qubits in the array
    // (i.e., |10⟩ state corresponds to qs[0] in state |1⟩ and qs[1] in state |0⟩).
    // The state of the qubits at the end of the operation does not matter."""
  def test_106_basis_state_measurement(self):
    for ix in range(4):
      q = Qubits.create(2, [(ix, 1)])
      assert self.basis_state_measurement(q) == ix
    
  def basis_state_measurement(self, q):
    s = 0
    if Measurement.measure(q, 0) == -1:
      s += 2
    if Measurement.measure(q, 1) == -1:
      s += 1
    return s

if __name__ == '__main__':
  MeasurementTest().run_all_tests()