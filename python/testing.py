from solution import Solution
from quantum.qubit import Qubits
from quantum.measurement import Measurement
from quantum.gates import Gates
from quantum.helpers import *
from sympy import *

def mZZ(q, ix, iy):
  Gates.CNOT(q, iy, ix)
  print q
  m = Measurement.measure(q, ix)
  print m, q
  Gates.CNOT(q, iy, ix)
  print m, q

def mXX(q, ix, iy):
  Gates.H(q, ix)
  print q
  Gates.H(q, iy)
  print q
  Gates.CNOT(q, iy, ix)
  print q
  m = Measurement.measure(q, ix)
  print m, q
  Gates.CNOT(q, iy, ix)
  print m, q
  Gates.H(q, iy)
  print m, q
  Gates.H(q, ix)
  print m, q

def mZX(q, ix, iy):
  Gates.H(q, iy)
  Gates.CNOT(q, iy, ix)
  m = Measurement.measure(q, ix)
  Gates.CNOT(q, iy, ix)
  Gates.H(q, iy)
  print m, q
