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
        using (qs = Qubit[2]) {
            using (y = Qubit[1]) {
                X(qs[0]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                X(qs[1]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(y);
            }
            ResetAll(qs);
        }

        using (qs = Qubit[4]) {
            using (y = Qubit[1]) {
                
                X(qs[0]);
                Solve(qs, y[0]);
                AssertProbInt(0, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[1]);
                Solve(qs, y[0]);
                AssertProbInt(0, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[2]);
                Solve(qs, y[0]);
                AssertProbInt(0, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[3]);
                Solve(qs, y[0]);
                AssertProbInt(0, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[0]);
                X(qs[1]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[0]);
                X(qs[2]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
                
                X(qs[0]);
                X(qs[3]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);

                ResetAll(qs+y);
                X(qs[1]);
                X(qs[2]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(y);

                ResetAll(qs+y);
                X(qs[1]);
                X(qs[3]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(y);

                ResetAll(qs+y);
                X(qs[2]);
                X(qs[3]);
                Solve(qs, y[0]);
                AssertProbInt(1, 1.0, LittleEndian(y), 0.1);
                ResetAll(qs+y);
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
