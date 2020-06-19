// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    
    /// <summary>
    /// Implement a unitary operation on a register of 𝑁 qubits that increments
    /// the number written in the register modulo 2𝑁.
    ///
    /// Your operation should take a register of type LittleEndian - an array
    /// of qubits that encodes an unsigned integer in little-endian format, 
    /// with the least significant bit written first (corresponding to the array
    /// element with index 0). The "output" of your solution is the state in 
    /// which it left the input qubits.
    ///
    /// For example, if the qubits passed to your operation are in the state 
    /// 12√(|11⟩+|10⟩)=12√(|3⟩+|1⟩), they should be transformed to the state 
    /// 12√(|(3+1)mod22⟩+|(1+1)mod22⟩)=12√(|0⟩+|2⟩)=12√(|00⟩+|01⟩).
    /// </summary>

    operation Solve (unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        using (qs = Qubit[2]) {
            H(qs[0]);
            Controlled unitary ([qs[0]], qs[1]);
            H(qs[0]);
            let m = M(qs[0]);
            ResetAll(qs);
            if (m == One) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}
