namespace Solution {
  open Microsoft.Quantum.Primitive;
  open Microsoft.Quantum.Canon;

  operation Solve (q : Qubit) : Int
  {
    body {
      mutable one = false;
      using (qs = Qubit[1]) {
        for (ix in 1..8) {
          CNOT(q, qs[0]);
          if (M(qs[0]) == One) {
            Reset(qs[0]);
            set one = true;
          }
        }
      }
      if (one) {
        return 1;
      }
      return 0;
    }
  }
}
