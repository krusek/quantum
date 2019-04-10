// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], y: Qubit) : Unit {
        body(...) {
            Controlled X(x, y);
        }
        adjoint auto;
    }
}
