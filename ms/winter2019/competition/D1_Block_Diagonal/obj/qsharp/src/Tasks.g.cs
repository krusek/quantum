#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"XSome\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"XSome\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs\",\"Position\":{\"Item1\":22,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"XSome\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs\",\"Position\":{\"Item1\":29,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Int64)> XSome
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
            var L = qs.Length;
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
            var controls = qs?.Slice(new Range(1L, (L - 1L)));
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
            foreach (var n in new Range(0L, (1L << (int)(L - 1L))))
#line hidden
            {
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
                XSome.Apply((controls?.Copy(), n));
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Controlled.Apply((controls?.Copy(), qs[0L]));
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
                XSome.Apply((controls?.Copy(), n));
            }

#line 19 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
            MicrosoftQuantumPrimitiveH.Controlled.Apply((qs?.Slice(new Range(1L, (L - 1L))), qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.XSome = this.Factory.Get<IAdjointable<(QArray<Qubit>,Int64)>>(typeof(XSome));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class XSome : Adjointable<(QArray<Qubit>,Int64)>, ICallable
    {
        public XSome(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "XSome";
        String ICallable.FullName => "Solution.XSome";
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

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,n) = __in__;
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
            foreach (var ix in new Range(0L, (qs.Length - 1L)))
#line hidden
            {
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
                if ((((1L << (int)ix) & n) != 0L))
                {
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/D1_Block_Diagonal/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qs[ix]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,n) = __in__;
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(0L, (qs.Length - 1L))))
#line hidden
            {
#line hidden
                if ((((1L << (int)ix) & n) != 0L))
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(qs[ix]);
                }
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

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, Int64 n)
        {
            return __m__.Run<XSome, (QArray<Qubit>,Int64), QVoid>((qs, n));
        }
    }
}