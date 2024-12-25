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
        
        for (count in 4..4) {
        using (qs = Qubit[count]) {
            for (p in 2..2) {
                
                X(qs[3]);
                X(qs[2]);
                X(qs[1]);
                X(qs[0]);
                Message($"count: {count}, p: {p}");
                Message($"before");
                DumpRegister((), qs);

                QFT2(p, LittleEndian(qs));
                
                Message($"mine");
                DumpRegister((), qs);
                ResetAll(qs);

                X(qs[3]);
                X(qs[2]);
                X(qs[1]);
                X(qs[0]);
                for (ix in 1..p) {
                    QFTLE(LittleEndian(qs));
                }

                Message("Actual");
                DumpRegister((), qs);
                ResetAll(qs);
                AssertAllZero(qs);
            }
        }

        }
    }

    operation process(qs: Qubit[]) : Unit is Adj {
        // pass
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
