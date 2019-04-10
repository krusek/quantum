// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation Solve (q : Qubit) : Int {
        mutable output = 0;
        let alpha = ArcCos(Sqrt(2.0 / 3.0));
        using (a = Qubit()) {
            Z(q);
            CNOT(a, q);
            Controlled H([q], a);
            S(a);
            X(q);
            (ControlledOnInt(0, Ry))([a], (-2.0 * alpha, q));
            CNOT(a, q);
            Controlled H([q], a);
            CNOT(a, q);
            // finally, measure in the standard basis
            let res0 = MResetZ(a);
            let res1 = M(q);
            // dispatch on the cases
            if (res0 == Zero && res1 == Zero) {
                set output = 0;
            }
            elif (res0 == One && res1 == Zero) {
                set output = 1;
            }
            elif (res0 == Zero && res1 == One) {
                set output = 2;
            }
            else {
                // this should never occur
                set output = 3;
            }
        }
        return output;
    }

    operation Solve4(xx: Qubit) : Int {
        let w = 2.0*PI()/3.0;
        let x = [xx];
        let sum = 0;
        Rx(PI()/2.0, xx);
        return sum;
    }

    operation Solve2(xx: Qubit) : Int {
        let w = 2.0*PI()/3.0;
        let x = [xx];
        mutable sum = 0;
        using (q = Qubit[2]) {
            H(q[1]);
            H(q[0]);
            R1(2.0*w, q[0]);
            R1(-w, x[0]);
            CNOT(x[0], q[0]);
            CNOT(q[1], q[0]);
            H(x[0]);
            H(q[1]);
            if (M(q[1]) == One) {
                set sum = sum + 1;
                X(q[1]);
            }
            if (M(x[0]) == One) {
                set sum = sum + 2;
                X(q[0]);
            }
            ResetAll(q);
        }
        return sum;
    }

    operation Solve3 (q : Qubit) : Int {
        let w = 2.0*PI()/3.0;

        mutable sum = 0;
        using (p = Qubit[2]) {
            H(p[0]);
            H(p[1]);
            
        }
        // using (p = Qubit[2]) {
        //     let i1 = p[0];
        //     let i2 = p[1];
        //     let ww = q;

        //     H(i1);
        //     H(i2);
        //     Controlled R1([i1], (w, ww));
        //     Controlled R1([i2], (w, ww));
        //     Controlled R1([i2], (w, ww));
        //     H(i2);
        //     Controlled R1Frac([p[0]], (1, 2, p[1]));
        //     H(i1);
        //     if (M(i1) == One) {
        //         set sum = sum + 1;
        //         X(p[0]);
        //     }
        //     if (M(i2) == One) {
        //         set sum = sum + 2;
        //         X(p[1]);
        //     }
        // }

// Solution by dacin21
// My solution to B2 (In the editorial this is marked as TODO) (This might have some wrong minuses):
// Apply H followed by Rz(π / 2) to map the three states to |0⟩, |0⟩ — |1⟩ and |0⟩ + |1⟩. This gets rid of all the complex phases.
// Let x be the first qubit. We allocate another qubit y.
// Then apply Ry( controlled by x to map |00⟩ — |10⟩ to |00⟩ — |10⟩ — |11⟩.
// Then apply H(x) controlled by y. This maps |00⟩ — |10⟩ — |11⟩. to |00⟩ — |10⟩ — |01⟩ + |11⟩.
// The last two operations kept the first state at |00⟩.
// Now apply H(x). The first state goes to |00⟩ + |10⟩. The second one goes to |00⟩ — |11⟩.
// To retrace where the third state went, note that it is minus the sum of the other two states, so it is at |10⟩ + |11⟩.
// We can now measure both qubits to find a state which was not present.
// The way I figured this out was by starting at the bottom (We somehow want 3 elementary states where each possible state is the sum of two of them). The angles are , so we should be able find a unitary (hence angle preserving) operation that maps the initial states to them. By using controlled operations, we can keep the first state at |00⟩, so we can focus on the second state (and the third one will be automatically correct). Then reconstruct the operation from bottom to top.
        return sum;
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
}
