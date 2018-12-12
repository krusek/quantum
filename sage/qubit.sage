import random

def binary_tuple(number, length):
  s = "{0:b}".format(number)
  if len(s) < length:
    s = "0" * (length - len(s)) + s
  return tuple(map(lambda x: int(x), list(s)))

def from_binary_tuple(tpl):
  sl = "".join(map(lambda x: str(x), tpl))
  return int(sl, 2)

def flag_value(monomial, varlength, index):
  tpl = binary_tuple(monomial, varlength)
  return tpl[index] == 1

def invert_index(monomial, varlength, index):
  tpl = list(binary_tuple(monomial, varlength))
  tpl[index] = abs(tpl[index] - 1)
  return from_binary_tuple(tpl)

def my_norm(v):
  # I keep getting floating point values rather than exact values.
  try:
    r = sage_eval("({0:s})^(1/2)".format(v.norm()^2))
    return r
  except:
    r = v.norm()
    return r

class Qubits:
  """
  This class represents an array of qubits.

  NOTE:

  Internally a sage vector object is used, but at this point it could easily be replaced with
  a simple list. Likely the only changes would be to remove the slower versions of the gates
  (oX, oY, oZ, etc) and to remove the Operators class. You would also need to update the my_norm
  function to do norm calculations.
  """

  """
  This is the default constructor for the Qubits class. It will create an array of qubits in the
  |00...0> basis state.

  Args:
    length (int): The number of qubits to create.
  """
  def __init__(self, length):
    self.length = length
    self.size = 2**length
    ns = map(lambda x: "{0:d}".format(x+1), xrange(self.size))
    self.group = "(" + ",".join(ns) + ")"
    self.reset()
  
  def reset(self):
    self.v = vector([0]*self.size)
    self.v[0] = 1
    

  def __repr__(self):
    nonzero = self.monomials()
    item = map(lambda x: self.monomial_string(x[0], x[1]), nonzero)
    return " + ".join(item)

  def monomials(self):
    en = self.list()
    return filter(lambda x: x[1] != 0, en)

  def list(self):
    return list(enumerate(self.v.list()))

  """Returns qubit of the form |000...00>+|111...11>"""
  @classmethod
  def ghz(self, length):
    q = Qubits(length)
    number = q.size
    l = [0]*(number)
    l[0] = 2^(-1/2)
    l[-1] = 2^(-1/2)
    q.v = vector(l)
    return q
  """"Returns qubits of the form |00...1>+|00...010>+...+|100...0>"""
  @classmethod
  def w(self, length):
    q = Qubits(length)
    l = [0]*q.size
    for ix in xrange(length):
      number = 2^ix
      l[number] = length^(-1/2)
    q.v = vector(l)
    return q

  @classmethod
  def wl(self, length, mx):
    q = Qubits(length)
    l = [0]*q.size
    for ix in xrange(min(mx, length)):
      number = 2^ix
      l[number] = length^(-1/2)
    q.v = vector(l)
    return q

  @classmethod
  def bell(self, ix):
    bells = [
      [1,0,0,1],
      [1,0,0,-1],
      [0,1,1,0],
      [0,1,-1,0]
    ]
    q = Qubits(2)
    v = vector(bells[ix])
    v = v / my_norm(v)
    q.v = v
    return q

  def binary_string(self, number):
    s = "{0:b}".format(number)
    if len(s) < self.length:
      s = "0" * (self.length - len(s)) + s
    return s

  def monomial_string(self, m, v):
    s = v
    if type(v) == Integer:
      s = "{0:d}".format(v)
    return "{0:s} |{1:s}>".format(s, self.binary_string(m))

