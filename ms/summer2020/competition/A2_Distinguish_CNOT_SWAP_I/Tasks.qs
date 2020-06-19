// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given an operation that implements a two-qubit 
    /// unitary transformation: either the identity (I ⊗ I gate), 
    /// the CNOT gate (either with the first qubit as control and 
    /// the second qubit as target or vice versa) or the SWAP gate. 
    /// The operation will have Adjoint and Controlled variants 
    /// defined.
    ///
    /// Your task is to perform necessary operations and 
    /// measurements to figure out which unitary it was and to 
    /// return:
    ///
    /// - 0 if it was the I ⊗ I gate,
    /// - 1 if it was the CNOT12 gate,
    /// - 2 if it was the CNOT21 gate,
    /// - 3 if it was the SWAP gate.
    ///
    /// You are allowed to apply the given operation and its 
    /// adjoint/controlled variants at most twice.
    ///
    /// You have to implement an operation which takes a two-qubit 
    /// operation unitary as an input and returns an integer. The 
    /// operation unitary will accept an array of qubits as input, 
    /// but it will fail if the array is empty or has one or more 
    /// than two qubits.
    operation Solve (unitary : (Qubit[] => Unit is Adj+Ctl)) : Int {
        // your code here
        mutable isCNOT12 = false;
        mutable isCNOT21 = false;
        using (qs = Qubit[2]) {
            X(qs[0]);
            X(qs[1]);
            unitary(qs);
            set isCNOT12 = M(qs[1]) == Zero;
            set isCNOT21 = M(qs[0]) == Zero;
            ResetAll(qs);
        }
        if (isCNOT12) {
            return 1;
        }
        if (isCNOT21) {
            return 2;
        }
        mutable isSwap = false;
        using (qs = Qubit[2]) {
            X(qs[0]);
            unitary(qs);
            set isSwap = M(qs[1]) == One;
            ResetAll(qs);
        }
        if (isSwap) {
            return 3;
        }
        return 0;
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
