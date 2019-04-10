namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[], bits : Bool[]) : ()
    {
      body {
        H(qs[0]);
        for (ix in 1..Length(qs)-1) {
          if (bits[ix]) {
            CNOT(qs[0], qs[ix]);
          }
        }
      }
    }
}
