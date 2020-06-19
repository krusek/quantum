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
            for (iy in 1 .. 10) {
                IncrementByInteger(1, LittleEndian(qs));
            }
            for (iy in 1 .. 9) {
                Solve(LittleEndian(qs));
                AssertProbInt(10 - iy, 1.0, LittleEndian(qs), 0.1);

            }
            ResetAll(qs);
        }

        using (qs = Qubit[5]) {
            Solve(LittleEndian(qs));
            AssertProbInt(31, 1.0, LittleEndian(qs), 0.1);
            ResetAll(qs);
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
