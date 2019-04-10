// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            ApplyToEach(X, x);
            And_Gate(x, y);
            ApplyToEach(X, x);
            X(y);
        }
        adjoint auto;
    }

    operation And_Gate (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            Controlled X(x, y);
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
