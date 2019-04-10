// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve(qs: Qubit[]) : Unit {
        let L = Length(qs);
        let controls = qs[1..L-1];
        for (n in 0..(1<<<(L-1))) {
            XSome(controls, n);
            Controlled H(controls, qs[0]);
            XSome(controls, n);
        }
        Controlled H(qs[1..L-1], qs[0]);
    }

    operation XSome(qs: Qubit[], n: Int) : Unit {
        body(...) {
            for (ix in 0..Length(qs)-1) {
                if (((1 <<< ix) &&& n) != 0) {
                    X(qs[ix]);
                }
            }
        }
        adjoint auto;
    }

    
}
