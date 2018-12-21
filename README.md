This repository is broken up into a few folders. Here's a rough summary of the contents of each
folder.

# python/quantum

This folder contains python code that uses sympy that I have written that simulates a quantum computer. You can
create qubit arrays and it includes the following gates:

```
X
Y
Z
H
CNOT
CCNOT
```

You can also perform arbitrary Pauli measurements. I plan on adding more in the future.

The main reason I wrote this code was to better understand how quantum computing works and so I
could more easily see what happens when different gates are applied to arrays of qubits. It is not
necessarily expected to be a particularly fast implementation.

#python

This folder contains several tests that verify the quantum computer and help me make sure that I understand quantum computing.

# tex

This folder contains notes and exercises from the book Quantum Computation and Quantum Information.
Both are a work in progress as I work through the book.

# ms

This folder contains my solutions to a Microsoft Q# coding competition:

http://codeforces.com/contest/1002

C1 is the only one that I didn't solve, and I haven't updated the code to a valid solution.
