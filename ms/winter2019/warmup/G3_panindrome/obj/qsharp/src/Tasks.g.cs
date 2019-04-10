#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":11,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":34,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":39,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
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

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
            var s2 = (x.Length / 2L);
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
            var mx = (x.Length - 1L);
#line hidden
            {
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                var a = Allocate.Apply(s2);
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                foreach (var ix in new Range(0L, (s2 - 1L)))
#line hidden
                {
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[ix], x[(mx - ix)], a[ix]));
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
#line 19 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[(mx - ix)]);
#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[ix], x[(mx - ix)], a[ix]));
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[(mx - ix)]);
                }

#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((a?.Copy(), y));
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                foreach (var ix in new Range(0L, (s2 - 1L)))
#line hidden
                {
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[ix], x[(mx - ix)], a[ix]));
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[(mx - ix)]);
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveCCNOT.Apply((x[ix], x[(mx - ix)], a[ix]));
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
#line 31 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[(mx - ix)]);
                }

#line hidden
                Release.Apply(a);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var s2 = (x.Length / 2L);
#line hidden
            var mx = (x.Length - 1L);
#line hidden
            {
#line hidden
                var a = Allocate.Apply(s2);
#line hidden
                foreach (var ix in RangeReverse.Apply(new Range(0L, (s2 - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(mx - ix)]);
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[ix]);
#line hidden
                    MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((x[ix], x[(mx - ix)], a[ix]));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(mx - ix)]);
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[ix]);
#line hidden
                    MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((x[ix], x[(mx - ix)], a[ix]));
                }

#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((a?.Copy(), y));
#line hidden
                foreach (var ix in RangeReverse.Apply(new Range(0L, (s2 - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(mx - ix)]);
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[ix]);
#line hidden
                    MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((x[ix], x[(mx - ix)], a[ix]));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[(mx - ix)]);
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(x[ix]);
#line hidden
                    MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((x[ix], x[(mx - ix)], a[ix]));
                }

#line hidden
                Release.Apply(a);
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
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Qubit), QVoid>((x, y));
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
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tasks.qs"
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