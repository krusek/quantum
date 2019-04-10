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
    
    
    
    operation Solve3_Test () : Unit {
        AssertDiv3([
            [1,1,1],
            [0,0,0]
        ], true);
        AssertDiv3([
             [1,0,1]
            ,[1,0,0]
            ,[0,0,1]
            ,[0,1,0]
            ,[1,1,0]
            ,[0,1,1]
        ], false);
    }
    operation Solve2_Test () : Unit {
        AssertDiv3([
            [0,0]
        ], true);
        AssertDiv3([
             [1,0]
            ,[0,1]
            ,[1,1]
        ], false);
    }
    operation Solve1_Test () : Unit {
        AssertDiv3([
            [0]
        ], true);
        AssertDiv3([
             [1]
        ], false);
    }
    operation Solve4_Test () : Unit {
        AssertDiv3([
             [1,1,1,0]
            ,[0,0,0,0]
            ,[0,1,1,1]
            ,[1,0,1,1]
            ,[1,1,0,1]
            ,[1,1,1,0]
        ], true);
        AssertDiv3([
             [1,0,1,0]
            ,[1,0,0,1]
            ,[0,0,1,1]
            ,[0,1,0,1]
            ,[1,1,0,0]
            ,[0,1,1,0]
            ,[0,0,1,0]
            ,[0,0,0,1]
            ,[1,1,1,1]
            ,[0,1,0,0]
            ,[1,0,0,0]
        ], false);
    }

    operation AssertDiv3(bits: Int[][], div: Bool) :Unit {
        for (bit in bits) {
            Message($"Trying bits: {bit} with div: {div}");
            using (x = Qubit[Length(bit)]) {
                using (y = Qubit[1]) {
                    MatchBits(x, bit);
                    Solve(x, y[0]);
                    MatchBits(x, bit);
                    if (div) {
                        X(y[0]);
                    }
                    AssertAllZero(x + y);
                }
            }
        }
    }


    operation MatchBits(x: Qubit[], bits:Int[]): Unit {
        for (ix in 0..Length(bits) - 1) {
            if (bits[ix] != 0) {
                X(x[ix]);
            }
        }
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
