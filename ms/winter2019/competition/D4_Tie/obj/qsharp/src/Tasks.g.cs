#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"XMatrix\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"XMatrix\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":43,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":50,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":51,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ReverseFirstHalfDiagonal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ReverseFirstHalfDiagonal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ReverseLastHalfDiagonal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ReverseLastHalfDiagonal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":88,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs\",\"Position\":{\"Item1\":93,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
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
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> AddOne
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ReverseFirstHalfDiagonal
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ReverseLastHalfDiagonal
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> XMatrix
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var x = __in__;
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            ReverseFirstHalfDiagonal.Apply(x?.Copy());
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            ReverseLastHalfDiagonal.Apply(x?.Copy());
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            var L = x.Length;
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(x[(L - 1L)]);
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            AddOne.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {x[(L - 1L)]}, x?.Slice(new Range(0L, (L - 2L)))));
#line 19 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(x[(L - 1L)]);
#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            AddOne.Controlled.Apply((new QArray<Qubit>()
            {x[(L - 1L)]}, x?.Slice(new Range(0L, (L - 2L)))));
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            XMatrix.Apply(x?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.AddOne = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(AddOne));
            this.ReverseFirstHalfDiagonal = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(ReverseFirstHalfDiagonal));
            this.ReverseLastHalfDiagonal = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(ReverseLastHalfDiagonal));
            this.XMatrix = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(XMatrix));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(x);
        }
    }

    public class XMatrix : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public XMatrix(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "XMatrix";
        String ICallable.FullName => "Solution.XMatrix";
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

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var x = __in__;
#line hidden
            {
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                var p = Allocate.Apply(2L);
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((p[0L], x[0L]));
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                foreach (var q in x?.Slice(new Range(1L, (x.Length - 1L))))
#line hidden
                {
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((p[0L], q));
                }

#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(p[0L]);
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                foreach (var q in x?.Slice(new Range(1L, (x.Length - 1L))))
#line hidden
                {
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((p[0L], q));
                }

#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[0L], p[0L]));
#line 36 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((p[0L], x[0L]));
#line hidden
                Release.Apply(p);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<XMatrix, QArray<Qubit>, QVoid>(x);
        }
    }

    public class AddOne : Unitary<QArray<Qubit>>, ICallable
    {
        public AddOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AddOne";
        String ICallable.FullName => "Solution.AddOne";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var x = __in__;
#line 45 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            var L = x.Length;
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            foreach (var ix in new Range(1L, (L - 1L)))
#line hidden
            {
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Slice(new Range(0L, ((L - ix) - 1L))), x[(L - ix)]));
            }

#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(x[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var x = __in__;
#line hidden
            var L = x.Length;
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[0L]);
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(1L, (L - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((x?.Slice(new Range(0L, ((L - ix) - 1L))), x[(L - ix)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,x) = __in__;
#line hidden
            var L = x.Length;
#line hidden
            foreach (var ix in new Range(1L, (L - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (x?.Slice(new Range(0L, ((L - ix) - 1L))), x[(L - ix)])));
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), x[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,x) = __in__;
#line hidden
            var L = x.Length;
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), x[0L]));
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(1L, (L - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (x?.Slice(new Range(0L, ((L - ix) - 1L))), x[(L - ix)])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<AddOne, QArray<Qubit>, QVoid>(x);
        }
    }

    public class ReverseFirstHalfDiagonal : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ReverseFirstHalfDiagonal(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReverseFirstHalfDiagonal";
        String ICallable.FullName => "Solution.ReverseFirstHalfDiagonal";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            var length = qs.Length;
#line 66 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[(length - 1L)]);
#line 67 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            foreach (var ix in new Range(0L, (length - 2L)))
#line hidden
            {
#line 68 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
                {qs[(length - 1L)]}, qs[ix]));
            }

#line 70 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[(length - 1L)]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<ReverseFirstHalfDiagonal, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class ReverseLastHalfDiagonal : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public ReverseLastHalfDiagonal(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReverseLastHalfDiagonal";
        String ICallable.FullName => "Solution.ReverseLastHalfDiagonal";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ReverseFirstHalfDiagonal
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 82 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            var length = qs.Length;
#line 83 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[(length - 1L)]);
#line 84 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            ReverseFirstHalfDiagonal.Apply(qs?.Copy());
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[(length - 1L)]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.ReverseFirstHalfDiagonal = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(ReverseFirstHalfDiagonal));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<ReverseLastHalfDiagonal, QArray<Qubit>, QVoid>(qs);
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
#line 90 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 91 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D4_Tie/Tasks.qs"
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