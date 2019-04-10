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
        AssertPalindrome(4, [1,0]);
        AssertPalindrome(4, [0,0]);
        AssertPalindrome(4, [1,1]);
        AssertPalindrome(4, [0,1]);
        AssertPalindrome(5, [1,0]);
        AssertPalindrome(5, [0,0]);
        AssertPalindrome(5, [1,1]);
        AssertPalindrome(5, [0,1]);
        AssertPalindrome(6, [1,0,0]);
        AssertPalindrome(6, [0,0,1]);
        AssertPalindrome(6, [1,1,0]);
        AssertPalindrome(6, [0,1,1]);
        AssertPalindrome(7, [1,0,1]);
        AssertPalindrome(7, [0,0,0]);
        AssertPalindrome(7, [1,1,0]);
        AssertPalindrome(7, [0,1,1]);
    }

    operation AssertPalindrome(N: Int, binary: Int[]) : Unit {
        using (qs = Qubit[N]) {
            if (N % 2 == 1) {
                X(qs[N / 2]);
            }
            using (a = Qubit()) {
                QubitFromBinary(qs, binary);
                Solve(qs, a);
                X(a);
                AssertAllZero([a]);
                ResetAll(qs);
                QubitFromBinary(qs, binary);
                Solve(qs, a);
                X(a);
                AssertAllZero([a]);
                ResetAll(qs);
            }
            ResetAll(qs);
        }
    }

    operation QubitFromBinary(qs : Qubit[], binary: Int[]) : Unit {
        let mx = Length(qs) - 1;
        for (ix in 0..Length(binary) - 1) {
            X(qs[ix]);
            X(qs[mx - ix]);
        }
        //X(qs[0]);
    }

    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
