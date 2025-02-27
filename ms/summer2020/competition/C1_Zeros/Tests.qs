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
        for (iy in 0..10) {
        Solve(new Qubit[0]);
        using (qs = Qubit[1]) {
            Solve(qs);
            AssertProbInt(0, 1.0, LittleEndian(qs), 0.1); // 000
        }
        using (qs = Qubit[2]) {
            Solve(qs);
            AssertProbInt(0, 1.0/3.0, LittleEndian(qs), 0.1); // 00
            AssertProbInt(1, 1.0/3.0, LittleEndian(qs), 0.1); // 01
            AssertProbInt(2, 1.0/3.0, LittleEndian(qs), 0.1); // 10
            ResetAll(qs);
        }
        using (qs = Qubit[3]) {
            Solve(qs);
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 000
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 001
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 010
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 011
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 100
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 101
            AssertProbInt(0, 1.0/6.0, LittleEndian(qs), 0.1); // 110
            ResetAll(qs);
        }
        using (qs = Qubit[4]) {
            Solve(qs);
            for (ix in 0..15) {
                AssertProbInt(ix, 1.0/15.0, LittleEndian(qs), 0.1); // 000
            }
            ResetAll(qs);
        }

        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
