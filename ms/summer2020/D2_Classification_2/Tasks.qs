// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Arithmetic;
    
    /// <summary>
    /// You are given two qubits in state |00⟩. Your task is to prepare 
    /// the following state on them:
    ///
    /// 13‾√(|01⟩+|10⟩+|11⟩)
    /// This task is very similar to problem A1 of the Winter 2019 
    /// contest, but this time you are not allowed to use any gates 
    /// except the Pauli gates (X, Y and Z), the Hadamard gate and 
    /// the controlled versions of those. However, you are allowed 
    /// to use measurements.
    ///
    /// You have to implement an operation which takes an array of 
    /// 2 qubits as an input and has no output. The "output" of 
    /// your solution is the state in which it left the input qubits.
    /// </summary>

    operation Solve (qs : Qubit[]) : Unit {
        using (qq = Qubit[1]) {
            WState_Arbitrary(qq + qs);
            X(qs[0]);
            X(qs[1]);
            Controlled X (qs, qq[0]);
            ResetAll(qq);
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
                            set good = (M(q[ix]) == Zero) and good;
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
        while (N > n) {
            set n = n * 2;
        }
        return n;
    }
}
