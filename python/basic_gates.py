# -*- coding: utf-8 -*-
from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

class BasicGatesTest(Solution):
  # 
  # These katas are taken from: https://github.com/Microsoft/QuantumKatas
  #
  # // "Basic Gates" quantum kata is a series of exercises designed
  # // to get you familiar with the basic quantum gates in Q#.
  # // It covers the following topics:
  # //  - basic single-qubit and multi-qubit gates,
  # //  - adjoint and controlled gates,
  # //  - using gates to modify the state of a qubit.
  
  # // Each task is wrapped in one operation preceded by the description of the task.
  # // Each task (except tasks in which you have to write a test) has a unit test associated with it,
  # // which initially fails. Your goal is to fill in the blank (marked with // ... comment)
  # // with some Q# code to make the failing test pass.
  
  # // Most tasks can be done using exactly one gate.
  # // None of the tasks require measurement, and the tests are written so as to fail if qubit state is measured.
  
  # // The tasks are given in approximate order of increasing difficulty; harder ones are marked with asterisks.

  # //////////////////////////////////////////////////////////////////
  # // Part I. Single-Qubit Gates
  # //////////////////////////////////////////////////////////////////
  
  # // Task 1.1. State flip: |0> to |1> and vice versa
  # // Input: A qubit in state |\psi> = \alpha |0> + \beta |1>.
  # // Goal:  Change the state of the qubit to \alpha |1> + \beta |0>.
  # // Example:
  # //        If the qubit is in state |0>, change its state to |1>.
  # //        If the qubit is in state |1>, change its state to |0>.
  # // Note that this operation is self-adjoint: applying it for a second time
  # // returns the qubit to the original state.
  def state_flip(self, q):
    Gates.X(q, 0)

  def test_state_flip(self):
    q = Qubits(1)
    self.state_flip(q)
    self.assert_signs(q, [(1, 1)])
    self.state_flip(q)
    self.assert_signs(q, [(0,1)])

  """// Task 1.2. Basis change: |0⟩ to |+⟩ and |1⟩ to |-⟩ (and vice versa)
    // Input: A qubit in state |ψ⟩ = α |0⟩ + β |1⟩.
    // Goal:  Change the state of the qubit as follows:
    //        If the qubit is in state |0⟩, change its state to |+⟩ = (|0⟩ + |1⟩) / sqrt(2).
    //        If the qubit is in state |1⟩, change its state to |-⟩ = (|0⟩ - |1⟩) / sqrt(2).
    //        If the qubit is in superposition, change its state according to the effect on basis vectors.
    // Note:  |+⟩ and |-⟩ form a different basis for single-qubit states, called X basis.
    // |0⟩ and |1⟩ are called Z basis."""
  def test_basis_change(self):
    q = Qubits(1)
    self.basis_change(q)
    self.assert_signs(q, [(0,1),(1,1)])
    self.basis_change(q)
    self.assert_signs(q, [(0,1)])
    q.v[0] = 0
    q.v[1] = 1
    self.basis_change(q)
    self.assert_signs(q, [(0,1),(1,-1)])
    self.basis_change(q)
    self.assert_signs(q, [(1,1)])

  def basis_change(self, q):
    Gates.H(q, 0)
  
  """// Task 1.3. Sign flip: |+⟩ to |-⟩ and vice versa.
    // Input: A qubit in state |ψ⟩ = α |0⟩ + β |1⟩.
    // Goal:  Change the qubit state to α |0⟩ - β |1⟩ (flip the sign of |1⟩ component of the superposition)."""
  def test_sign_flip(self):
    q = Qubits.ghz(1)
    self.sign_flip(q)
    self.assert_signs(q, [(0,1), (1,-1)])
    self.sign_flip(q)
    self.assert_signs(q, [(0,1), (1, 1)])
  
  def sign_flip(self, q):
    Gates.Z(q, 0)

  """ // Task 1.4*. Amplitude change: |0⟩ to cos(alpha)*|0⟩ + sin(alpha)*|1⟩.
    // Inputs:
    //     1) A qubit in state β|0⟩ + γ|1⟩.
    //     2) Angle alpha, in radians, represented as Double
    // Goal:  Change the state of the qubit as follows:
    //        If the qubit is in state |0⟩, change its state to cos(alpha)*|0⟩ + sin(alpha)*|1⟩.
    //        If the qubit is in state |1⟩, change its state to -sin(alpha)*|0⟩ + cos(alpha)*|1⟩.
    //        If the qubit is in superposition, change its state according to the effect on basis vectors."""
  def test_amplitude_change(self):
    q = Qubits(1)
    self.amplitude_change(q, pi/3)
    self.assert_signs(q, [(0, half),(1,half*sqrt(3))])

    q = Qubits(1)
    Gates.X(q, 0)
    self.amplitude_change(q, pi/3)
    self.assert_signs(q, [(0,-half*sqrt(3)),(1, half)])


  def amplitude_change(self, q, alpha):
    Gates.RY(q, -2*alpha, 0)
  
  """// Task 1.5. Phase flip
    // Input: A qubit in state |ψ⟩ = α |0⟩ + β |1⟩.
    // Goal:  Change the qubit state to α |0⟩ + iβ |1⟩ (flip the phase of |1⟩ component of the superposition)."""
  def test_phase_flip(self):
    q = Qubits(1)
    self.phase_flip(q)
    self.assert_signs(q, [(0,1)])
    Gates.X(q, 0)
    self.phase_flip(q)
    self.assert_signs(q, [(1, I)])
  
  def phase_flip(self, q):
    Gates.R1(q, pi, 0)
  
  """// Task 1.6*. Phase change
    // Inputs:
    //     1) A qubit in state β|0⟩ + γ|1⟩.
    //     2) Angle alpha, in radians, represented as Double
    // Goal:  Change the state of the qubit as follows:
    //        If the qubit is in state |0⟩, don't change its state.
    //        If the qubit is in state |1⟩, change its state to exp(i*alpha)|1⟩.
    //        If the qubit is in superposition, change its state according to the effect on basis vectors."""
  def test_phase_change(self):
    aaa = symbols('aaa')
    q = Qubits(1)
    self.phase_change(q, aaa)
    self.assert_signs(q, [(0,1)])
    Gates.X(q, 0)
    self.phase_change(q, aaa)
    self.assert_signs(q, [(1, exp(I*aaa))])

  
  def phase_change(self, q, alpha):
    Gates.R1(q, alpha*2, 0)

  """// Task 1.7. Bell state change - 1
    // Input: Two entangled qubits in Bell state |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2).
    // Goal:  Change the two-qubit state to |Φ⁻⟩ = (|00⟩ - |11⟩) / sqrt(2)."""
  def test_bell_state_change(self):
    q = Qubits.bell(0)
    self.assert_signs(q, [(0,1), (3,1)])
    self.bell_state_change(q)
    self.assert_signs(q, [(0,1), (3,-1)])
  
  def bell_state_change(self, q):
    Gates().Z(q, 0)
  
  """// Task 1.8. Bell state change - 2
    // Input: Two entangled qubits in Bell state |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2).
    // Goal:  Change the two-qubit state to |Ψ⁺⟩ = (|01⟩ + |10⟩) / sqrt(2)."""
  def test_bell_state_change_2(self):
    q = Qubits.bell(0)
    self.assert_signs(q, [(0,1), (3,1)])
    self.bell_state_change_2(q)
    self.assert_signs(q, [(1,1), (2,1)])
  
  def bell_state_change_2(self, q):
    Gates().X(q,1)
    
  """// Task 1.9. Bell state change - 3
    // Input: Two entangled qubits in Bell state |Φ⁺⟩ = (|00⟩ + |11⟩) / sqrt(2).
    // Goal:  Change the two-qubit state to |Ψ⁻⟩ = (|01⟩ - |10⟩) / sqrt(2)."""
  def test_bell_state_change_3(self):
    q = Qubits.bell(0)
    self.assert_signs(q, [(0,1), (3,1)])
    self.bell_state_change_3(q)
    self.assert_signs(q, [(1,1), (2,-1)])
  
  def bell_state_change_3(self, q):
    Gates().X(q,1)
    Gates().Z(q,0)
  
  """// Task 2.1. Two-qubit gate - 1
    // Input: Two unentangled qubits (stored in an array of length 2).
    //        The first qubit will be in state |ψ⟩ = α |0⟩ + β |1⟩, the second - in state |0⟩
    //        (this can be written as two-qubit state (α|0⟩ + β|1⟩) ⊕ |0⟩).
    // Goal:  Change the two-qubit state to α |00⟩ + β |11⟩.
    // Note that unless the starting state of the first qubit was |0⟩ or |1⟩,
    // the resulting two-qubit state can not be represented as a tensor product
    // of the states of individual qubits any longer; thus the qubits become entangled."""
  def test_two_qubit_gate(self):
    q = Qubits(2)
    Gates().H(q, 0)
    self.two_qubit_gate(q)
    self.assert_signs(q, [(0,1), (3, 1)])

    q = Qubits(2)
    self.two_qubit_gate(q)
    self.assert_signs(q, [(0,1)])
  
  def two_qubit_gate(self, q):
    Gates().CX(q, 0, 1)
  
  """// Task 2.2. Two-qubit gate - 2
    // Input: Two qubits (stored in an array of length 2)
    //        in state |+⟩ ⊕ |+⟩ = (|00⟩ + |01⟩ + |10⟩ + |11⟩) / 2.
    // Goal:  Change the two-qubit state to (|00⟩ + |01⟩ + |10⟩ - |11⟩) / 2.
    // Note that while the starting state can be represented as a tensor product of single-qubit states,
    // the resulting two-qubit state can not be represented in such a way."""
  def test_two_qubit_gate_2(self):
    q = Qubits(2)
    Gates.H(q, 0)
    Gates.H(q, 1)
    self.two_qubit_gate_2(q)
    self.assert_signs(q, [(0,1),(1,1),(2,1),(3,-1)])
  
  def two_qubit_gate_2(self, q):
    Gates.CZ(q, 0, 1)

  """// Task 2.3. Two-qubit gate - 3
    // Input: Two qubits (stored in an array of length 2) in an arbitrary
    //        two-qubit state α|00⟩ + β|01⟩ + γ|10⟩ + δ|11⟩.
    // Goal:  Change the two-qubit state to α|00⟩ + γ|01⟩ + β|10⟩ + δ|11⟩."""
  def test_two_qubit_gate_3(self):
    q = Qubits(2)
    # Assert that |01> -> |10>
    Gates.X(q, 1)
    self.two_qubit_gate_3(q)
    self.assert_signs(q, [(2,1)])

    # Assert that |10> -> |01>
    self.two_qubit_gate_3(q)
    self.assert_signs(q, [(1,1)])

    # Assert that |00> -> |00>
    q = Qubits(2)
    self.two_qubit_gate_3(q)
    self.assert_signs(q, [(0,1)])

    # Assert that |11> -> |11>
    Gates.X(q, 0)
    Gates.X(q, 1)
    self.assert_signs(q, [(3,1)])
    self.two_qubit_gate_3(q)
    self.assert_signs(q, [(3,1)])

  def two_qubit_gate_3(self, q):
    Gates.CNOT(q, 0, 1)
    Gates.CNOT(q, 1, 0)
    Gates.CNOT(q, 0, 1)
  
  """// Task 2.4. Toffoli gate
    // Input: Three qubits (stored in an array of length 3) in an arbitrary three-qubit state
    //        α|000⟩ + β|001⟩ + γ|010⟩ + δ|011⟩ + ε|100⟩ + ζ|101⟩ + η|110⟩ + θ|111⟩.
    // Goal:  Flip the state of the third qubit if the state of the first two is |11⟩:
    //        i.e., change the three-qubit state to
    //        α|000⟩ + β|001⟩ + γ|010⟩ + δ|011⟩ + ε|100⟩ + ζ|101⟩ + θ|110⟩ + η|111⟩."""
  def test_toffoli_gate(self):
    for x in [True, False]:
      for y in [True, False]:
        for z in [True, False]:
          q = Qubits(3)
          m = 0
          if x:
            Gates.X(q, 0)
            m = m + 4
          if y:
            Gates.X(q, 1)
            m = m + 2
          if z:
            Gates.X(q, 2)
          if x and y:
            if not z:
              m = m + 1
          elif z:
            m = m + 1
          self.toffoli_gate(q)
          self.assert_signs(q, [(m, 1)])
  
  def toffoli_gate(self, q):
    Gates.CCNOT(q, 0, 1, 2)
  
  """ // Task 2.5. Fredkin gate
    // Input: Three qubits (stored in an array of length 3) in an arbitrary three-qubit state
    //        α|000⟩ + β|001⟩ + γ|010⟩ + δ|011⟩ + ε|100⟩ + ζ|101⟩ + η|110⟩ + θ|111⟩.
    // Goal:  Swap the states of second and third qubit if and only if the state of the first qubit is |1⟩:
    //        α|000⟩ + β|001⟩ + γ|010⟩ + δ|011⟩ + ε|100⟩ + η|101⟩ + ζ|110⟩ + θ|111⟩."""
  def test_fredkin_gate(self):
    q = Qubits(3)
    Gates.X(q, 0)
    Gates.X(q, 1)
    self.fredkin_gate(q)
    self.assert_signs(q, [(5, 1)])

    q = Qubits(3)
    Gates.X(q, 0)
    Gates.X(q, 2)
    self.fredkin_gate(q)
    self.assert_signs(q, [(6, 1)])

    for x in [True, False]:
      for y in [True, False]:
        for z in [True, False]:
          if x and (y ^ z):
            continue
          q = Qubits(3)
          if x:
            Gates.X(q, 0)
          if y:
            Gates.X(q, 1)
          if z:
            Gates.X(q, 2)
          self.fredkin_gate(q)
          self.assert_signs(q, q.monomials())
  
  def fredkin_gate(self, q):
    Gates.CCNOT(q, 0, 1, 2)
    Gates.CCNOT(q, 0, 2, 1)
    Gates.CCNOT(q, 0, 1, 2)


if __name__ == '__main__':
  BasicGatesTest().run_all_tests()