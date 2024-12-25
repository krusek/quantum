// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given an operation that implements a single-qubit 
    /// unitary transformation: either the H gate or the X gate. 
    /// The operation will have Adjoint and Controlled variants 
    /// defined.
    ///
    /// Your task is to perform necessary operations and
    /// measurements to figure out which unitary it was and to
    /// return 0 if it was the H gate or 1 if it was the X gate.
    ///
    /// You are allowed to apply the given operation and its
    /// adjoint/controlled variants at most twice.
    ///
    /// You have to implement an operation which takes a
    /// single-qubit operation as an input and returns an integer.
    operation Solve (unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        mutable isX = false;
        using(qs = Qubit[1]) {
            unitary(qs[0]);
            X(qs[0]);
            unitary(qs[0]);
            set isX = M(qs[0]) == One;
            ResetAll(qs);
        }
        return isX ? 1 | 0;
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
