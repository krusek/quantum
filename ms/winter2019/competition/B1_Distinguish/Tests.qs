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
        for (omega in [0,1]) {
            mutable counts = [0,0,0,0,0,0,0,0,0];
            for (_ in 0..200) {
                using (q = Qubit[3]) {
                    WState_Arbitrary(q);
                    X(q[1]);
                    X(q[2]);
                    CCNOT(q[1], q[2], q[0]);
                    X(q[1]);
                    X(q[2]);
                    if (omega == 0) {
                        R1(w, q[1]);
                        R1(2.0*w, q[2]);
                    } else {
                        R1(w, q[2]);
                        R1(2.0*w, q[1]);
                    }
                    let c = Solve(q);
                    set counts[c] = counts[c] + 1;
                    ResetAll(q);
                }
            }
            Message($"for: {omega} got: {counts}");
        }
    }

    // Task 12**. W state on 2^k qubits
    // Input: N = 2^k qubits in |0...0⟩ state.
    // Goal: create a W state (https://en.wikipedia.org/wiki/W_state) on these qubits.
    // W state is an equal superposition of all basis states on N qubits of Hamming weight 1.
    // Example: for N = 4, W state is (|1000⟩ + |0100⟩ + |0010⟩ + |0001⟩) / 2.
    operation WState_PowerOfTwo (qs : Qubit[]) : Unit {
            // Hint: you can use Controlled modifier to perform arbitrary controlled gates.

        // ...
        body(...) {
            let L = Length(qs);
            if (L == 1) {
                X(qs[0]);
            } else {
                let P = L / 2;
                // Do half the bits.
                WState_PowerOfTwo(qs[0..P-1]);

                // Create an extra bit to double the number of states we have
                using (q = Qubit[1]) {
                    H(q[0]);
                    
                    for (ix in 0..P-1) {
                        Controlled SWAP(q, (qs[ix], qs[ix + P]));
                    }
                    for (ix in 0..P-1) {
                        CNOT(qs[ix+P], q[0]);
                    }
                }
            }
        }
        adjoint invert;
    }
    
    
    // Task 13**. W state on arbitrary number of qubits
    // Input: N qubits in |0...0⟩ state (N is not necessarily a power of 2).
    // Goal: create a W state (https://en.wikipedia.org/wiki/W_state) on these qubits.
    // W state is an equal superposition of all basis states on N qubits of Hamming weight 1.
    // Example: for N = 3, W state is (|100⟩ + |010⟩ + |001⟩) / sqrt(3).
    operation WState_Arbitrary (qs : Qubit[]) : Unit {
            let N = Length(qs);
            let P = Next_Power(N);
            if (N == P) {
                WState_PowerOfTwo(qs);
            } else {
                using (q = Qubit[P - N]) {
                    let bits = qs + q;
                    repeat {
                        WState_PowerOfTwo(bits);
                        mutable good = true;
                        for (ix in 0..P-N-1) {
                            set good = (M(q[ix]) == Zero) && good;
                        }
                    } until (good) 
                    fixup {
                        ResetAll(q);
                    }
                }
            }
    }

    function Next_Power(N : Int) : Int {
        mutable n = 1;
        if (n == N) {
            return n;
        }
        repeat {
            set n = n * 2;
        } until (n >= N)
        fixup {}
        return n;
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
