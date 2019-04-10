#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve1_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve1_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AssertDiv3\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"div\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AssertDiv3\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"MatchBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"MatchBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":106,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve3_Test";
        String ICallable.FullName => "Solution.Solve3_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> AssertDiv3
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 1L, 1L), new QArray<Int64>(0L, 0L, 0L)), true));
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 1L), new QArray<Int64>(1L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L), new QArray<Int64>(0L, 1L, 0L), new QArray<Int64>(1L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertDiv3 = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(AssertDiv3));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve2_Test";
        String ICallable.FullName => "Solution.Solve2_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> AssertDiv3
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 36 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>()
            {new QArray<Int64>(0L, 0L)}, true));
#line 39 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertDiv3 = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(AssertDiv3));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve1_Test";
        String ICallable.FullName => "Solution.Solve1_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> AssertDiv3
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>()
            {new QArray<Int64>()
            {0L}}, true));
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>()
            {new QArray<Int64>()
            {1L}}, false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertDiv3 = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(AssertDiv3));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve4_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve4_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve4_Test";
        String ICallable.FullName => "Solution.Solve4_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> AssertDiv3
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 1L), new QArray<Int64>(1L, 0L, 1L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 0L)), true));
#line 62 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            AssertDiv3.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertDiv3 = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(AssertDiv3));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve4_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class AssertDiv3 : Operation<(QArray<QArray<Int64>>,Boolean), QVoid>, ICallable
    {
        public AssertDiv3(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,Boolean)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertDiv3";
        String ICallable.FullName => "Solution.AssertDiv3";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<QArray<Qubit>> MicrosoftQuantumExtensionsTestingAssertAllZero
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
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

        protected ICallable<(QArray<Qubit>,QArray<Int64>), QVoid> MatchBits
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> Solve
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,Boolean), QVoid> Body => (__in__) =>
        {
            var (bits,div) = __in__;
#line 78 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            foreach (var bit in bits)
#line hidden
            {
#line 79 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                Message.Apply(String.Format("Trying bits: {0} with div: {1}", bit, div));
#line hidden
                {
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                    var x = Allocate.Apply(bit.Length);
#line hidden
                    {
#line 81 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        var y = Allocate.Apply(1L);
#line 82 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        MatchBits.Apply((x?.Copy(), bit?.Copy()));
#line 83 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        Solve.Apply((x?.Copy(), y[0L]));
#line 84 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        MatchBits.Apply((x?.Copy(), bit?.Copy()));
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        if (div)
                        {
#line 86 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
                        }

#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                        MicrosoftQuantumExtensionsTestingAssertAllZero.Apply((x + y));
#line hidden
                        Release.Apply(y);
                    }

#line hidden
                    Release.Apply(x);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MatchBits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>), QVoid>>(typeof(MatchBits));
            this.Solve = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(Solve));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<QArray<Int64>> bits, Boolean div)
        {
            return __m__.Run<AssertDiv3, (QArray<QArray<Int64>>,Boolean), QVoid>((bits, div));
        }
    }

    public class MatchBits : Operation<(QArray<Qubit>,QArray<Int64>), QVoid>, ICallable
    {
        public MatchBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "MatchBits";
        String ICallable.FullName => "Solution.MatchBits";
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

        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,bits) = __in__;
#line 96 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
            foreach (var ix in new Range(0L, (bits.Length - 1L)))
#line hidden
            {
#line 97 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                if ((bits[ix] != 0L))
                {
#line 98 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
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

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Int64> bits)
        {
            return __m__.Run<MatchBits, (QArray<Qubit>,QArray<Int64>), QVoid>((x, bits));
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
#line 105 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
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
#line 109 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C3_Divisible_3/Tests.qs"
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