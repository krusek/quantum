// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[]) : Unit {
        // ...X....
        // ..X.....
        // .X......
        // X.......
        // ....XXXX
        // ....XXXX
        // ....XXXX
        // ....XXXX
        body(...) {
            let qs = x;
            let length = Length(x);
            X(x[length - 1]);
            for (ix in 0..length-2) {
                Controlled X([x[length - 1]], x[ix]);
            }
            X(x[length - 1]);

            for (ix in 0..length-2) {
                Controlled H([qs[length - 1]], qs[ix]);
            }
        }
        adjoint auto;
    }
}
