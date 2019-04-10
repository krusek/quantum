#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AssertPalindrome\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binary\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AssertPalindrome\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"QubitFromBinary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"binary\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"QubitFromBinary\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
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
        protected ICallable<(Int64,QArray<Int64>), QVoid> AssertPalindrome
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((4L, new QArray<Int64>(1L, 0L)));
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((4L, new QArray<Int64>(0L, 0L)));
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((4L, new QArray<Int64>(1L, 1L)));
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((4L, new QArray<Int64>(0L, 1L)));
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((5L, new QArray<Int64>(1L, 0L)));
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((5L, new QArray<Int64>(0L, 0L)));
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((5L, new QArray<Int64>(1L, 1L)));
#line 29 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((5L, new QArray<Int64>(0L, 1L)));
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((6L, new QArray<Int64>(1L, 0L, 0L)));
#line 31 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((6L, new QArray<Int64>(0L, 0L, 1L)));
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((6L, new QArray<Int64>(1L, 1L, 0L)));
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((6L, new QArray<Int64>(0L, 1L, 1L)));
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((7L, new QArray<Int64>(1L, 0L, 1L)));
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((7L, new QArray<Int64>(0L, 0L, 0L)));
#line 36 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((7L, new QArray<Int64>(1L, 1L, 0L)));
#line 37 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            AssertPalindrome.Apply((7L, new QArray<Int64>(0L, 1L, 1L)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertPalindrome = this.Factory.Get<ICallable<(Int64,QArray<Int64>), QVoid>>(typeof(AssertPalindrome));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class AssertPalindrome : Operation<(Int64,QArray<Int64>), QVoid>, ICallable
    {
        public AssertPalindrome(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Int64>)>, IApplyData
        {
            public In((Int64,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertPalindrome";
        String ICallable.FullName => "Solution.AssertPalindrome";
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

        protected ICallable<(QArray<Qubit>,QArray<Int64>), QVoid> QubitFromBinary
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> Solve
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (N,binary) = __in__;
#line hidden
            {
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                var qs = Allocate.Apply(N);
#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                if (((N % 2L) == 1L))
                {
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qs[(N / 2L)]);
                }

#line hidden
                {
#line 45 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    var a = Allocate.Apply();
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    QubitFromBinary.Apply((qs?.Copy(), binary?.Copy()));
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    Solve.Apply((qs?.Copy(), a));
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    MicrosoftQuantumPrimitiveX.Apply(a);
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(new QArray<Qubit>()
                    {a});
#line 50 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    ResetAll.Apply(qs?.Copy());
#line 51 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    QubitFromBinary.Apply((qs?.Copy(), binary?.Copy()));
#line 52 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    Solve.Apply((qs?.Copy(), a));
#line 53 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    MicrosoftQuantumPrimitiveX.Apply(a);
#line 54 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    MicrosoftQuantumExtensionsTestingAssertAllZero.Apply(new QArray<Qubit>()
                    {a});
#line 55 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                    ResetAll.Apply(qs?.Copy());
#line hidden
                    Release.Apply(a);
                }

#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                ResetAll.Apply(qs?.Copy());
#line hidden
                Release.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertAllZero = this.Factory.Get<IUnitary<QArray<Qubit>>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.QubitFromBinary = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>), QVoid>>(typeof(QubitFromBinary));
            this.Solve = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(Solve));
        }

        public override IApplyData __dataIn((Int64,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, QArray<Int64> binary)
        {
            return __m__.Run<AssertPalindrome, (Int64,QArray<Int64>), QVoid>((N, binary));
        }
    }

    public class QubitFromBinary : Operation<(QArray<Qubit>,QArray<Int64>), QVoid>, ICallable
    {
        public QubitFromBinary(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QubitFromBinary";
        String ICallable.FullName => "Solution.QubitFromBinary";
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
            var (qs,binary) = __in__;
#line 62 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            var mx = (qs.Length - 1L);
#line 63 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
            foreach (var ix in new Range(0L, (binary.Length - 1L)))
#line hidden
            {
#line 64 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[ix]);
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[(mx - ix)]);
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, QArray<Int64> binary)
        {
            return __m__.Run<QubitFromBinary, (QArray<Qubit>,QArray<Int64>), QVoid>((qs, binary));
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
#line 71 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
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
#line 75 "/Users/korbenrusek/Documents/code/quantum_winter_2019/G3_panindrome/Tests.qs"
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