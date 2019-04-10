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
    
    
    
    operation Solve_Test () : Unit {
        mutable count = [0,0,0,0];
        for (ix in 0..100) {
            using (q = Qubit[4]) {
                Solve(q,[[true, false, false, false], [false, true, false, false], [false, false, true, false], [false, false, false, true]]);
                ResetAll(q);
            }
        }
    }

    operation Measurements(x: Qubit[]) : Int {
        mutable m = -1;
        for (ix in 0..3) {
            if (M(x[ix]) == One) {
                set m = ix;
            }
        }
        return m;
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
