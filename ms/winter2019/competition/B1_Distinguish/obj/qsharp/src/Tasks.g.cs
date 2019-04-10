#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":64,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":92,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs\",\"Position\":{\"Item1\":97,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in__) =>
        {
            var x = __in__;
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            var sum = 0L;
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveR1.Apply((-(w), x[1L]));
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveR1.Apply(((-(2D) * w), x[2L]));
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            WState_Arbitrary_Reference.Adjoint.Apply(x?.Copy());
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((M.Apply(x[0L]) == Result.One))
            {
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 1L);
            }

#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((M.Apply(x[1L]) == Result.One))
            {
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 2L);
            }

#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((M.Apply(x[2L]) == Result.One))
            {
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 4L);
            }

#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((sum == 0L))
            {
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                return 0L;
            }
            else
            {
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                return 1L;
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve, QArray<Qubit>, Int64>(x);
        }
    }

    public class WState_Arbitrary_Reference : Unitary<QArray<Qubit>>, ICallable
    {
        public WState_Arbitrary_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary_Reference";
        String ICallable.FullName => "Solution.WState_Arbitrary_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> self
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 44 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            var N = qs.Length;
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((N == 1L))
            {
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 53 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                MicrosoftQuantumPrimitiveRy.Apply(((2D * theta), qs[0L]));
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 59 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[0L]);
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[0L]);
#line hidden
                self.Controlled.Adjoint.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[0L]);
#line hidden
                MicrosoftQuantumPrimitiveRy.Adjoint.Apply(((2D * theta), qs[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line hidden
                MicrosoftQuantumPrimitiveRy.Controlled.Apply((__controlQubits__?.Copy(), ((2D * theta), qs[0L])));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
#line hidden
                self.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L))))));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
#line hidden
                self.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L))))));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), qs[0L]));
#line hidden
                MicrosoftQuantumPrimitiveRy.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), ((2D * theta), qs[0L])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcSin));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.self = this;
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<WState_Arbitrary_Reference, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class Solve2 : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Solve2(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve2";
        String ICallable.FullName => "Solution.Solve2";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in__) =>
        {
            var x = __in__;
#line 69 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 70 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveR1.Apply((w, x[1L]));
#line 71 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveR1.Apply(((2D * w), x[2L]));
#line 72 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((x[1L], x[0L]));
#line 73 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveH.Controlled.Apply((new QArray<Qubit>()
            {x[0L]}, x[1L]));
#line 74 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            var sum = 0L;
#line 75 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((Measure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), new QArray<Qubit>(x[1L], x[0L]))) == Result.One))
            {
#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 1L);
            }

#line 78 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((x[2L], x[0L]));
#line 79 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveH.Apply(x[2L]);
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliX}, new QArray<Qubit>()
            {x[2L]})) == Result.One))
            {
#line 81 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 2L);
            }

#line 83 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveH.Apply(x[2L]);
#line 84 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            MicrosoftQuantumPrimitiveR1.Apply(((2D * w), x[2L]));
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            if ((Measure.Apply((new QArray<Pauli>()
            {Pauli.PauliZ}, new QArray<Qubit>()
            {x[0L]})) == Result.One))
            {
#line 86 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                sum = (sum + 4L);
            }

#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve2, QArray<Qubit>, Int64>(x);
        }
    }

    public class ApplyToEach : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public ApplyToEach(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyToEach";
        String ICallable.FullName => "Solution.ApplyToEach";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,x) = __in__;
#line 94 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 95 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tasks.qs"
                op.Apply(x[ix]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,x) = __in__;
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(0L, (x.Length - 1L))))
#line hidden
            {
#line hidden
                op.Adjoint.Apply(x[ix]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, QArray<Qubit> x)
        {
            return __m__.Run<ApplyToEach, (IAdjointable,QArray<Qubit>), QVoid>((op, x));
        }
    }
}