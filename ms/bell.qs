namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Blah () : ()
    {
        body
        {
          using (qs = Qubit[2]) {
            Solve(qs, 1);
            DumpMachine();
	          ResetAll(qs);
          }
        }
    }

    operation Solve (qs : Qubit[], index : Int) : ()
    {
      body {
        H(qs[0]);
        Z(qs[1]);
        if index > 1 {
          X(qs[1]);
        }
      }
    }
}
