// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given 𝑁 qubits in the state |0...0⟩,
    /// and an integer 𝑝𝑎𝑟𝑖𝑡𝑦∈{0,1}. Your task is to
    /// prepare an equal superposition of all basis
    /// states that have the given parity of the number
    /// of 1s in their binary notation, i.e., the basis
    /// states that have an even number of 1s if 𝑝𝑎𝑟𝑖𝑡𝑦=0
    /// or the basis states that have an odd number of
    /// 1s if 𝑝𝑎𝑟𝑖𝑡𝑦=1.
    ///
    /// For example, for 𝑁=2 the required state would be
    ///
    /// - 12√(|00⟩+|11⟩) if 𝑝𝑎𝑟𝑖𝑡𝑦=0.
    /// - 12√(|01⟩+|10⟩) if 𝑝𝑎𝑟𝑖𝑡𝑦=1.
    ///
    /// You are not allowed to use any gates except the
    /// Pauli gates (X, Y and Z), the Hadamard gate and
    /// the controlled versions of those (you are allowed
    /// to use multiple qubits as controls in the
    /// controlled versions of gates). However, you are
    /// allowed to use measurements.
    ///
    /// You have to implement an operation which takes
    /// an array of 𝑁 qubits and an integer as an input
    /// and has no output. The "output" of your solution
    /// is the state in which it left the input qubits.
    operation Solve (qs : Qubit[], parity : Int) : Unit {
        if (Length(qs) > 1) {
            let tail = qs[1...];
            ApplyToEach(H, tail);
            CheckParity(tail, qs[0]);
        }
        
        if (Length(qs) > 0 and parity == 1) {
            X(qs[0]);
        }
    }

    operation CheckParity(qs: Qubit[], parity: Qubit) : Unit is Adj+Ctl {
        for (ix in 0..Length(qs)-1) {
            CNOT(qs[ix], parity);
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
