namespace Solution {
  open Microsoft.Quantum.Primitive;
  open Microsoft.Quantum.Canon;

  operation Solve (x : Qubit[], y : Qubit, b : Int[]) : ()
  {
    body
    {
      for (ix in 0..Length(x)-1) {
        if (b[ix] % 2 == 1) {
          CNOT(x[ix], y);
        }
      }
    }
  }
}
