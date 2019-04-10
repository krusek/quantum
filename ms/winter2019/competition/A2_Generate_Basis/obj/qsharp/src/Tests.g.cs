#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Measurements\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Measurements\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
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
        protected Allocate Allocate
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

        protected ICallable<(QArray<Qubit>,QArray<QArray<Boolean>>), QVoid> Solve
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
            var count = new QArray<Int64>(0L, 0L, 0L, 0L);
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
            foreach (var ix in new Range(0L, 100L))
#line hidden
            {
#line hidden
                {
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
                    var q = Allocate.Apply(4L);
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
                    Solve.Apply((q?.Copy(), new QArray<QArray<Boolean>>(new QArray<Boolean>(true, false, false, false), new QArray<Boolean>(false, true, false, false), new QArray<Boolean>(false, false, true, false), new QArray<Boolean>(false, false, false, true))));
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
                    ResetAll.Apply(q?.Copy());
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
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Solve = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<QArray<Boolean>>), QVoid>>(typeof(Solve));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Measurements : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Measurements(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Measurements";
        String ICallable.FullName => "Solution.Measurements";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in__) =>
        {
            var x = __in__;
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
            var m = -(1L);
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
            foreach (var ix in new Range(0L, 3L))
#line hidden
            {
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
                if ((M.Apply(x[ix]) == Result.One))
                {
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
                    m = ix;
                }
            }

#line 38 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
            return m;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> x)
        {
            return __m__.Run<Measurements, QArray<Qubit>, Int64>(x);
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
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
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
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/A2_Generate_Basis/Tests.qs"
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