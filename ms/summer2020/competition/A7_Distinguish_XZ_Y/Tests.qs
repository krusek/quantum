// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//////////////////////////////////////////////////////////////////////
// This file contains testing harness for all tasks.
// You should not modify anything in this file.
// The tasks themselves can be found in Tasks.qs file.
//////////////////////////////////////////////////////////////////////

namespace Solution {
    
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Diagnostics;
    
    
    
    operation Solve_Test () : Unit {
        for (ix in 0..10) {
            Message($"ix: {ix}");
            EqualityFactI(Solve(Y), 0, "Y should return 0");
            EqualityFactI(Solve(nXZ), 1, "-XZ should return 1");
            EqualityFactI(Solve(nY), 2, "-Y should return 2");
            EqualityFactI(Solve(XZ), 3, "XZ should return 3");
            // DifferentiateNegative()
        }
    }

    operation Diff_Test() : Unit {
        for (ix in 0..10) {
            Message($"ix: {ix}");
            using (qs = Qubit[1]) {
                X(qs[0]);
                EqualityFactI(DifferentiateNegative(Z, qs[0]), 1, "should be 1");
                EqualityFactI(DifferentiateNegative(I, qs[0]), 0, "should be 0");
                X(qs[0]);
            }
        }

    }


    operation XZ(q: Qubit) : Unit is Adj+Ctl {
        Z(q);
        X(q);
    }

    operation nXZ(q: Qubit) : Unit is Adj+Ctl {
        using (qq = Qubit[1]) {
            X(qq[0]);
            Controlled XZ(qq[0..0], q);
            Z(qq[0]);
            X(qq[0]);
        }
    }

    operation nY(q: Qubit) : Unit is Adj+Ctl {
        using (qq = Qubit[1]) {
            X(qq[0]);
            Controlled Y(qq[0..0], q);
            Z(qq[0]);
            X(qq[0]);
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
