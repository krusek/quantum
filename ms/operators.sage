load("qubit.sage")
class Operators:
  @classmethod
  def X(self, qcount, index):
    size = 2^qcount
    identity = matrix.identity(size)
    zeros = filter(lambda y: flag_value(y, qcount, index) == False, xrange(size))
    ones = map(lambda y: invert_index(y, qcount, index), zeros)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    return identity.with_permuted_rows(tau)

  @classmethod
  def Y(self, qcount, index):
    size = 2^qcount
    identity = matrix.identity(size)
    zeros = filter(lambda y: flag_value(y, qcount, index) == False, xrange(size))
    ones = map(lambda y: invert_index(y, qcount, index), zeros)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    perm = identity.with_permuted_rows(tau)
    for index in zeros+ones:
      scale = i
      if index in ones:
        scale = -1*scale
      perm = perm.with_rescaled_row(index, scale)
    return perm

  @classmethod
  def Z(self, qcount, index):
    size = 2**qcount
    perm = matrix.identity(size)
    ones = filter(lambda y: flag_value(y, qcount, index) == True, xrange(size))
    for index in ones:
      perm = perm.with_rescaled_row(index, -1)
    return perm

  @classmethod
  def __Hrow(self, qcount, row, index):
    flag = flag_value(row, qcount, index)
    invert = invert_index(row, qcount, index)
    r = [0]*(2^qcount)
    r[invert] = 1
    if flag:
      r[row] = -1
    else:
      r[row] = 1
    return r

  @classmethod
  def H(self, qcount, index):
    size = 2^qcount
    rows = [self.__Hrow(qcount, ix, index) for ix in xrange(size)]
    m = matrix(QQbar, rows)
    m = (m.transpose())*2^(-1/2)
    return m

  @classmethod
  def CNOT(self, qcount, control, ix2):
    size = 2^qcount
    identity = matrix.identity(size)
    ones = filter(lambda x: flag_value(x, qcount, control) and flag_value(x, qcount, ix2), xrange(size))
    zeros = map(lambda x: invert_index(x, qcount, ix2), ones)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    perm = identity.with_permuted_rows(tau)
    return perm

  @classmethod
  def CCNOT(self, qcount, control1, control2, ix2):
    size = 2^qcount
    identity = matrix.identity(size)
    ones = filter(lambda x: flag_value(x, qcount, control1) and flag_value(x, qcount, control2) and flag_value(x, qcount, ix2), xrange(size))
    zeros = map(lambda x: invert_index(x, qcount, ix2), ones)
    pairs = map(lambda x: "({0:d},{1:d})".format(x[0]+1, x[1]+1), zip(zeros, ones))
    gs = "".join(pairs)
    G = PermutationGroup([gs])
    tau = G.gens()[0]
    perm = identity.with_permuted_rows(tau)
    return perm
