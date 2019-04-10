#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":49,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":50,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":60,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":105,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":105,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Next_Power\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":127,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Next_Power\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs\",\"Position\":{\"Item1\":127,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ApplyToEach
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> WState_Arbitrary
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var x = __in__;
#line hidden
            {
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                var q = Allocate.Apply(1L);
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                WState_Arbitrary.Apply((q + x));
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                MicrosoftQuantumPrimitiveCCNOT.Apply((x[0L], x[1L], q[0L]));
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.ApplyToEach = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ApplyToEach));
            this.WState_Arbitrary = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(WState_Arbitrary));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(x);
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
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            var N = qs.Length;
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            if ((N == 1L))
            {
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 39 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line 40 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                MicrosoftQuantumPrimitiveRy.Apply(((2D * theta), qs[0L]));
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 44 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 45 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
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
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
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

    public class WState_PowerOfTwo : Adjointable<QArray<Qubit>>, ICallable
    {
        public WState_PowerOfTwo(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_PowerOfTwo";
        String ICallable.FullName => "Solution.WState_PowerOfTwo";
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

        protected Allocate Allocate
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> self
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            var L = qs.Length;
#line 77 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            if ((L == 1L))
            {
#line 78 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                var P = (L / 2L);
#line 82 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                self.Apply(qs?.Slice(new Range(0L, (P - 1L))));
#line hidden
                {
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    var q = Allocate.Apply(1L);
#line 86 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[0L]);
#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    foreach (var ix in new Range(0L, (P - 1L)))
#line hidden
                    {
#line 89 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((q?.Copy(), (qs[ix], qs[(ix + P)])));
                    }

#line 91 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    foreach (var ix in new Range(0L, (P - 1L)))
#line hidden
                    {
#line 92 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qs[(ix + P)], q[0L]));
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var L = qs.Length;
#line hidden
            if ((L == 1L))
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[0L]);
            }
            else
            {
#line hidden
                var P = (L / 2L);
#line hidden
                {
#line hidden
                    var q = Allocate.Apply(1L);
#line hidden
                    foreach (var ix in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((qs[(ix + P)], q[0L]));
                    }

#line hidden
                    foreach (var ix in RangeReverse.Apply(new Range(0L, (P - 1L))))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((q?.Copy(), (qs[ix], qs[(ix + P)])));
                    }

#line hidden
                    MicrosoftQuantumPrimitiveH.Adjoint.Apply(q[0L]);
#line hidden
                    Release.Apply(q);
                }

#line hidden
                self.Adjoint.Apply(qs?.Slice(new Range(0L, (P - 1L))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.self = this;
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<WState_PowerOfTwo, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class WState_Arbitrary : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public WState_Arbitrary(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary";
        String ICallable.FullName => "Solution.WState_Arbitrary";
        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> Next_Power
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> WState_PowerOfTwo
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 107 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            var N = qs.Length;
#line 108 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            var P = Next_Power.Apply(N);
#line 109 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            if ((N == P))
            {
#line 110 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                WState_PowerOfTwo.Apply(qs?.Copy());
            }
            else
            {
#line hidden
                {
#line 112 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    var q = Allocate.Apply((P - N));
#line 113 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    var bits = (qs + q);
#line 114 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                    while (true)
                    {
#line 115 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                        WState_PowerOfTwo.Apply(bits?.Copy());
#line 116 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                        var good = true;
#line 117 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                        foreach (var ix in new Range(0L, ((P - N) - 1L)))
#line hidden
                        {
#line 118 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                            good = ((M.Apply(q[ix]) == Result.Zero) && good);
                        }

                        if (good)
                        {
                            break;
                        }
                        else
                        {
#line 122 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                            ResetAll.Apply(q?.Copy());
                        }
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Next_Power = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Next_Power));
            this.WState_PowerOfTwo = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(WState_PowerOfTwo));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<WState_Arbitrary, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class Next_Power : Function<Int64, Int64>, ICallable
    {
        public Next_Power(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Next_Power";
        String ICallable.FullName => "Solution.Next_Power";
        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var N = __in__;
#line 129 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            var n = 1L;
#line 130 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            if ((n == N))
            {
#line 131 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                return n;
            }

#line 133 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            while (true)
            {
#line 134 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
                n = (n * 2L);
                if ((n >= N))
                {
                    break;
                }
                else
                {
                }
            }

#line 137 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A1_Three_State/Tasks.qs"
            return n;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<Next_Power, Int64, Int64>(N);
        }
    }
}