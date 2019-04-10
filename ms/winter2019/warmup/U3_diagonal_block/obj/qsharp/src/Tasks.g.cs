#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs\",\"Position\":{\"Item1\":19,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs\",\"Position\":{\"Item1\":32,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Adjointable<QArray<Qubit>>, ICallable
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

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            var qs = x?.Copy();
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            var length = x.Length;
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(x[(length - 1L)]);
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            foreach (var ix in new Range(0L, (length - 2L)))
#line hidden
            {
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((new QArray<Qubit>()
                {x[(length - 1L)]}, x[ix]));
            }

#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(x[(length - 1L)]);
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
            foreach (var ix in new Range(0L, (length - 2L)))
#line hidden
            {
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U3_diagonal_block/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Controlled.Apply((new QArray<Qubit>()
                {qs[(length - 1L)]}, qs[ix]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var x = __in__;
#line hidden
            var qs = x?.Copy();
#line hidden
            var length = x.Length;
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(0L, (length - 2L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveH.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {qs[(length - 1L)]}, qs[ix]));
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(length - 1L)]);
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(0L, (length - 2L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((new QArray<Qubit>()
                {x[(length - 1L)]}, x[ix]));
            }

#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(length - 1L)]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(x);
        }
    }
}