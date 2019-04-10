#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_PowerOfTwo\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Next_Power\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Next_Power\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":126,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":126,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":128,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":128,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve_Test";
        String ICallable.FullName => "Solution.Solve_Test";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
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

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, Int64> Solve
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> WState_Arbitrary
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            foreach (var omega in new QArray<Int64>(0L, 1L))
#line hidden
            {
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                var counts = new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 0L, 0L, 0L, 0L);
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                foreach (var __arg1__ in new Range(0L, 200L))
#line hidden
                {
#line hidden
                    {
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        var q = Allocate.Apply(3L);
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        WState_Arbitrary.Apply(q?.Copy());
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[2L]);
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveCCNOT.Apply((q[1L], q[2L], q[0L]));
#line 31 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[1L]);
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q[2L]);
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        if ((omega == 0L))
                        {
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                            MicrosoftQuantumPrimitiveR1.Apply((w, q[1L]));
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                            MicrosoftQuantumPrimitiveR1.Apply(((2D * w), q[2L]));
                        }
                        else
                        {
#line 37 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                            MicrosoftQuantumPrimitiveR1.Apply((w, q[2L]));
#line 38 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                            MicrosoftQuantumPrimitiveR1.Apply(((2D * w), q[1L]));
                        }

#line 40 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        var c = Solve.Apply(q?.Copy());
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        counts[c] = (counts[c] + 1L);
#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        ResetAll.Apply(q?.Copy());
#line hidden
                        Release.Apply(q);
                    }
                }

#line 45 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                Message.Apply(String.Format("for: {0} got: {1}", omega, counts));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Solve = this.Factory.Get<ICallable<QArray<Qubit>, Int64>>(typeof(Solve));
            this.WState_Arbitrary = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(WState_Arbitrary));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve_Test, QVoid, QVoid>(QVoid.Instance);
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
#line 59 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            var L = qs.Length;
#line 60 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            if ((L == 1L))
            {
#line 61 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 63 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                var P = (L / 2L);
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                self.Apply(qs?.Slice(new Range(0L, (P - 1L))));
#line hidden
                {
#line 68 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    var q = Allocate.Apply(1L);
#line 69 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    MicrosoftQuantumPrimitiveH.Apply(q[0L]);
#line 71 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    foreach (var ix in new Range(0L, (P - 1L)))
#line hidden
                    {
#line 72 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((q?.Copy(), (qs[ix], qs[(ix + P)])));
                    }

#line 74 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    foreach (var ix in new Range(0L, (P - 1L)))
#line hidden
                    {
#line 75 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
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
#line 90 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            var N = qs.Length;
#line 91 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            var P = Next_Power.Apply(N);
#line 92 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            if ((N == P))
            {
#line 93 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                WState_PowerOfTwo.Apply(qs?.Copy());
            }
            else
            {
#line hidden
                {
#line 95 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    var q = Allocate.Apply((P - N));
#line 96 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    var bits = (qs + q);
#line 97 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                    while (true)
                    {
#line 98 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        WState_PowerOfTwo.Apply(bits?.Copy());
#line 99 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        var good = true;
#line 100 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                        foreach (var ix in new Range(0L, ((P - N) - 1L)))
#line hidden
                        {
#line 101 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                            good = ((M.Apply(q[ix]) == Result.Zero) && good);
                        }

                        if (good)
                        {
                            break;
                        }
                        else
                        {
#line 105 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
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
#line 112 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            var n = 1L;
#line 113 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            if ((n == N))
            {
#line 114 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                return n;
            }

#line 116 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            while (true)
            {
#line 117 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
                n = (n * 2L);
                if ((n >= N))
                {
                    break;
                }
                else
                {
                }
            }

#line 120 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
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

    public class GetOracleCallsCount<__T__> : Function<__T__, Int64>, ICallable
    {
        public GetOracleCallsCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetOracleCallsCount";
        String ICallable.FullName => "Solution.GetOracleCallsCount";
        public override Func<__T__, Int64> Body => (__in__) =>
        {
            var oracle = __in__;
#line 125 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(__T__ data) => new QTuple<__T__>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, __T__ oracle)
        {
            return __m__.Run<GetOracleCallsCount<__T__>, __T__, Int64>(oracle);
        }
    }

    public class ResetOracleCallsCount : Function<QVoid, QVoid>, ICallable
    {
        public ResetOracleCallsCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResetOracleCallsCount";
        String ICallable.FullName => "Solution.ResetOracleCallsCount";
        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<ResetOracleCallsCount, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class GetMaxQubitCount : Function<QVoid, Int64>, ICallable
    {
        public GetMaxQubitCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetMaxQubitCount";
        String ICallable.FullName => "Solution.GetMaxQubitCount";
        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 129 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B1_Distinguish/Tests.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetMaxQubitCount, QVoid, Int64>(QVoid.Instance);
        }
    }

    public class ResetQubitCount : Function<QVoid, QVoid>, ICallable
    {
        public ResetQubitCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResetQubitCount";
        String ICallable.FullName => "Solution.ResetQubitCount";
        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<ResetQubitCount, QVoid, QVoid>(QVoid.Instance);
        }
    }
}