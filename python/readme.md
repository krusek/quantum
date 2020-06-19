This is a set of python classes/functions that I wrote to help my understanding of quantum operations.
I know there are several codebases for quantum operators, but I wanted to write my own to better
understand how quantum computing works internally. Also I found it convenient because most quantum
frameworks that I could find are a little more _honest_ and don't allow you to print out the values
of the quantum bits. I found this feature extremely helpful.

As a simple example here is how one would construct a GHZ state:

```{python}
l = 4
q = Qubits(l)
Gates.H(q, 0)
for ix in range(1, l):
  Gates.CNOT(q, 0, ix)
print(q)
```

This will output `1/2*sqrt(2) |0000> + 1/2*sqrt(2) |1111>`.

We can also perform measurements (currently only Z measurements are supported).

```{python}
m, q = Measurement.measure(q, 0)
print(m, q)
```

Assuming the `1` measurement was selected this will output `1` and `|1111>`.
