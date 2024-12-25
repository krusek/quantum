// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    
    /// You are given an operation that implements a single-qubit
    /// unitary transformation: either the Rz gate or the R1 gate.
    /// The operation will have Adjoint and Controlled variants
    /// defined.
    ///
    /// Your task is to perform necessary operations and measurements
    /// to figure out which unitary it was and to return 0 if it was
    /// the Rz gate or 1 if it was the R1 gate.
    ///
    /// You are allowed to apply the given operation and its
    /// adjoint/controlled variants exactly once (you can pass to it
    /// any rotation angle that you choose).
    ///
    /// You have to implement an operation which takes a single-qubit
    /// operation unitary as an input and returns an integer. The
    /// operation unitary will accept two parameters (similarly to Rz
    /// and R1 intrinsic gates): the first parameter is the rotation
    /// angle and the second parameter is the qubit to which the
    /// rotation is applied.
    operation Solve (unitary : ((Double, Qubit) => Unit is Adj+Ctl)) : Int {
        mutable isRz = false;
        using (qs = Qubit[2]) {
            // prep (|0 + |1) |0
            H(qs[0]);
            Controlled unitary(qs[0..0], (2.0*PI(), qs[1]));
            H(qs[0]);
            set isRz = M(qs[0]) == One;
            ResetAll(qs);
        }
        return isRz ? 0 | 1;
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
