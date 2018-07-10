namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

  operation Solve (qs : Qubit[]) : Int
  {
    body {
      let l = Length(qs);
      if (l % 2 == 1) {
        if (M(qs[l-1]) == One) {
          if (M(qs[0]) == Zero) {
            return 1;
          } else {
            return 0;
          }
        }
      }

      for (ix in 1..l-1-(l%2)) {
        CNOT(qs[ix], qs[0]);
      }
      for (ix in 1..l-1-(l%2)) {
        CNOT(qs[0], qs[ix]);
      }
      if (M(qs[0]) == One) {
        return 1;
      } else {
        return 0;
      }
    }
  }
}
