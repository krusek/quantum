// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;



    operation Solve(x: Qubit[]) : Unit {
        ReverseFirstHalfDiagonal(x);
        ReverseLastHalfDiagonal(x);
        let L = Length(x);
        X(x[L-1]);
        Adjoint Controlled AddOne([x[L-1]], x[0..L-2]);
        X(x[L-1]);
        Controlled AddOne([x[L-1]], x[0..L-2]);
        XMatrix(x);
    }
    
    operation XMatrix(x : Qubit[]) : Unit {
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



    operation AddOne(x: Qubit[]) : Unit {
        body (...) {
            let L = Length(x);
            for (ix in 1..L-1) {
                Controlled X(x[0..L-ix-1], x[L-ix]);
            }
            X(x[0]);
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation ReverseFirstHalfDiagonal(qs: Qubit[]) : Unit {
        // ...X....
        // ..X.....
        // .X......
        // X.......
        // ....X...
        // .....X..
        // ......X.
        // .......X
        let length = Length(qs);
        X(qs[length - 1]);
        for (ix in 0..length-2) {
            Controlled X([qs[length - 1]], qs[ix]);
        }
        X(qs[length - 1]);
    }

    operation ReverseLastHalfDiagonal(qs: Qubit[]) : Unit {
        // X.......
        // .X......
        // ..X.....
        // ...X....
        // .......X
        // ......X.
        // .....X..
        // ....X...
        let length = Length(qs);
        X(qs[length - 1]);
        ReverseFirstHalfDiagonal(qs);
        X(qs[length - 1]);
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
