// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given an angle 𝜃 (in radians, 0.01𝜋≤𝜃≤0.99𝜋) and an
    /// operation that implements a single-qubit unitary
    /// transformation: either the 𝑅𝑧(𝜃) gate or the 𝑅𝑦(𝜃) gate. The
    /// operation will have Adjoint and Controlled variants defined.
    ///
    /// Your task is to perform necessary operations and measurements
    /// to figure out which unitary it was and to return 0 if it was
    /// the 𝑅𝑧(𝜃) gate or 1 if it was the 𝑅𝑦(𝜃) gate.
    ///
    /// You are allowed to apply the given operation and its
    /// adjoint/controlled variants as many times as you need
    /// (within the time limit).
    operation Solve (theta : Double, unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        mutable isRy = false;
        for (ix in 1..10) {
            if (isRy == false) {
                using (qs = Qubit[1]) {
                    mutable currentTheta = 0.0;
                    mutable nextTheta = theta;
                    repeat {
                        set currentTheta = nextTheta;
                        set nextTheta = nextTheta + theta;
                        unitary(qs[0]);
                    } until (AbsD(nextTheta - PI()) > AbsD(currentTheta - PI()));
                    set isRy = M(qs[0]) == One;
                    ResetAll(qs);
                }
            }
        }
        return isRy ? 1 | 0; 
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
