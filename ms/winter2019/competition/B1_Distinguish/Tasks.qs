// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve(x: Qubit[]) : Int {
        let w = 2.0*PI()/3.0;
        mutable sum = 0;
        R1(-w, x[1]);
        R1(-2.0*w, x[2]);
        Adjoint WState_Arbitrary_Reference(x);
        if (M(x[0]) == One) {
            set sum = sum + 1;
        }
        if (M(x[1]) == One) {
            set sum = sum + 2;
        }
        if (M(x[2]) == One) {
            set sum = sum + 4;
        }
        if (sum == 0) {
            return 0;
        } else {
            return 1;
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

    operation Solve2 (x : Qubit[]) : Int {
        let w = 2.0*PI()/3.0;
        R1(w, x[1]);
        R1(2.0*w, x[2]);
        CNOT(x[1], x[0]);
        Controlled H([x[0]], x[1]);
        mutable sum = 0;
        if (Measure([PauliZ, PauliZ], [x[1], x[0]]) == One) {
            set sum = sum + 1;
        }
        CNOT(x[2], x[0]);
        H(x[2]);
        if (Measure([PauliX], [x[2]]) == One) {
            set sum = sum + 2;
        }
        H(x[2]);
        R1(2.0*w, x[2]);
        if (Measure([PauliZ], [x[0]]) == One) {
            set sum = sum + 4;
        }
        return sum;
    }


    operation ApplyToEach(op: ((Qubit) => Unit : Adjoint), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }
}
