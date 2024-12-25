// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Solution {
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Bitwise;
    
    /// Implement an operation that is equivalent to the operation
    /// QFT𝑃, where QFT is the quantum Fourier transform.
    ///
    /// Your operation should take the following inputs:
    ///
    /// - an integer 𝑃 (2≤𝑃≤2.1⋅106).
    /// - a register of type LittleEndian - a wrapper type for an
    ///     array of qubits that encodes an unsigned integer in
    ///     little-endian format, with the least significant bit
    ///     written first (corresponding to the array element with
    ///     index 0). (If you need to, you can convert it to an
    ///     array type using unwrap operator: 
    ///     let qubitArray = inputRegister!;)
    ///
    /// The "output" of your solution is the state in which it 
    /// left the input qubits.
    operation Solve (p : Int, inputRegister : LittleEndian) : Unit is Adj+Ctl {
        let l = Length(inputRegister!);
        if (l > 0) {
            let half = power(2, l - 1);
            let pp = p % (2*half);
            Message($"attempted power: {p}");
            if (pp >= half) {
                for (ix in 1..(half-1)) {
                    Swap(ix, 2*half-ix, inputRegister!);
                }
            }
            let top = (pp >= half) ? pp - half | pp;

            for (ix in 1..(top)) {
                QFTLE(inputRegister);
            // ApplyQuantumFourierTransform(inputRegister, 1);
            }
            // if (pp % 2 == 0) {
            //     for (ix in 1..(pp/2)) {
            //     //     QFTLE(inputRegister);
            //     ApplyQuantumFourierTransform(inputRegister, 2);
            //     }
            // } else {
            //     for (ix in 1..pp) {
            //     //     QFTLE(inputRegister);
            //     ApplyQuantumFourierTransform(inputRegister, 1);
            //     }
            // }
            // if (pp > 0) {
            //     QFT(pp, 1, inputRegister);
            // }

        }
    }


    operation QFT2(p : Int, inputRegister : LittleEndian) : Unit is Adj+Ctl {
        let signed = SignedLittleEndian(inputRegister);
        Invert2sSI(signed);
        IncrementByInteger(16, inputRegister);
    }

    operation Swap(n: Int, m: Int, qs: Qubit[]) : Unit is Adj+Ctl {
        using (extra = Qubit[2]) {
            (ControlledOnInt(n, X))(qs, extra[0]);
            (ControlledOnInt(m, X))(qs, extra[1]);
            let diff = Xor(n, m);
            for (ix in 0..Length(qs)-1) {
                if (And(diff, 1<<<ix) != 0) {
                    CNOT(extra[0], qs[ix]);
                    CNOT(extra[1], qs[ix]);
                }
            }
            (ControlledOnInt(n, X))(qs, extra[1]);
            (ControlledOnInt(m, X))(qs, extra[0]);
        }
    }

    operation QFT(p : Int, current: Int, inputRegister : LittleEndian) : Unit is Adj+Ctl {
        if (p == 1) {
            ApplyQuantumFourierTransform(inputRegister, current);
        } elif (p % 2 == 0) {
            QFT(p / 2, 2 * current, inputRegister);

        } else {
            ApplyQuantumFourierTransform(inputRegister, current);
            QFT((p - 1) / 2, 2 * current, inputRegister);
        }
    }

    function power(b: Int, p: Int) : Int {
        if (p < 1) {
            return 2;
        }
        if (p == 1) {
            return b;
        }

        if (p % 2 == 1) {
            return b * power(b*b, (p - 1) / 2);
        } else {
            return power(b*b, p/2);
        }
    }


    operation ApplyToEach(op: ((Qubit) => Unit is Adj), x: Qubit[]) : Unit {
        body(...) {
            for (ix in 0..Length(x) - 1) {
                op(x[ix]);
            }
        }
        adjoint auto;
    }

        /// # Summary
    /// Apply the Approximate Quantum Fourier Transform (AQFT) to a quantum register.
    ///
    /// # Input
    /// ## a
    /// approximation parameter which determines at which level the controlled Z-rotations that
    /// occur in the QFT circuit are pruned.
    ///
    /// The approximation parameter a determines the pruning level of the Z-rotations, i.e.,
    /// a ∈ {0..n} and all Z-rotations 2π/2ᵏ where k>a are
    /// removed from the QFT circuit. It is known that for k >= log₂(n)+log₂(1/ε)+3
    /// one can bound ||QFT-AQFT||<ε.
    ///
    /// ## qs
    /// quantum register of n qubits to which the Approximate Quantum Fourier Transform is applied.
    ///
    /// # Remarks
    /// AQFT requires Z-rotation gates of the form 2π/2ᵏ and Hadamard gates.
    ///
    /// The input and output are assumed to be encoded in big endian encoding.
    ///
    ///
    /// # References
    /// - [ *M. Roetteler, Th. Beth*,
    ///      Appl. Algebra Eng. Commun. Comput.
    ///      19(3): 177-193 (2008) ](http://doi.org/10.1007/s00200-008-0072-2)
    /// - [ *D. Coppersmith* arXiv:quant-ph/0201067v1 ](https://arxiv.org/abs/quant-ph/0201067)
    operation ApproximateQFT (a : Int, p: Int, qs : BigEndian) : Unit is Adj + Ctl {
        let nQubits = Length(qs!);
        Fact(nQubits > 0, $"`Length(qs)` must be least 1");
        Fact(a > 0 and a <= nQubits, $"`a` must be positive and less than `Length(qs)`");

        for (i in 0 .. nQubits - 1) {
            for (j in 0 .. i - 1) {
                if (i - j < a) {
                    Controlled R1Frac([(qs!)[i]], (p, (i - j), (qs!)[j]));
                }
            }

            H((qs!)[i]);
        }

        // Apply the bit reversal permutation to the quantum register as
        // a side effect, such that we enforce the invariants specified
        // by the BigEndian UDT.
        SwapReverseRegister(qs!);
    }

    /// # Summary
    /// Performs the Quantum Fourier Transform on a quantum register containing an
    /// integer in the big-endian representation.
    ///
    /// # Input
    /// ## qs
    /// Quantum register to which the Quantum Fourier Transform is applied
    ///
    /// # Remarks
    /// The input and output are assumed to be in big endian encoding.
    ///
    /// # See Also
    /// - Microsoft.Quantum.Canon.ApproximateQFT
    /// - Microsoft.Quantum.Canon.QFTLE
    internal operation ApplyQuantumFourierTransformBE(qs : BigEndian, p: Int) : Unit is Adj + Ctl {
        ApproximateQFT(Length(qs!), p, qs);
    }

    /// # Summary
    /// Performs the Quantum Fourier Transform on a quantum register containing an
    /// integer in the little-endian representation.
    ///
    /// # Input
    /// ## qs
    /// Quantum register to which the Quantum Fourier Transform is applied
    ///
    /// # Remarks
    /// The input and output are assumed to be in little endian encoding.
    ///
    ///
    /// # See Also
    /// - ApplyQuantumFourierTransformBE
    operation ApplyQuantumFourierTransform(qs : LittleEndian, p: Int) : Unit is Adj + Ctl {
        if (p > 0) {
        ApplyReversedOpBECA(ApplyQuantumFourierTransformBE(_, p), qs);

        }
    }
}
