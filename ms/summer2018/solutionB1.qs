namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
      body {
        for (ix in 1..Length(qs)-1) {
          CNOT(qs[ix], qs[0]);
        }
        if (M(qs[0]) == One) {
          return 1;
        } else {
          return 0;
        }
      }
    }
}
