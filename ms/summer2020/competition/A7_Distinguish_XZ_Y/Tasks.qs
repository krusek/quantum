// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    /// You are given an operation that implements a single-qubit
    /// unitary transformation: either the Y gate (possibly with
    /// an extra global phase of −1) or the sequence of Pauli Z
    /// and Pauli X gates (the Z gate applied first and the X gate
    /// applied second; possibly with an extra global phase of −1).
    /// The operation will have Adjoint and Controlled variants
    /// defined.
    ///
    /// Your task is to perform necessary operations and measurements
    /// to figure out which unitary it was and to return
    ///
    /// - 0 if it was the Y gate,
    /// - 1 if it was the −XZ gate,
    /// - 2 if it was the −Y gate,
    /// - 3 if it was the XZ gate.
    ///
    /// You are allowed to apply the given operation and its
    /// adjoint/controlled variants at most three times.
    ///
    /// You have to implement an operation which takes a single-qubit
    /// operation as an input and returns an integer.
    operation Solve (unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        mutable sum = 0;
        using(q = Qubit[1]) {
            set sum = DifferentiateNegative(DoubleUnitary(unitary, _), q[0]);
            ResetAll(q);
        } 
        if (sum == 0) {
            // Differentiate Y and -Y
            // eigenvalue is |0> + i|1>
            using (q = Qubit[1]) {
                H(q[0]);
                R1(PI()/2.0, q[0]);
                set sum = sum + 2*DifferentiateNegative(unitary, q[0]);
                ResetAll(q);
            }
        } else {
            // Differentiate XZ and -XZ
            using (q = Qubit[1]) {
                set sum = sum + 2*(1-DifferentiateNegative(XZUnitary(unitary, _), q[0]));
                ResetAll(q);
            }

        }
        return sum;
    }

    operation XZUnitary(xz: (Qubit => Unit is Adj+Ctl), q: Qubit): Unit is Adj+Ctl {
        X(q);
        Z(q);
        xz(q);
    }

    operation DoubleUnitary(unitary: (Qubit => Unit is Adj+Ctl), q: Qubit) : Unit is Adj+Ctl {
        unitary(q);
        unitary(q);
    }

    operation DifferentiateNegative(unitary : (Qubit => Unit is Adj+Ctl), eigen: Qubit) : Int {
        mutable isNeg = false;
        using (qs = Qubit[1]) {
            H(qs[0]);
            Controlled unitary(qs[0..0], eigen);
            H(qs[0]);
            set isNeg = M(qs[0]) == One;
            ResetAll(qs);
        }
        return isNeg ? 1 | 0;
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
