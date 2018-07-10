namespace Solution {
  open Microsoft.Quantum.Primitive;
  open Microsoft.Quantum.Canon;

  operation Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Int[]
  {
    body
    {
      mutable resultsArray = new Int[N];
      for (ix in 0..N-1) {
        set resultsArray[ix] = 0;
      }
      using (qubits = Qubit[N+1]) {
        Uf(qubits[0..N-1], qubits[N]);
        let result = M(qubits[N]);
        if (result == One && N % 2 == 0) {
          set resultsArray[0] = 1;
        }
        if (result == Zero && N % 2 == 1) {
          set resultsArray[0] = 1;
        }
        ResetAll(qubits);
      }
      return resultsArray;
    }
  }
}
