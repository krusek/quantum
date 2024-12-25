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
            EqualityFactI(Solve(H), 0, "H should return 0");
            EqualityFactI(Solve(X), 1, "X should return 1");
        }
    }

    operation CNOT12(qs: Qubit[]) : Unit is Adj+Ctl {
        CNOT(qs[0], qs[1]);
    }

    operation CNOT21(qs: Qubit[]) : Unit is Adj+Ctl {
        CNOT(qs[1], qs[0]);
    }

    operation swap(qs: Qubit[]) : Unit is Adj+Ctl {
        SWAP(qs[1], qs[0]);
    }

    operation identity(qs: Qubit[]) : Unit is Adj+Ctl {
    }

    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
