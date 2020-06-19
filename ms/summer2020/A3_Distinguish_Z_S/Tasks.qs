// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    
    /// <summary>
    /// You are given an operation that implements a single-qubit unitary transformation: 
    /// either the Z gate or the S gate. The operation will have Adjoint and Controlled 
    /// variants defined.
    ///
    /// Your task is to perform necessary operations and measurements to figure out which 
    /// unitary it was and to return 0 if it was the Z gate or 1 if it was the S gate.
    ///
    /// You are allowed to apply the given operation and its adjoint/controlled variants 
    /// exactly twice.
    ///
    /// You have to implement an operation which takes a single-qubit operation as an 
    /// input and returns an integer
    /// </summary>

    operation Solve (unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        using (q = Qubit[1]) {
            H(q[0]);
            unitary(q[0]);
            unitary(q[0]);
            H(q[0]);
            let m = M(q[0]);
            ResetAll(q);
            if (m == Zero) {
                return 0;
            } else {
                return 1;
            }
        }
    }
}
