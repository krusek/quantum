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
        Solve(new Qubit[0], 0);
        using (qs = Qubit[1]) {
            Solve(qs, 0);
            AssertProbInt(0, 1.0, LittleEndian(qs), 0.1);
            ResetAll(qs);

            Solve(qs, 1);
            AssertProbInt(1, 1.0, LittleEndian(qs), 0.1);
            ResetAll(qs);
        }

        using (qs = Qubit[2]) {
            Solve(qs, 0);
            AssertProbInt(0, 0.5, LittleEndian(qs), 0.1);
            AssertProbInt(3, 0.5, LittleEndian(qs), 0.1);
            ResetAll(qs);

            Solve(qs, 1);
            AssertProbInt(1, 0.5, LittleEndian(qs), 0.1);
            AssertProbInt(2, 0.5, LittleEndian(qs), 0.1);
            ResetAll(qs);
        }

        using (qs = Qubit[3]) {
            Solve(qs, 0);
            AssertProbInt(0, 0.25, LittleEndian(qs), 0.1); // 000
            AssertProbInt(3, 0.25, LittleEndian(qs), 0.1); // 011
            AssertProbInt(5, 0.25, LittleEndian(qs), 0.1); // 101
            AssertProbInt(6, 0.25, LittleEndian(qs), 0.1); // 110
            ResetAll(qs);

            Solve(qs, 1);
            AssertProbInt(1, 0.25, LittleEndian(qs), 0.1); // 001
            AssertProbInt(2, 0.25, LittleEndian(qs), 0.1); // 010
            AssertProbInt(4, 0.25, LittleEndian(qs), 0.1); // 100
            AssertProbInt(7, 0.25, LittleEndian(qs), 0.1); // 111
            ResetAll(qs);
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
