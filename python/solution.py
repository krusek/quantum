from quantum.qubit import Qubits
from quantum.helpers import *

class Solution:
  """
  This is a simple class used to run solutions/tests. There is likely a built-in framework that
  could have been used, but I threw this together anyway.
  """
  def assert_signs(self, q, signs):
    mons = q.monomials()
    if mons == signs:
      return True
    signed = [*map(lambda m: (m[0], self.sign(m[1])), mons)]
    assert signed == signs, F"signs not equal: {signed} != {signs}, {q}"
  
  def assert_qubits(self, q1, q2):
    l1 = list(q1.v)
    l2 = list(q2.v)
    n = sum(map(lambda ix: (l1[ix] - l2[ix])**2, range(len(l1))))
    assert (n < 0.001), "qubits not equal"

  def sign(self, x):
    if x < 0:
      return -1
    if x > 0:
      return 1
    return 0

  def run_all_tests(self):
    print(F"--- Test harness: {self} ---")
    ll = filter(lambda x: x.startswith("test_"), dir(self))
    for s in ll:
      print(F"running test: {s}")
      getattr(self, s)()
      print(F"passed test: {s}")
      print("------------")
