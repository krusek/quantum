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
            Message($"round: {ix}");
            EqualityFactI(Solve(R1), 1, "R1 should return 1");
            EqualityFactI(Solve(Rz), 0, "Rz should return 0");
        }
    }

    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
