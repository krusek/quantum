// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[]) : Unit {
    /// XX..XX..
    /// ..XX..XX
    /// XX..XX..
    /// ..XX..XX
        body(...) {
            for (ix in 0..Length(x)-1) {
                if (ix != 1) {
                    H(x[ix]);
                }
            }
        }
        adjoint auto;
    }
}
