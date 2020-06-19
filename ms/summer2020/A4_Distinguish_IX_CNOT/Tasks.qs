// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    
    /// <summary>
    /// You are given an operation that implements a two-qubit unitary 
    /// transformation: either 𝐼⊗𝑋 (the X gate applied to the second 
    /// qubit and no effect on the first qubit) or the CNOT gate with 
    /// the first qubit as control and the second qubit as target. The 
    /// operation will have Adjoint and Controlled variants defined.
    ///
    /// Your task is to perform necessary operations and measurements 
    /// to figure out which unitary it was and to return 0 if it was 
    /// 𝐼⊗𝑋 or 1 if it was the CNOT gate.
    ///
    /// You are allowed to apply the given operation and its 
    /// adjoint/controlled variants exactly once.
    ///
    /// You have to implement an operation which takes a two-qubit 
    /// operation unitary as an input and returns an integer. The 
    /// operation unitary will accept an array of qubits as input, 
    /// but it will fail if the array is empty or has one or more 
    /// than two qubits.
    /// </summary>

    operation Solve (unitary : (Qubit[] => Unit is Adj+Ctl)) : Int {
        using (qs = Qubit[2]) {
            unitary(qs);
            let m = M(qs[1]);
            ResetAll(qs);
            if (m == Zero) {
                return 1;
            } else {
                return 0;
            }
        }
    }
}
