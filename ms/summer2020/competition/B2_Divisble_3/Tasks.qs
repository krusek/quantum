// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// Implement a quantum oracle on 𝑁 qubits which checks
    /// whether the input bit string is a little-endian notation
    /// of a number that is divisible by 3.
    ///
    /// Your operation should take the following inputs:
    ///
    /// - an array of 𝑁≤8 qubits "inputs" in an arbitrary state.
    /// - a qubit "output" in an arbitrary state.
    ///
    /// Your operation should perform a unitary transformation
    /// on those qubits that can be described by its effect on
    /// the basis states: if "inputs" is in the basis state |𝑥⟩
    /// and "output" is in the basis state |𝑦⟩, the result of
    /// applying the operation should be |𝑥⟩|𝑦⊕𝑓(𝑥)⟩, where
    /// 𝑓(𝑥)=1 if the integer represented by the bit string 𝑥
    /// is divisible by 3, and 0 otherwise.
    ///
    /// For example, if the qubits passed to your operation
    /// are in the state 12√(|110⟩+|001⟩)𝑥⊗|0⟩𝑦=12√(|3⟩+|4⟩)𝑥⊗|0⟩𝑦,
    /// the state of the system after applying the operation
    /// should be 12√(|3⟩𝑥⊗|1⟩𝑦+|4⟩𝑥|0⟩𝑦)=12√(|110⟩𝑥⊗|1⟩𝑦+|001⟩𝑥|0⟩𝑦).
    operation Solve (inputs : Qubit[], output : Qubit) : Unit is Adj+Ctl {
        using (qs = Qubit[3]) {
            CheckDivisible(inputs, qs);
            Controlled X(qs, output);
            Adjoint CheckDivisible(inputs, qs);
        }
    }

    operation CheckDivisible(x: Qubit[], qs: Qubit[]) : Unit is Adj+Ctl {
        X(qs[0]);
        for (ix in 0..Length(x)-1) {
            if (ix % 2 == 0) {
                Controlled Increment([x[ix]], qs);
            } else {
                Controlled (Adjoint Increment)([x[ix]], qs);
            }
        }
        X(qs[1]);
        X(qs[2]);
    }

    operation Increment(inputs: Qubit[]) : Unit is Adj+Ctl {
        // CNOT(inputs[1], inputs[0]);
        // X(inputs[0]);
        CNOT(inputs[0], inputs[1]);
        CNOT(inputs[1], inputs[2]);
        CNOT(inputs[2], inputs[0]);
        X(inputs[2]);
        CCNOT(inputs[0], inputs[1], inputs[2]);
        CNOT(inputs[2], inputs[0]);
        CNOT(inputs[2], inputs[1]);
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
