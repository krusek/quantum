// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;

    /// You are given 𝑁 qubits in the state |0...0⟩. Your
    /// task is to prepare an equal superposition of all
    /// basis states that have one or more 0 in them.
    ///
    /// For example, for 𝑁=2 the required state would be
    /// 13√(|00⟩+|01⟩+|10⟩).
    ///
    /// You are not allowed to use any gates except the
    /// Pauli gates (X, Y and Z), the Hadamard gate and
    /// the controlled versions of those (you are allowed
    /// to use multiple qubits as controls in the controlled
    /// versions of gates). However, you are allowed to
    /// use measurements.
    ///
    /// You have to implement an operation which takes an
    /// array of 𝑁 qubits as an input and has no output.
    /// The "output" of your solution is the state in which
    /// it left the input qubits.
    operation Solve (qs : Qubit[]) : Unit {
        if (Length(qs) >= 1) {
            ApplyToEach(X, qs);
            mutable found = false;
            repeat {
                ApplyToEach(X, qs);
                ApplyToEach(H, qs);
                using (y = Qubit[1]) {
                    Controlled X(qs, y[0]);
                    set found = M(y[0]) == Zero;
                    if (found == false) {
                        X(y[0]);
                    }
                }
            } until (found);
        }
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
