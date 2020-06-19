START_STATE = 0
HALT_STATE = -1

FORWARD = 1
BACKWARD = -1

EMPTY_DATA = ""
START_DATA = "start"

class Turing:
  def __init__(self, tape_length = 100):
    self.tape = [EMPTY_DATA]*tape_length
    self.tape[0] = START_DATA

  def run(self, program, input):
    l = len(self.tape) - len(input) - 1
    self.tape = [START_DATA] + input + [EMPTY_DATA]*l
    index = 0
    state = START_STATE
    data = START_DATA
    line = self.find_step((state, data), program)
    while line != None and state != HALT_STATE:
      state, write, offset = line[1]
      self.tape[index] = write
      index = index + offset
      line = self.find_step((state, self.tape[index]), program)
    if state == HALT_STATE:
      print("completed")
      return self.trim_empty(self.tape)
    else:
      print("ERROR couldn't find", (state, self.tape[index]))
      return None

  def find_step(self, state, program):
    for line in program:
      if line[0] == state:
        return line
    return None

  def trim_empty(self, tape):
    length = len(tape)
    index = length-1
    for ix in range(length-1, 0, -1):
      if tape[ix] != EMPTY_DATA:
        index = ix
        break
    return tape[1:index+1]

def test_program():
  lines = [
    [(START_STATE, START_DATA), (1, START_DATA, 1)],
    [(1, 0), (1, EMPTY_DATA, 1)],
    [(1, 1), (1, EMPTY_DATA, 1)],
    [(1, EMPTY_DATA), (2, EMPTY_DATA, -1)],
    [(2, EMPTY_DATA), (2, EMPTY_DATA, -1)],
    [(2, START_DATA), (3, START_DATA, 1)],
    [(3, EMPTY_DATA), (HALT_STATE, 1, 0)],
  ]
  t = Turing([1,2,3], [1, 0], 50)
  print(t.run(lines, [1,0,1,1,0,1]))

def turing_reverse(input):
  """
  This simulates a turing machine that reverses binary input.
  """
  lines = [
    [(START_STATE, START_DATA), ("finding_end", START_DATA, FORWARD)],

    [("finding_end", 0), ("finding_end", 0, FORWARD)],
    [("finding_end", 1), ("finding_end", 1, FORWARD)],

    [("finding_end", EMPTY_DATA), ("on_end", EMPTY_DATA, BACKWARD)],

    [("on_end", 0), ("writing_digit_0", "a", FORWARD)],
    [("on_end", 1), ("writing_digit_1", "b", FORWARD)],

    [("writing_digit_0", "a"), ("writing_digit_0", "a", FORWARD)],
    [("writing_digit_0", "b"), ("writing_digit_0", "b", FORWARD)],
    [("writing_digit_0", "c"), ("writing_digit_0", "c", FORWARD)],
    [("writing_digit_1", "c"), ("writing_digit_1", "c", FORWARD)],
    [("writing_digit_0", "d"), ("writing_digit_0", "d", FORWARD)],
    [("writing_digit_1", "d"), ("writing_digit_1", "d", FORWARD)],
    [("writing_digit_1", "a"), ("writing_digit_1", "a", FORWARD)],
    [("writing_digit_1", "b"), ("writing_digit_1", "b", FORWARD)],

    [("writing_digit_0", EMPTY_DATA), ("finding_end_2", "c", BACKWARD)],
    [("writing_digit_1", EMPTY_DATA), ("finding_end_2", "d", BACKWARD)],

    [("finding_end_2", "a"), ("finding_end_2", "a", BACKWARD)],
    [("finding_end_2", "b"), ("finding_end_2", "b", BACKWARD)],
    [("finding_end_2", "c"), ("finding_end_2", "c", BACKWARD)],
    [("finding_end_2", "d"), ("finding_end_2", "d", BACKWARD)],

    [("finding_end_2", 0), ("writing_digit_0", "a", FORWARD)],
    [("finding_end_2", 1), ("writing_digit_1", "b", FORWARD)],

    [("finding_end_2", START_DATA), ("finding_start", START_DATA, FORWARD)],

    [("finding_start", "a"), ("finding_start", "a", FORWARD)],
    [("finding_start", "b"), ("finding_start", "b", FORWARD)],
    [("finding_start", "e"), ("finding_start", "e", FORWARD)],

    [("finding_start", "c"), ("writing_start_0", "e", BACKWARD)],
    [("finding_start", "d"), ("writing_start_1", "e", BACKWARD)],

    [("writing_start_0", "a"), ("writing_start_0", "b", BACKWARD)],
    [("writing_start_0", "b"), ("writing_start_0", "b", BACKWARD)],
    [("writing_start_0", "e"), ("writing_start_0", "e", BACKWARD)],

    [("writing_start_0", 0), ("writing_0", 0, FORWARD)],
    [("writing_start_0", 1), ("writing_0", 1, FORWARD)],
    [("writing_start_0", START_DATA), ("writing_0", START_DATA, FORWARD)],

    [("writing_start_1", "a"), ("writing_start_1", "b", BACKWARD)],
    [("writing_start_1", "b"), ("writing_start_1", "b", BACKWARD)],
    [("writing_start_1", "e"), ("writing_start_1", "e", BACKWARD)],

    [("writing_start_1", 0), ("writing_1", 0, FORWARD)],
    [("writing_start_1", 1), ("writing_1", 1, FORWARD)],
    [("writing_start_1", START_DATA), ("writing_1", START_DATA, FORWARD)],

    [("writing_1", "a"), ("finding_start", 1, FORWARD)],
    [("writing_1", "b"), ("finding_start", 1, FORWARD)],
    [("writing_0", "a"), ("finding_start", 0, FORWARD)],
    [("writing_0", "b"), ("finding_start", 0, FORWARD)],

    [("finding_start", EMPTY_DATA), ("cleaning_up", EMPTY_DATA, BACKWARD)],
    [("cleaning_up", "e"), ("cleaning_up", EMPTY_DATA, BACKWARD)],

    [("cleaning_up", 0), (HALT_STATE, 0, BACKWARD)],
    [("cleaning_up", 1), (HALT_STATE, 1, BACKWARD)],
  ]

  t = Turing(50)
  output = t.run(lines, input)
  reversed = input[:]
  reversed.reverse()
  assert reversed == output
  print("input", input)
  print("output", output)

def test_reverse():
  input = [1,1,0,1,1,0,0,1]
  turing_reverse(input)
  turing_reverse([1,1,1,0,1,1,0,0])
