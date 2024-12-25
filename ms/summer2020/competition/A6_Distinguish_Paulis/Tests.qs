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
            // EqualityFactI(Solve(I), 0, "I should return 0");
            // EqualityFactI(Solve(X), 1, "X should return 1");
            // EqualityFactI(Solve(Y), 2, "Y should return 2");
            // EqualityFactI(Solve(Z), 3, "Z should return 3");

            Message($"I returned: {Solve(I)}");
            Message($"X returned: {Solve(X)}");
            Message($"Y returned: {Solve(Y)}");
            Message($"Z returned: {Solve(Z)}");
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
