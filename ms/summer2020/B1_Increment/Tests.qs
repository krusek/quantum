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
        mutable ix = 0;
        using (qs = Qubit[4]) {
            set ix = ix + 1;
            for (iy in 1 .. 16) {
                // Reset the counter of measurements done outside of the solution call
                ResetOracleCallsCount();
                Solve(LittleEndian(qs));
                // Make sure the solution didn't use any measurements
                Fact(GetOracleCallsCount(M) == 0, "You are not allowed to use measurements in this task");
                Fact(GetOracleCallsCount(Measure) == 0, "You are not allowed to use measurements in this task");
                // Fact(GetMultiQubitOpCount() == 0, "You are not allowed to use rotations in this task");
                Fact(GetOracleCallsCount(Rx) == 0, "You are not allowed to use rotations in this task");
                Fact(GetOracleCallsCount(Ry) == 0, "You are not allowed to use rotations in this task");
                Fact(GetOracleCallsCount(Rz) == 0, "You are not allowed to use rotations in this task");
                AssertProbInt(iy % 16, 1.0, LittleEndian(qs), 0.1);
            }
            ResetAll(qs);
        }

    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
