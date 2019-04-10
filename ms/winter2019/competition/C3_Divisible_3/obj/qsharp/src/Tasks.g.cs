#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":11,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":35,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddOne\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":42,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AddTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AddTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":53,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":58,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs\",\"Position\":{\"Item1\":63,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        protected IAdjointable<(Qubit,QArray<Qubit>)> AddOne
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,QArray<Qubit>)> AddTwo
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,QArray<Qubit>)> ApplyToEach
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            if ((x.Length >= 3L))
            {
#line hidden
                {
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    var q = Allocate.Apply(4L);
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(q[2L]);
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    var L = x.Length;
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    foreach (var ix in new Range(0L, (L - 1L)))
#line hidden
                    {
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                        AddOne.Apply((x[ix], q?.Copy()));
                    }

#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((q[2L], y));
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    foreach (var ix in new Range(0L, (L - 1L)))
#line hidden
                    {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                        AddTwo.Apply((x[ix], q?.Copy()));
                    }

#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(q[2L]);
#line hidden
                    Release.Apply(q);
                }
            }
            else
            {
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), y));
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            if ((x.Length >= 3L))
            {
#line hidden
                {
#line hidden
                    var q = Allocate.Apply(4L);
#line hidden
                    var L = x.Length;
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(q[2L]);
#line hidden
                    foreach (var ix in RangeReverse.Apply(new Range(0L, (L - 1L))))
#line hidden
                    {
#line hidden
                        AddTwo.Adjoint.Apply((x[ix], q?.Copy()));
                    }

#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((q[2L], y));
#line hidden
                    foreach (var ix in RangeReverse.Apply(new Range(0L, (L - 1L))))
#line hidden
                    {
#line hidden
                        AddOne.Adjoint.Apply((x[ix], q?.Copy()));
                    }

#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(q[2L]);
#line hidden
                    Release.Apply(q);
                }
            }
            else
            {
#line hidden
                ApplyToEach.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((x?.Copy(), y));
#line hidden
                ApplyToEach.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
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
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.AddOne = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(AddOne));
            this.AddTwo = this.Factory.Get<IAdjointable<(Qubit,QArray<Qubit>)>>(typeof(AddTwo));
            this.ApplyToEach = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ApplyToEach));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class AddOne : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public AddOne(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AddOne";
        String ICallable.FullName => "Solution.AddOne";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,q) = __in__;
#line 37 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[2L], q[3L])));
#line 38 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[1L], q[2L])));
#line 39 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[0L], q[1L])));
#line 40 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[3L], q[0L])));
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((a, q[0L], q[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (a,q) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((a, q[0L], q[3L]));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[3L], q[0L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[0L], q[1L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[1L], q[2L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[2L], q[3L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit a, QArray<Qubit> q)
        {
            return __m__.Run<AddOne, (Qubit,QArray<Qubit>), QVoid>((a, q));
        }
    }

    public class AddTwo : Adjointable<(Qubit,QArray<Qubit>)>, ICallable
    {
        public AddTwo(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,QArray<Qubit>)>, IApplyData
        {
            public In((Qubit,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AddTwo";
        String ICallable.FullName => "Solution.AddTwo";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<(Qubit,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,q) = __in__;
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((a, q[0L], q[3L]));
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[3L], q[0L])));
#line 50 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[0L], q[1L])));
#line 51 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[1L], q[2L])));
#line 52 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
            {a}, (q[2L], q[3L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (a,q) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[2L], q[3L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[1L], q[2L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[0L], q[1L])));
#line hidden
            MicrosoftQuantumPrimitiveSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>()
            {a}, (q[3L], q[0L])));
#line hidden
            MicrosoftQuantumPrimitiveCCNOT.Adjoint.Apply((a, q[0L], q[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn((Qubit,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit a, QArray<Qubit> q)
        {
            return __m__.Run<AddTwo, (Qubit,QArray<Qubit>), QVoid>((a, q));
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
#line 60 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 61 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tasks.qs"
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