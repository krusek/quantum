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
    open Microsoft.Quantum.Arithmetic;
    
    
    
    operation Solve_Test () : Unit {
        using (qs = Qubit[5]) {
            for (ix in 0..31) {
                Message($"checking {ix}");
                IncrementByInteger(ix, LittleEndian(qs));
                using (y = Qubit[1]) {
                    Solve(qs, y[0]);
                    if (ix % 3 == 0) {
                        AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                    } else {
                        AssertProbInt(0, 1.0, LittleEndian(y), 0.1);
                    }
                    ResetAll(qs + y);
                }
            }
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
