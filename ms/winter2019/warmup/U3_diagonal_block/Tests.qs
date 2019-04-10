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
    
    
    // ------------------------------------------------------
    function Solve_Pattern_Upper (size : Int, row : Int, col : Int) : Bool {
        return row + col == size - 1;
    }
    
    // ------------------------------------------------------
    function Solve_Pattern (size : Int, row : Int, col : Int) : Bool {
        let s2 = size / 2;
        if (row < s2 && col < s2) {
            return Solve_Pattern_Upper(size / 2, row, col);
        } elif (row < s2 && col >= s2) {
            return false;
        } elif (row >= s2 && col < s2) {
            return false;
        } else {
            return true;
        }
    }
    
    operation Solve_Test () : Unit {
        for (n in 2 .. 5) {
            AssertOperationMatrixMatchesPattern(n, Solve, Solve_Pattern);
        }
    }


    // ------------------------------------------------------
    // Test harness: given an operation on N qubits and a function which takes two indices between 0 and 2^N-1
    // and returns false if the element of the matrix at that index is 0 and true if it is non-zero,
    // test that the operation implements a matrix of this shape
    operation AssertOperationMatrixMatchesPattern (N : Int, op : (Qubit[] => Unit), pattern : ((Int, Int, Int) -> Bool)) : Unit {
        let size = 1 <<< N;
        
        //Message($"Testing on {N} qubits");
        let ε = 0.000001;
        
        using (qs = Qubit[N]) {
            for (k in 0 .. size - 1) {                
                // Prepare k-th basis vector
                let binary = BoolArrFromPositiveInt(k, N);
                
                //Message($"{k}/{N} = {binary}");
                // binary is little-endian notation, so the second vector tried has qubit 0 in state 1 and the rest in state 0
                ApplyPauliFromBitString(PauliX, true, binary, qs);
                
                // Reset the counter of measurements done outside of the solution call
                ResetOracleCallsCount();
                
                // Apply the operation
                op(qs);
                
                // Make sure the solution didn't use any measurements
                AssertIntEqual(GetOracleCallsCount(M), 0, "You are not allowed to use measurements in this task");
                AssertIntEqual(GetOracleCallsCount(Measure), 0, "You are not allowed to use measurements in this task");

                // Test that the result matches the k-th column
                // DumpMachine($"C:/Tmp/dump{N}_{k}.txt");
                for (j in 0 .. size - 1) {                    
                    let nonZero = pattern(size, j, k);

                    if (nonZero) {                        
                        AssertProbInt(j, 0.5 + ε, LittleEndian(qs), 0.5);
                    }
                    else {                        
                        AssertProbInt(j, 0.0, LittleEndian(qs), ε);
                    }
                }
                
                ResetAll(qs);
            }
        }
    }
    
    
    // ------------------------------------------------------
    function MainDiagonal_Pattern (size : Int, row : Int, col : Int) : Bool {
        return row == col;
    }
    
    
    // ------------------------------------------------------
    function AllNonZero_Pattern (size : Int, row : Int, col : Int) : Bool {
        return true;
    }
    
    
    // ------------------------------------------------------
    function Quarters_Pattern (size : Int, row : Int, col : Int) : Bool {
        // The indices are little-endian, with qubit 0 corresponding to the least significant bit
        // and qubits 1..N-1 corresponding to most significant bits.
        // The pattern of quarters corresponds to equality of the most significant bits of row and column (qubit N-1)
        return row / (size / 2) == col / (size / 2);
    }
    
    
    // ------------------------------------------------------
    function EvenChessPattern_Pattern (size : Int, row : Int, col : Int) : Bool {
        // The indices are little-endian, qubit 0 corresponding to the least significant bit
        // and qubits 1..N-1 corresponding to most significant bits.
        // The chessboard pattern corresponds to equality of the least significant bits of row and column (qubit 0)
        return row % 2 == col % 2;
    }
    
    
    // ------------------------------------------------------
    function OddChessPattern_Pattern (size : Int, row : Int, col : Int) : Bool {
        // The indices are little-endian, qubit 0 corresponding to the least significant bit
        // and qubits 1..N-1 corresponding to most significant bits.
        // The chessboard pattern corresponds to inequality of the least significant bits of row and column (qubit 0)
        return row % 2 != col % 2;
    }


    // ------------------------------------------------------
    function GetOracleCallsCount<'T> (oracle : 'T) : Int { return 0; }
    
    function ResetOracleCallsCount () : Unit { }

    function GetMaxQubitCount () : Int { return 0; }
    
    function ResetQubitCount () : Unit { }
}
