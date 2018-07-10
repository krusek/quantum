namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : ()
    {
      body {
        X(qs[0]);
        if (Length(qs) == 1) {
          return ();
        }
        mutable power = 1;
        mutable oldpower = 1;
        repeat {
          set oldpower = power;
          set power = power * 2;
          H(qs[power - 1]);
          for (ix in 0..oldpower-2) {
            let index = oldpower + ix;
            CCNOT(qs[ix], qs[power-1], qs[index]);
            CNOT(qs[index], qs[ix]);
            CNOT(qs[index], qs[power-1]);
          }
          CNOT(qs[power-1], qs[oldpower-1]);
        } until (power >= Length(qs))
        fixup {}
      }
    }
}
