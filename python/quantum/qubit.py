import random
from helpers import *
from sympy import *

class Qubits:
  """
  This class represents an array of qubits.

  NOTE:

  Internally a sympy matrix object is used, but at this point it could easily be replaced with
  a simple list. You would need to update the my_norm function to do norm calculations. There
  are also a few places that modify the matrix directly.
  """

  def __init__(self, length):
    """
    This is the default constructor for the Qubits class. It will create an array of qubits in the
    |00...0> basis state.

    Keyword arguments:
      length -- The number of qubits to create.
    """
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

  @classmethod
  def ghz(self, length):
    """Returns qubit of the form |000...00>+|111...11>"""
    q = Qubits(length)
    number = q.size
    l = [0]*(number)
    l[0] = Integer(2)**(-half)
    l[-1] = Integer(2)**(-half)
    q.v = Matrix(l)
    return q
    
  @classmethod
  def w(self, length):
    """"Returns qubits of the form |00...1>+|00...010>+...+|100...0>"""
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
      s = "{0:s}".format(str(v))
    return "{0:s} |{1:s}>".format(str(float(s)), self.binary_string(m))


