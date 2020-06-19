from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import *
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *
from mpmath import *

# This is just a file that I created to play around with 
# different attempts at solving problems.

def mZZ(q, ix, iy):
  Gates.CNOT(q, iy, ix)
  print(q)
  m = Measurement.measure(q, ix)
  print(m, q)
  Gates.CNOT(q, iy, ix)
  print(m, q)

def mXX(q, ix, iy):
  Gates.H(q, ix)
  print(q)
  Gates.H(q, iy)
  print(q)
  Gates.CNOT(q, iy, ix)
  print(q)
  m = Measurement.measure(q, ix)
  print(m, q)
  Gates.CNOT(q, iy, ix)
  print(m, q)
  Gates.H(q, iy)
  print(m, q)
  Gates.H(q, ix)
  print(m, q)

def mZX(q, ix, iy):
  Gates.H(q, iy)
  Gates.CNOT(q, iy, ix)
  m = Measurement.measure(q, ix)
  Gates.CNOT(q, iy, ix)
  Gates.H(q, iy)
  print(m, q)


q = Qubits(2)
Gates.H(q, 0)
Gates.X(q, 1)
m = Measurement.d_measurement(q, [PauliX(), PauliX()], [0, 1])
print(m)

q = Qubits(2)
m = Measurement.measurement(q, [PauliX(), PauliX()], [0, 1])
print(m)