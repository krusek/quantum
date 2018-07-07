namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[], bits0 : Bool[], bits1 : Bool[]) : ()
    {
      body {
        H(qs[0]);
        for (ix in 1..Length(qs)-1) {
          if (bits0[ix]) {
            CNOT(qs[0], qs[ix]);
          }
        }
        X(qs[0]);
        for (ix in 1..Length(qs)-1) {
          if (bits1[ix]) {
            CNOT(qs[0], qs[ix]);
          }
        }
        // Now they possibly only differ from the bit arrays by the first bit.
        // The piece of qs that is mostly like bits1 has a 1 and the piece that is
        // mostly like bits0 has a zero.
        if (bits0[0] != bits1[0]) {
          if (bits0[0]) {
            X(qs[0]);
          }
          return ();
        }
        let different = FindDifferent(bits0, bits1);
        // Now we know that bits1[0] == bits0[0].
        if (bits0[0] != bits0[different]) {
          X(qs[0]);
        }
        CNOT(qs[different], qs[0]);
      }
    }

    function FindDifferent(bits0 : Bool[], bits1 : Bool[]) : Int {
      for (ix in 1..Length(bits0)-1) {
        if (bits0[ix] != bits1[ix]) {
          return ix;
        }
      }
      return -1;
    }
}
