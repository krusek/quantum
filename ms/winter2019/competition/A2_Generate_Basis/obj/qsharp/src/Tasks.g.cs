#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"SetBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"SetBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"SetBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs\",\"Position\":{\"Item1\":78,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Operation<(QArray<Qubit>,QArray<QArray<Boolean>>), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<QArray<Boolean>>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<QArray<Boolean>>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected Allocate Allocate
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

        protected IControllable<(QArray<Qubit>,QArray<Boolean>)> SetBits
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<QArray<Boolean>>), QVoid> Body => (__in__) =>
        {
            var (x,bits) = __in__;
#line hidden
            {
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                var q = Allocate.Apply(2L);
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(q[0L]);
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(q[1L]);
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Controlled.Apply((q?.Copy(), (x?.Copy(), bits[0L])));
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[0L]);
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Controlled.Apply((q?.Copy(), (x?.Copy(), bits[1L])));
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[0L]);
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Controlled.Apply((q?.Copy(), (x?.Copy(), bits[2L])));
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[0L]);
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Controlled.Apply((q?.Copy(), (x?.Copy(), bits[3L])));
#line 36 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[0L]);
#line 37 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 38 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, q?.Copy()));
#line 40 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[1L]));
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), q[0L]));
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 44 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[1L]));
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[3L]));
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), q[0L]));
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), q[1L]));
#line 50 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 51 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[3L]));
#line 53 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[2L]));
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 55 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), q[1L]));
#line 56 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                ApplyToEach.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                SetBits.Apply((x?.Copy(), bits[2L]));
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
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.ApplyToEach = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(ApplyToEach));
            this.SetBits = this.Factory.Get<IControllable<(QArray<Qubit>,QArray<Boolean>)>>(typeof(SetBits));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<QArray<Boolean>>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<QArray<Boolean>> bits)
        {
            return __m__.Run<Solve, (QArray<Qubit>,QArray<QArray<Boolean>>), QVoid>((x, bits));
        }
    }

    public class SetBits : Controllable<(QArray<Qubit>,QArray<Boolean>)>, ICallable
    {
        public SetBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "SetBits";
        String ICallable.FullName => "Solution.SetBits";
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

        public override Func<(QArray<Qubit>,QArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (x,bits) = __in__;
#line 63 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
            foreach (var ix in new Range(0L, (bits.Length - 1L)))
#line hidden
            {
#line 64 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                if (bits[ix])
                {
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Boolean>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,bits)) = __in__;
#line hidden
            foreach (var ix in new Range(0L, (bits.Length - 1L)))
#line hidden
            {
#line hidden
                if (bits[ix])
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), x[ix]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Boolean> bits)
        {
            return __m__.Run<SetBits, (QArray<Qubit>,QArray<Boolean>), QVoid>((x, bits));
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
#line 75 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tasks.qs"
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