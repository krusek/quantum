namespace Solution {
  open Microsoft.Quantum.Primitive;
  open Microsoft.Quantum.Canon;

  operation Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Int[]
  {
    body
    {
      mutable resultsArray = new Int[N];
      using (qubits = Qubit[N+1]) {
        X(qubits[N]);
        ApplyToEach(H, qubits);
        Uf(qubits[0..N-1], qubits[N]);
        ApplyToEach(H, qubits[0..N-1]);
        for (ix in 0..N-1) {
          let m = MResetZ(qubits[ix]);
          if (m == Zero) {
            set resultsArray[ix] = 0;
          } else {
            set resultsArray[ix] = 1;
          }
        }
        Reset(qubits[N]);
      }
      return resultsArray;
    }
  }
}
