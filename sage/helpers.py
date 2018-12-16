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