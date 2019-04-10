// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

//////////////////////////////////////////////////////////////////////
// This file contains testing harness for all tasks.
// You should not modify anything in this file.
// The tasks themselves can be found in Tasks.qs file.
//////////////////////////////////////////////////////////////////////

namespace Solution {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Extensions.Diagnostics;
    
    
    
    operation Or_Gate_Test () : Unit {
        using (qs = Qubit[5]) {
            using (q = Qubit()) {
                ApplyToEach(X, qs);
                Solve(qs, q);
                X(q);
                AssertAllZero([q]);
                ResetAll([q] + qs);

                Solve(qs, q);
                AssertAllZero([q]);
                ResetAll([q] + qs);

                for (ix in 0..4) {
                    X(qs[ix]);
                    Solve(qs, q);
                    X(q);
                    AssertAllZero([q]);
                    ResetAll([q] + qs);
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
