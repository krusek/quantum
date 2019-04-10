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
    
    
    
    operation Solve4_Test () : Unit {
        Assert([
            [1, 0, 1, 0],
            [0, 0, 0, 0],
            [1, 0, 0, 1],
            [1, 1, 0, 1],
            [0, 0, 0, 0]
            ,[0, 1, 0, 1]
        ], true);
        Assert([
             [1, 0, 0, 0]
            ,[0, 0, 0, 1]
            ,[1, 1, 0, 0]
            ,[1, 1, 1, 0]
            ,[0, 0, 0, 1]
        ], false);
    }
     
    operation Solve2_Test () : Unit {
        Assert([
            [1, 1],[0,0]
        ], true);
        Assert([
            [1, 0],[0,1]
        ], false);
    }
    operation Solve3_Test () : Unit {
        Assert([
            [1, 1, 1],[0,1,0]
        ], true);
        Assert([
            [1, 1, 0],[0,1,1]
        ], false);
    }

    operation Solve5_Test () : Unit {
        Assert([
             [0, 0, 0, 0, 0]
            ,[1, 0, 0, 1, 0]
            ,[1, 0, 0, 0, 1]
        ], true);
        Assert([
             [1, 0, 0, 0, 0]
            ,[0, 0, 0, 0, 1]
        ], false);
    }

    operation Solve6_Test () : Unit {
        Assert([
             [0, 0, 0, 0, 0, 0]
            ,[1, 0, 0, 1, 0, 0]
            ,[1, 0, 0, 0, 1, 0]
            ,[1, 0, 0, 1, 0, 0]
            ,[1, 0, 0, 0, 1, 0]
            ,[0, 0, 0, 0, 1, 0]
        ], true);
        Assert([
             [1, 0, 0, 0, 0, 0]
            ,[0, 0, 0, 0, 0, 1]
            ,[0, 0, 1, 1, 0, 1]
        ], false);
    }

    operation Solve7_Test () : Unit {
        Assert([

            [0, 0, 0, 0, 0, 0, 1],
            [0, 0, 0, 0, 0, 1, 1],
            [0, 0, 0, 0, 1, 0, 1],
            [0, 0, 0, 0, 1, 1, 1],
            [0, 0, 0, 1, 0, 0, 1],
            [0, 0, 0, 1, 0, 1, 1],
            [0, 0, 0, 1, 1, 0, 1],
            [0, 0, 0, 1, 1, 1, 1],
            [0, 0, 1, 0, 0, 1, 1],
            [0, 0, 1, 0, 1, 0, 1],
            [0, 0, 1, 0, 1, 1, 1],
            [0, 0, 1, 1, 0, 1, 1],
            [0, 0, 1, 1, 1, 1, 1],
            [0, 1, 0, 0, 0, 1, 1],
            [0, 1, 0, 0, 1, 1, 1],
            [0, 1, 0, 1, 0, 1, 1],
            [0, 1, 0, 1, 1, 1, 1],
            [0, 1, 1, 0, 1, 1, 1],
            [0, 1, 1, 1, 1, 1, 1],
            [1, 0, 0, 0, 0, 0, 0],
            [1, 0, 0, 1, 0, 0, 0],
            [1, 0, 1, 0, 0, 0, 0],
            [1, 0, 1, 0, 1, 0, 0],
            [1, 0, 1, 1, 0, 0, 0],
            [1, 0, 1, 1, 1, 0, 0],
            [1, 1, 0, 0, 0, 0, 0],
            [1, 1, 0, 0, 0, 1, 0],
            [1, 1, 0, 0, 1, 0, 0],
            [1, 1, 0, 1, 0, 0, 0],
            [1, 1, 0, 1, 0, 1, 0],
            [1, 1, 0, 1, 1, 0, 0],
            [1, 1, 1, 0, 0, 0, 0],
            [1, 1, 1, 0, 0, 1, 0],
            [1, 1, 1, 0, 1, 0, 0],
            [1, 1, 1, 0, 1, 1, 0],
            [1, 1, 1, 1, 0, 0, 0],
            [1, 1, 1, 1, 0, 1, 0],
            [1, 1, 1, 1, 1, 0, 0],
            [1, 1, 1, 1, 1, 1, 0],
            [0, 0, 1, 1, 1, 0, 1]
        ], false);
        Assert([
             [0, 0, 0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0, 1, 0],
            [0, 0, 0, 0, 1, 0, 0],
            [0, 0, 1, 0, 0, 0, 1],
            [0, 0, 0, 0, 1, 1, 0],
            [0, 0, 0, 1, 0, 0, 0],
            [0, 0, 0, 1, 0, 1, 0],
            [0, 0, 0, 1, 1, 0, 0],
            [0, 0, 0, 1, 1, 1, 0],
            [0, 0, 1, 0, 0, 0, 0],
            [0, 0, 1, 1, 0, 1, 0],
            [0, 0, 1, 0, 0, 1, 0],
            [0, 0, 1, 0, 1, 0, 0],
            [0, 0, 1, 0, 1, 1, 0],
            [0, 0, 1, 1, 0, 0, 0],
            [0, 0, 1, 1, 0, 0, 1],
            [0, 0, 1, 1, 1, 0, 0],
            [0, 0, 1, 1, 1, 1, 0],
            [0, 1, 0, 0, 0, 0, 0],
            [0, 1, 0, 0, 0, 0, 1],
            [0, 1, 0, 0, 0, 1, 0],
            [0, 1, 0, 0, 1, 0, 0],
            [0, 1, 0, 0, 1, 0, 1],
            [0, 1, 0, 0, 1, 1, 0],
            [0, 1, 0, 1, 0, 0, 0],
            [0, 1, 0, 1, 0, 0, 1],
            [0, 1, 0, 1, 0, 1, 0],
            [0, 1, 0, 1, 1, 0, 0],
            [0, 1, 0, 1, 1, 0, 1],
            [0, 1, 0, 1, 1, 1, 0],
            [0, 1, 1, 0, 0, 0, 0],
            [0, 1, 1, 0, 0, 0, 1],
            [0, 1, 1, 0, 0, 1, 0],
            [0, 1, 1, 0, 0, 1, 1],
            [0, 1, 1, 0, 1, 0, 0],
            [0, 1, 1, 0, 1, 0, 1],
            [0, 1, 1, 0, 1, 1, 0],
            [0, 1, 1, 1, 0, 0, 0],
            [0, 1, 1, 1, 0, 0, 1],
            [0, 1, 1, 1, 0, 1, 0],
            [0, 1, 1, 1, 0, 1, 1],
            [0, 1, 1, 1, 1, 0, 0],
            [0, 1, 1, 1, 1, 0, 1],
            [0, 1, 1, 1, 1, 1, 0],
            [1, 0, 0, 0, 0, 0, 1],
            [1, 0, 0, 0, 0, 1, 0],
            [1, 0, 0, 0, 0, 1, 1],
            [1, 0, 0, 0, 1, 0, 0],
            [1, 0, 0, 0, 1, 0, 1],
            [1, 0, 0, 0, 1, 1, 0],
            [1, 0, 0, 0, 1, 1, 1],
            [1, 0, 0, 1, 0, 0, 1],
            [1, 0, 0, 1, 0, 1, 0],
            [1, 0, 0, 1, 0, 1, 1],
            [1, 0, 0, 1, 1, 0, 0],
            [1, 0, 0, 1, 1, 0, 1],
            [1, 0, 0, 1, 1, 1, 0],
            [1, 0, 0, 1, 1, 1, 1],
            [1, 0, 1, 0, 0, 0, 1],
            [1, 0, 1, 0, 0, 1, 0],
            [1, 0, 1, 0, 0, 1, 1],
            [1, 0, 1, 0, 1, 0, 1],
            [1, 0, 1, 0, 1, 1, 0],
            [1, 0, 1, 0, 1, 1, 1],
            [1, 0, 1, 1, 0, 0, 1],
            [1, 0, 1, 1, 0, 1, 0],
            [1, 0, 1, 1, 0, 1, 1],
            [1, 0, 1, 1, 1, 0, 1],
            [1, 0, 1, 1, 1, 1, 0],
            [1, 0, 1, 1, 1, 1, 1],
            [1, 1, 0, 0, 0, 0, 1],
            [1, 1, 0, 0, 0, 1, 1],
            [1, 1, 0, 0, 1, 0, 1],
            [1, 1, 0, 0, 1, 1, 0],
            [1, 1, 0, 0, 1, 1, 1],
            [1, 1, 0, 1, 0, 0, 1],
            [1, 1, 0, 1, 0, 1, 1],
            [1, 1, 0, 1, 1, 0, 1],
            [1, 1, 0, 1, 1, 1, 0],
            [1, 1, 0, 1, 1, 1, 1],
            [1, 1, 1, 0, 0, 0, 1],
            [1, 1, 1, 0, 0, 1, 1],
            [1, 1, 1, 0, 1, 0, 1],
            [1, 1, 1, 0, 1, 1, 1],
            [1, 1, 1, 1, 0, 0, 1],
            [1, 1, 1, 1, 0, 1, 1],
            [1, 1, 1, 1, 1, 0, 1],
            [1, 1, 1, 1, 1, 1, 1]
        ], true);
        Assert([
             [1, 0, 0, 0, 0, 0, 0]
            ,[0, 0, 0, 0, 0, 1, 1]
            ,[0, 0, 1, 1, 0, 1, 1]
        ], false);
    }

    operation Solve71_Test () : Unit {
        Assert([
            [0, 0, 0, 0, 1, 0, 0]
        ], true);
    }

    operation Equal_Test() : Unit {
        AssertEqual(
            [1,1], [0,0], false
        );
        AssertEqual(
            [1], [0], false
        );
    }

    operation AssertEqual(bits1: Int[], bits2: Int[], equal: Bool) : Unit {
        using (left = Qubit[Length(bits1)]) {
            using (right = Qubit[Length(bits1)]) {
                MatchBits(left, bits1, false);
                MatchBits(right, bits2, false);
                using (y = Qubit[1]) {
                    Equal(left, right, y[0]);
                    if (equal) {
                        X(y[0]);
                    }
                }
                MatchBits(left, bits1, false);
                MatchBits(right, bits2, false);
            }
        }
    }

    operation Assert(bits: Int[][], periodic: Bool) : Unit {
        for (bit in bits) {
            Message($"try {bit} expect: {periodic}");
            for (inv in [true, false]) {
                using (x = Qubit[Length(bit)]) {
                    using (y = Qubit[1]) {
                        MatchBits(x, bit, inv);
                        Solve(x, y[0]);
                        MatchBits(x, bit, inv);
                        if (periodic) {
                            X(y[0]);
                        }
                        AssertAllZero(x + y);
                    }
                }
            }
        }
    }

    operation MatchBits(x: Qubit[], bits:Int[], inv: Bool): Unit {
        for (ix in 0..Length(bits) - 1) {
            if (not inv && bits[ix] != 0) {
                X(x[ix]);
            } elif (inv && bits[ix] == 0) {
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
