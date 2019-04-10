#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"After\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"After\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"DiagonalBlock\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"DiagonalBlock\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":50,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"DiagonalBlock\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AllHButN\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AllHButN\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":69,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AllHButN\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":76,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"contains\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"member\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"contains\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
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

        protected ICallable<(QArray<Qubit>,Int64), QArray<Qubit>> After
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ApplyToEach
        {
            get;
            set;
        }

        protected IControllable<QArray<Qubit>> DiagonalBlock
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var x = __in__;
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var qs = x?.Copy();
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            foreach (var ix in new Range(0L, (qs.Length - 2L)))
#line hidden
            {
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                var controls = After.Apply((qs?.Copy(), ix));
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, controls?.Copy()));
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                DiagonalBlock.Controlled.Apply((controls?.Copy(), qs?.Slice(new Range(0L, ix))));
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, controls?.Copy()));
            }

#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            DiagonalBlock.Apply(qs?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.After = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QArray<Qubit>>>(typeof(After));
            this.ApplyToEach = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ApplyToEach));
            this.DiagonalBlock = this.Factory.Get<IControllable<QArray<Qubit>>>(typeof(DiagonalBlock));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(x);
        }
    }

    public class After : Operation<(QArray<Qubit>,Int64), QArray<Qubit>>, ICallable
    {
        public After(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "After";
        String ICallable.FullName => "Solution.After";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QArray<Qubit>> Body => (__in__) =>
        {
            var (qs,index) = __in__;
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            return qs?.Slice(new Range((index + 1L), (qs.Length - 1L)));
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Qubit> data) => data;
        public static System.Threading.Tasks.Task<QArray<Qubit>> Run(IOperationFactory __m__, QArray<Qubit> qs, Int64 index)
        {
            return __m__.Run<After, (QArray<Qubit>,Int64), QArray<Qubit>>((qs, index));
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
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 31 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
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

    public class DiagonalBlock : Controllable<QArray<Qubit>>, ICallable
    {
        public DiagonalBlock(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DiagonalBlock";
        String ICallable.FullName => "Solution.DiagonalBlock";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IControllable<(QArray<Qubit>,Int64)> AllHButN
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 52 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var length = qs.Length;
#line 53 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var control = (length - 1L);
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            AllHButN.Controlled.Apply((new QArray<Qubit>()
            {qs[control]}, (qs?.Copy(), (length - 1L))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (controls,qs) = __in__;
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var length = qs.Length;
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var control = (length - 1L);
#line 59 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            var cntrls = (controls + new QArray<Qubit>()
            {qs[control]});
#line 60 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            AllHButN.Controlled.Apply((cntrls?.Copy(), (qs?.Copy(), (length - 1L))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AllHButN = this.Factory.Get<IControllable<(QArray<Qubit>,Int64)>>(typeof(AllHButN));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<DiagonalBlock, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class AllHButN : Controllable<(QArray<Qubit>,Int64)>, ICallable
    {
        public AllHButN(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "AllHButN";
        String ICallable.FullName => "Solution.AllHButN";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Qubit), Boolean> contains
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,N) = __in__;
#line 71 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 72 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                if ((ix != N))
                {
#line 73 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                    MicrosoftQuantumPrimitiveH.Apply(x[ix]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (controls,(x,N)) = __in__;
#line 78 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 79 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                if (((ix != N) && !(contains.Apply((controls?.Copy(), x[ix])))))
                {
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                    MicrosoftQuantumPrimitiveH.Controlled.Apply((controls?.Copy(), x[ix]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.contains = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), Boolean>>(typeof(contains));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 N)
        {
            return __m__.Run<AllHButN, (QArray<Qubit>,Int64), QVoid>((x, N));
        }
    }

    public class contains : Function<(QArray<Qubit>,Qubit), Boolean>, ICallable
    {
        public contains(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "contains";
        String ICallable.FullName => "Solution.contains";
        public override Func<(QArray<Qubit>,Qubit), Boolean> Body => (__in__) =>
        {
            var (qs,member) = __in__;
#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            foreach (var q in qs)
#line hidden
            {
#line 89 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                if ((q == member))
                {
#line 89 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
                    return true;
                }
            }

#line 91 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D2_Increasing/Tasks.qs"
            return false;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, QArray<Qubit> qs, Qubit member)
        {
            return __m__.Run<contains, (QArray<Qubit>,Qubit), Boolean>((qs, member));
        }
    }
}