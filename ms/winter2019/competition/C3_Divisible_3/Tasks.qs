// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            if (Length(x) >= 3) {
                using (q = Qubit[4]) {
                    X(q[2]);
                    let L = Length(x);
                    for (ix in 0..L-1) {
                        AddOne(x[ix], q);
                    }
                    CNOT(q[2], y);
                    for (ix in 0..L-1) {
                        AddTwo(x[ix], q);
                    }
                    X(q[2]);
                }
            } else {
                ApplyToEach(X, x);
                Controlled X(x, y);
                ApplyToEach(X, x);
            }
        }
        adjoint auto;
    }

    operation AddOne(a: Qubit, q: Qubit[]) : Unit {
        body(...) {
            Controlled SWAP([a], (q[2], q[3]));
            Controlled SWAP([a], (q[1], q[2]));
            Controlled SWAP([a], (q[0], q[1]));
            Controlled SWAP([a], (q[3], q[0]));
            CCNOT(a, q[0], q[3]);
        }
        adjoint auto;
    }

    operation AddTwo(a: Qubit, q:Qubit[]) : Unit {
        body(...) {
            CCNOT(a, q[0], q[3]);
            Controlled SWAP([a], (q[3], q[0]));
            Controlled SWAP([a], (q[0], q[1]));
            Controlled SWAP([a], (q[1], q[2]));
            Controlled SWAP([a], (q[2], q[3]));
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
