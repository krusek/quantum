import random
from sympy import *

half = Integer(1)/Integer(2)
two_negative_half_pow = Integer(2)**(-half)

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
    rm = v.transpose().conjugate()*v
    r = expand(rm[0])
    return sqrt(r)
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
    self.v = Matrix([Integer(0)]*self.size)
    self.v[0] = Integer(1)

  def clone(self):
    l = list(self.v)
    q = Qubits(self.length)
    q.v = Matrix(l)
    return q
  
  @classmethod
  def create(self, length, monomials):
    q = Qubits(length)
    l = [Integer(0)]*q.size
    for ix, v in monomials:
      print ix, v
      l[ix] = v
    q.v = Matrix(l)
    q.v = q.v / my_norm(q.v)
    return q

  def __repr__(self):
    nonzero = self.monomials()
    item = map(lambda x: self.monomial_string(x[0], x[1]), nonzero)
    return " + ".join(item)

  def monomials(self):
    en = self.list()
    return filter(lambda x: x[1] != 0, en)

  def list(self):
    return list(enumerate(list(self.v)))

  """Returns qubit of the form |000...00>+|111...11>"""
  @classmethod
  def ghz(self, length):
    q = Qubits(length)
    number = q.size
    l = [0]*(number)
    l[0] = Integer(2)**(-half)
    l[-1] = Integer(2)**(-half)
    q.v = Matrix(l)
    return q
  """"Returns qubits of the form |00...1>+|00...010>+...+|100...0>"""
  @classmethod
  def w(self, length):
    q = Qubits(length)
    l = [Integer(0)]*q.size
    for ix in xrange(length):
      number = Integer(2)**Integer(ix)
      l[number] = (Integer(1)/length)**(half)
    q.v = Matrix(l)
    return q

  @classmethod
  def wl(self, length, mx):
    q = Qubits(length)
    l = [Integer(0)]*q.size
    for ix in xrange(min(mx, length)):
      number = Integer(2)**Integer(ix)
      l[number] = two_negative_half_pow
    q.v = Matrix(l)
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
    v = Matrix(bells[ix])
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
      print v
      s = "{0:s}".format(v)
    return "{0:s} |{1:s}>".format(s, self.binary_string(m))


