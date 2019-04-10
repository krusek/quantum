// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[], bits: Bool[][]) : Unit {
        using (q = Qubit[2]) {
            H(q[0]);
            H(q[1]);
            
            ApplyToEach(X, q);
            Controlled SetBits(q, (x, bits[0])); //00
            ApplyToEach(X, q);

            ApplyToEach(X, q);
            X(q[0]); // 01
            Controlled SetBits(q, (x, bits[1])); // 01
            X(q[0]);
            ApplyToEach(X, q);

            ApplyToEach(X, q);
            X(q[1]); 
            Controlled SetBits(q, (x, bits[2])); // 10
            X(q[1]); 
            ApplyToEach(X, q);

            ApplyToEach(X, q);
            X(q[1]); 
            X(q[0]); 
            Controlled SetBits(q, (x, bits[3])); // 11
            X(q[0]); 
            X(q[1]); 
            ApplyToEach(X, q);

            SetBits(x, bits[1]); // 01
            ApplyToEach(X, x);
            Controlled X(x, q[0]);
            ApplyToEach(X, x);
            SetBits(x, bits[1]); // 01

            SetBits(x, bits[3]); // 11
            ApplyToEach(X, x);
            Controlled X(x, q[0]);
            Controlled X(x, q[1]);
            ApplyToEach(X, x);
            SetBits(x, bits[3]); // 11

            SetBits(x, bits[2]); // 10
            ApplyToEach(X, x);
            Controlled X(x, q[1]);
            ApplyToEach(X, x);
            SetBits(x, bits[2]); // 10
        }
    }

    operation SetBits(x : Qubit[], bits: Bool[]) : Unit {
        body(...) {
            for (ix in 0..Length(bits)-1) {
                if (bits[ix]) {
                    X(x[ix]);
                }
            }
        }
        controlled auto;
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
