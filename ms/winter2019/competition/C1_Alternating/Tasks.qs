// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            FlipSome(x, 0);
            Controlled X(x, y);
            FlipSome(x, 0);
            FlipSome(x, 1);
            Controlled X(x, y);
            FlipSome(x, 1);
        }
        adjoint auto;
    }

    operation FlipSome(x: Qubit[], mod: Int) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                if (ix % 2 == mod) {
                    X(x[ix]);
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
