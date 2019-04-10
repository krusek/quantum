// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            let s2 = Length(x) / 2;
            let mx = Length(x) - 1;
            using (a = Qubit[s2]) {
                for (ix in 0..s2-1) {
                    CCNOT(x[ix], x[mx - ix], a[ix]);
                    X(x[ix]);
                    X(x[mx - ix]);
                    CCNOT(x[ix], x[mx - ix], a[ix]);
                    X(x[ix]);
                    X(x[mx - ix]);
                }
                Controlled X(a, y);
                for (ix in 0..s2-1) {
                    CCNOT(x[ix], x[mx - ix], a[ix]);
                    X(x[ix]);
                    X(x[mx - ix]);
                    CCNOT(x[ix], x[mx - ix], a[ix]);
                    X(x[ix]);
                    X(x[mx - ix]);
                }
            }
        }
        adjoint auto;
    }


    operation ApplyToEach(op: ((Qubit) => Unit : Adjoint), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }
}
