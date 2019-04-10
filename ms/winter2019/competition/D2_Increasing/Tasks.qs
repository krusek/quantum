// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[]) : Unit {
        let qs = x;
        for (ix in 0..Length(qs)-2) {
            let controls = After(qs, ix);
            ApplyToEach(X, controls);
            Controlled DiagonalBlock(controls, qs[0..ix]);
            ApplyToEach(X, controls);

        }
        DiagonalBlock(qs);
    }


    operation After(qs: Qubit[], index: Int) : Qubit[] {
        return qs[index+1..Length(qs)-1];
    }

    operation ApplyToEach(op: ((Qubit) => Unit : Adjoint), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }

    operation DiagonalBlock(qs: Qubit[]) : Unit {
        // X.......
        // .X......
        // ..X.....
        // ...X....
        // ....XXXX
        // ....XXXX
        // ....XXXX
        // ....XXXX
        // control specifies which rows to change.
        // That is 2^N x 2^N rows of I
        // Then the operator you're using
        // Then 2^N x 2^N rows of I
        // etc...
        body(...) {
            let length = Length(qs);
            let control = length - 1;
            Controlled AllHButN([qs[control]], (qs, length-1));
        }
        controlled(controls, ...) {
            let length = Length(qs);
            let control = length - 1;
            let cntrls = controls + [qs[control]];
            Controlled AllHButN(cntrls, (qs, length-1));
        }

    }


    operation AllHButN (x : Qubit[], N: Int) : Unit {
        // X^{2^N,2^N} .^{2^N,2^N} repeated
        // .^{2^N,2^N} X^{2^N,2^N} repeated
        // repeated
        body(...) {
            for (ix in 0..Length(x)-1) {
                if (ix != N) {
                    H(x[ix]);
                }
            }
        }
        controlled(controls, ...) {
            for (ix in 0..Length(x)-1) {
                if (ix != N && not contains(controls, x[ix])) {
                    Controlled H(controls, x[ix]);
                }
            }
        }
    }


    function contains(qs: Qubit[], member: Qubit) : Bool {
        for (q in qs) {
            if (q == member) { return true; }
        } 
        return false;
    }
}
