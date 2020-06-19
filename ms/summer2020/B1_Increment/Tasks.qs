// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Arithmetic;
    
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

    operation Solve (register : LittleEndian) : Unit is Adj+Ctl {
        // let l = Length(register!);
        // using (qs = Qubit[l]) {
        //     X(qs[0]);
            
        //     for (ix in 0 .. (l-1)) {
        //         if (ix < l - 1) {
        //             CCNOT(qs[ix], register![ix], qs[ix + 1]);
        //         }
        //         CNOT(qs[ix], register![ix]);
        //     }
        //     for (ix in 2 .. (l)) {
        //         X(register![l-ix]);
        //         CCNOT(qs[l-ix], register![l-ix], qs[l-ix+1]);
        //         X(register![l-ix]);
        //     }
        //     X(qs[0]);
        // }
        Increment(register!);
    }

    operation Increment(qs: Qubit[]) : Unit is Adj+Ctl {
        if (Length(qs) > 1) {
            Controlled Increment([qs[0]], qs[1...]);
        }
        X(qs[0]);
    }
}
