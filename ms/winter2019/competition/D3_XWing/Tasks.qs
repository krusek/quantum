// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[]) : Unit {
        using(p = Qubit[2]) {
            SWAP(p[0], x[0]);
            for (q in x[1..Length(x)-1]) {
                CNOT(p[0], q);
            }
            H(p[0]);
            //CNOT(x[0], p[1]);
            for (q in x[1..Length(x)-1]) {
                CNOT(p[0], q);
            }
            CNOT(x[0], p[0]);
            SWAP(p[0], x[0]);
            // ResetAll(p);
        }
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
