namespace Solution {
  open Microsoft.Quantum.Primitive;
  open Microsoft.Quantum.Canon;

  operation Solve (q : Qubit) : Int
  {
    body {
      let rnd = Random([0.5; 0.5]);
      if (rnd == 0) {
        H(q);
      }
      if (M(q) == One) {
        if (rnd == 0) {
          return 0;
        } else {
          return 1;
        }
      }
      return -1;
    }
  }
}
