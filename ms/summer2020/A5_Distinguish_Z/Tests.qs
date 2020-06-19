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
    
    
    
    operation Solve_Test () : Unit {
        EqualityFactI(Solve(Z), 0, "Z should be 0");
        EqualityFactI(Solve(_NZ), 1, "CNOT should be 1");
    }

    operation _IX(qs : Qubit[]): Unit is Adj+Ctl {
        X(qs[1]);
    }

    operation _NZ(qs : Qubit): Unit is Adj+Ctl {
        X(qs);
        Z(qs);
        X(qs);
    }

    operation _CNOT(qs : Qubit[]): Unit is Adj+Ctl {
        CNOT(qs[0], qs[1]);
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
