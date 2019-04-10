#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xx\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xx\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":132,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":134,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":154,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":155,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":156,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":159,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":160,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyToEach\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs\",\"Position\":{\"Item1\":165,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve : Operation<Qubit, Int64>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumCanonMResetZ
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcCos
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRy
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 12 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var output = 0L;
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var alpha = MicrosoftQuantumExtensionsMathArcCos.Apply(MicrosoftQuantumExtensionsMathSqrt.Apply((2D / 3D)));
#line hidden
            {
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var a = Allocate.Apply();
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveZ.Apply(q);
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((a, q));
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Controlled.Apply((new QArray<Qubit>()
                {q}, a));
#line 18 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveS.Apply(a);
#line 19 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(q);
#line 20 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumPrimitiveRy)).Apply((new QArray<Qubit>()
                {a}, ((-(2D) * alpha), q)));
#line 21 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((a, q));
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Controlled.Apply((new QArray<Qubit>()
                {q}, a));
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((a, q));
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var res0 = MicrosoftQuantumCanonMResetZ.Apply(a);
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var res1 = M.Apply(q);
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                if (((res0 == Result.Zero) && (res1 == Result.Zero)))
                {
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    output = 0L;
                }
                else if (((res0 == Result.One) && (res1 == Result.Zero)))
                {
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    output = 1L;
                }
                else if (((res0 == Result.Zero) && (res1 == Result.One)))
                {
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    output = 2L;
                }
                else
                {
#line 39 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    output = 3L;
                }

#line hidden
                Release.Apply(a);
            }

#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.MicrosoftQuantumExtensionsMathArcCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.ArcCos));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Ry));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Solve, Qubit, Int64>(q);
        }
    }

    public class Solve4 : Operation<Qubit, Int64>, ICallable
    {
        public Solve4(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve4";
        String ICallable.FullName => "Solution.Solve4";
        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var xx = __in__;
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var x = new QArray<Qubit>()
            {xx};
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var sum = 0L;
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            MicrosoftQuantumPrimitiveRx.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 2D), xx));
#line 50 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumPrimitiveRx = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.Rx));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit xx)
        {
            return __m__.Run<Solve4, Qubit, Int64>(xx);
        }
    }

    public class Solve2 : Operation<Qubit, Int64>, ICallable
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

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var xx = __in__;
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 55 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var x = new QArray<Qubit>()
            {xx};
#line 56 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var sum = 0L;
#line hidden
            {
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var q = Allocate.Apply(2L);
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(q[1L]);
#line 59 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(q[0L]);
#line 60 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveR1.Apply(((2D * w), q[0L]));
#line 61 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveR1.Apply((-(w), x[0L]));
#line 62 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[0L], q[0L]));
#line 63 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((q[1L], q[0L]));
#line 64 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[0L]);
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(q[1L]);
#line 66 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                if ((M.Apply(q[1L]) == Result.One))
                {
#line 67 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    sum = (sum + 1L);
#line 68 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(q[1L]);
                }

#line 70 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                if ((M.Apply(x[0L]) == Result.One))
                {
#line 71 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    sum = (sum + 2L);
#line 72 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Apply(q[0L]);
                }

#line 74 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                ResetAll.Apply(q?.Copy());
#line hidden
                Release.Apply(q);
            }

#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit xx)
        {
            return __m__.Run<Solve2, Qubit, Int64>(xx);
        }
    }

    public class Solve3 : Operation<Qubit, Int64>, ICallable
    {
        public Solve3(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve3";
        String ICallable.FullName => "Solution.Solve3";
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

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var w = ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / 3D);
#line 82 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var sum = 0L;
#line hidden
            {
#line 83 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var p = Allocate.Apply(2L);
#line 84 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(p[0L]);
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveH.Apply(p[1L]);
#line hidden
                Release.Apply(p);
            }

#line 122 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Solve3, Qubit, Int64>(q);
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
#line 136 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            var N = qs.Length;
#line 138 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            if ((N == 1L))
            {
#line 140 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 145 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                var theta = MicrosoftQuantumExtensionsMathArcSin.Apply((1D / MicrosoftQuantumExtensionsMathSqrt.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N))));
#line 146 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveRy.Apply(((2D * theta), qs[0L]));
#line 149 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 150 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 151 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
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
#line 162 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
            foreach (var ix in new Range(0L, (x.Length - 1L)))
#line hidden
            {
#line 163 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/B2_NOT/Tasks.qs"
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