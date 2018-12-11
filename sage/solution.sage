load("qubit.sage")

class Solution:
  """
  This is a simple class used to run solutions/tests. There is likely a built-in framework that
  could have been used, but I threw this together anyway.
  """
  def assert_signs(self, q, signs):
    mons = q.monomials()
    if mons == signs:
      return True
    signed = map(lambda m: (m[0], self.sign(m[1])), mons)
    assert signed == signs, "signs not equal: {0:s}, {1:s}".format(signs, q)

  def sign(self, x):
    if x < 0:
      return -1
    if x > 0:
      return 1
    return 0

  def run_all_tests(self):
    print "--- Test harness: {0:s} ---".format(self)
    ll = filter(lambda x: x.startswith("test_"), dir(self))
    for s in ll:
      print("running test: {0:s}".format(s))
      getattr(self, s)()
      print("passed test: {0:s}".format(s))
      print("------------")
