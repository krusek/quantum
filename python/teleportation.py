# -*- coding: utf-8 -*-
from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

class TeleportationTest(Solution):
  def test_teleportation(self):
    q = Qubits(3)
    alice = 0
    bob = 1
    message = 2
    Gates.H(q, message)
    # entangle alice with bob
    Gates.H(q, alice)
    Gates.CNOT(q, alice, bob)
    # entangle message with alice
    print Gates.CNOT(q, message, alice)
    print Gates.H(q, message)
    am = Measurement.measure(q, alice)
    mm = Measurement.measure(q, message)
    print am == -1, mm == -1, q


if __name__ == '__main__':
  TeleportationTest().run_all_tests()