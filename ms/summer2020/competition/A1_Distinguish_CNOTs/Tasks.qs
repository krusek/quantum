// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given an operation that implements a two-qubit unitary 
    /// transformation: either the CNOT gate with the first qubit as 
    /// control and the second qubit as target (CNOT12), or the CNOT 
    /// gate with the second qubit as control and the first qubit as 
    /// target (CNOT21). The operation will have Adjoint and 
    /// Controlled variants defined.
    ///
    /// Your task is to perform necessary operations and measurements 
    /// to figure out which unitary it was and to return 0 if it was 
    /// the CNOT12 gate or 1 if it was the CNOT21 gate.
    ///
    /// You are allowed to apply the given operation and its 
    /// adjoint/controlled variants exactly once.
    ///
    /// You have to implement an operation which takes a two-qubit 
    /// operation unitary as an input and returns an integer. The 
    /// peration unitary will accept an array of qubits as input, 
    /// but it will fail if the array is empty or has one or more 
    /// than two qubits.
    operation Solve (unitary : (Qubit[] => Unit is Adj+Ctl)) : Int {
        using (qs = Qubit[2]) {
            X(qs[0]);
            unitary(qs);
            X(qs[0]);
            let m = M(qs[1]);
            ResetAll(qs);
            if (m == One) {return 0;}
        }
        return 1;
    }


    operation ApplyToEach(op: ((Qubit) => Unit is Adj), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }
}
