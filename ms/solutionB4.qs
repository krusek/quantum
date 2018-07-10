namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
      body {
        H(qs[0]);
        CNOT(qs[0], qs[1]);
        H(qs[0]);
        mutable sum = 0;
        if (M(qs[0]) != One) {
          set sum = sum + 2;
        }
        if (M(qs[1]) != One) {
          set sum = sum + 1;
        }
        return sum;
      }
    }
}
