// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    
    operation Solve (unitary : (Qubit => Unit is Adj+Ctl)) : Int {
        mutable first = false;
        mutable second = false;
        mutable third = false;
        mutable fourth = false;
        using (qs = Qubit[4]) {
            // X(qs[1]);
            // H(qs[2]);

            // CNOT(qs[1], qs[0]);
            // CNOT(qs[2], qs[0]);
            // CCNOT(qs[1], qs[2], qs[0]);
            // CNOT(qs[0], qs[3]);

            // Controlled unitary(qs[0..0], qs[3]);
            // H(qs[2]);
            // X(qs[1]);

            // set third = M(qs[2]) == One;
            // set second = M(qs[1]) == One;
            // set first = M(qs[0]) == One;
            // set fourth = M(qs[3]) == One;

            H(qs[0]);
            CNOT(qs[0], qs[1]);
            Controlled unitary(qs[0..0], qs[1]);
            CNOT(qs[0], qs[1]);
            H(qs[0]);


            // set third = M(qs[2]) == One;
            set second = M(qs[1]) == One;
            set first = M(qs[0]) == One;
            // set fourth = M(qs[3]) == One;
            ResetAll(qs);
        }
        mutable sum = 0;
        if (first) { 
            set sum = sum + 1;
        }
        if (second) {
            set sum = sum + 2;
        }
        if (third) {
            set sum = sum + 4;
        }
        if (fourth) {
            set sum = sum + 8;
        }
        return sum;
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
