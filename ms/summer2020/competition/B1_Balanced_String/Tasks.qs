// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// Implement a quantum oracle on 𝑁 qubits which checks whether 
    /// the input bit string is balanced, i.e., whether it has
    /// exactly 𝑁2 zeros and 𝑁2 ones in it.
    ///
    /// Your operation should take the following inputs:
    ///
    /// - an array of 𝑁≤10 qubits "inputs" in an arbitrary state. 
    ///     𝑁 will be an even number.
    /// - a qubit "output" in an arbitrary state.
    /// 
    /// Your operation should perform a unitary transformation
    /// on those qubits that can be described by its effect on
    /// the basis states: if "inputs" is in the basis state |𝑥⟩
    /// and "output" is in the basis state |𝑦⟩, the result of
    /// applying the operation should be |𝑥⟩|𝑦⊕𝑓(𝑥)⟩, where 𝑓(𝑥)=1
    /// if the bit string 𝑥 has the same number of zeros and
    /// ones in it, and 0 otherwise.
    ///
    /// For example, if the qubits passed to your operation are
    /// in the state 12√(|01⟩+|00⟩)𝑥⊗|0⟩𝑦, the state of the system
    /// after applying the operation should be 12√(|01⟩𝑥⊗|1⟩𝑦+|00⟩𝑥|0⟩𝑦).
    operation Solve (inputs : Qubit[], output : Qubit) : Unit is Adj+Ctl {
        if (Length(inputs) == 0) {
            X(output);
        } else {
            using (qs = Qubit[Length(inputs)]) {
                Compute(inputs, qs);
                Controlled X(qs, output);
                Adjoint Compute(inputs, qs);
            }
        }
    }

    operation Compute(inputs: Qubit[], qs: Qubit[]) : Unit is Adj+Ctl {
            ApplyToEach(X, qs);
            for (ix in 0..Length(inputs)-1) {
                Controlled Increment([inputs[ix]], qs);
                X(inputs[ix]);
                Controlled (Adjoint Increment)([inputs[ix]], qs);
                X(inputs[ix]);
            }
    }

    operation Increment(qs: Qubit[]) : Unit is Adj+Ctl {
        if (Length(qs) > 1) {
            (Controlled Increment)([qs[0]], qs[1...]);
        }
        X(qs[0]);
    }


    operation ApplyToEach(op: ((Qubit) => Unit is Adj+Ctl), x: Qubit[]) : Unit is Adj+Ctl {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }
}
