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
        
        let w = 2.0*PI()/3.0;
        for (ix in 0..2) {
            mutable vs = [0,0,0,0,0,0,0,0];
            for (ii in 0..100) {
            using (q = Qubit()) {
                H(q);
                for (_ in 0..ix-1) {
                    R1(w, q);
                }
                let iy = Solve(q);
                set vs[iy] = vs[iy] + 1;
                Reset(q);
            }}
            Message($"for ix: {ix}, vs {vs}");
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
