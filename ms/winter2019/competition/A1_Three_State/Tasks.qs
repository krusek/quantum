// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (x : Qubit[]) : Unit {
        using (q = Qubit[1]) {
            WState_Arbitrary(q + x);
            ApplyToEach(X, x);
            CCNOT(x[0], x[1], q[0]);
            ApplyToEach(X, x);
        }
    }
     
    // Task 13. W state on arbitrary number of qubits
    // Input: N qubits in |0...0⟩ state (N is not necessarily a power of 2).
    // Goal: create a W state (https://en.wikipedia.org/wiki/W_state) on these qubits.
    // W state is an equal superposition of all basis states on N qubits of Hamming weight 1.
    // Example: for N = 3, W state is (|100⟩ + |010⟩ + |001⟩) / sqrt(3).
    
    // general solution based on rotations and recursive application of controlled generation routine
    operation WState_Arbitrary_Reference (qs : Qubit[]) : Unit {
        
        body (...) {
            let N = Length(qs);
            
            if (N == 1) {
                // base case of recursion: |1⟩
                X(qs[0]);
            } else {
                // |W_N⟩ = |0⟩|W_(N-1)⟩ + |1⟩|0...0⟩
                // do a rotation on the first qubit to split it into |0⟩ and |1⟩ with proper weights
                // |0⟩ -> sqrt((N-1)/N) |0⟩ + 1/sqrt(N) |1⟩
                let theta = ArcSin(1.0 / Sqrt(ToDouble(N)));
                Ry(2.0 * theta, qs[0]);
                
                // do a zero-controlled W-state generation for qubits 1..N-1
                X(qs[0]);
                Controlled WState_Arbitrary_Reference(qs[0 .. 0], qs[1 .. N - 1]);
                X(qs[0]);
            }
        }
        
        adjoint invert;
        controlled distribute;
        controlled adjoint distribute;
    }


    operation ApplyToEach(op: ((Qubit) => Unit : Adjoint), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
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
}
