#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve4_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve2_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve3_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve5_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve5_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve6_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve6_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve7_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve7_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve71_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":224,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve71_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":224,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Equal_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":230,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Equal_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":230,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AssertEqual\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":239,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"equal\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AssertEqual\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":239,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Assert\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":256,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"periodic\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Assert\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":256,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"MatchBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":275,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inv\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"MatchBits\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":275,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":287,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":287,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":289,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":289,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":291,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":291,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":293,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs\",\"Position\":{\"Item1\":293,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve4_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve4_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve4_Test";
        String ICallable.FullName => "Solution.Solve4_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 22 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 1L)), true));
#line 30 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve4_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve2_Test";
        String ICallable.FullName => "Solution.Solve2_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 40 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 1L), new QArray<Int64>(0L, 0L)), true));
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L), new QArray<Int64>(0L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve3_Test";
        String ICallable.FullName => "Solution.Solve3_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L)), true));
#line 51 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve5_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve5_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve5_Test";
        String ICallable.FullName => "Solution.Solve5_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L)), true));
#line 62 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve5_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve6_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve6_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve6_Test";
        String ICallable.FullName => "Solution.Solve6_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 69 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 0L)), true));
#line 77 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve6_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve7_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve7_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve7_Test";
        String ICallable.FullName => "Solution.Solve7_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 1L, 1L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 1L, 1L), new QArray<Int64>(0L, 0L, 0L, 1L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 1L, 0L, 1L, 1L), new QArray<Int64>(0L, 0L, 0L, 1L, 1L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 1L, 1L, 1L, 1L), new QArray<Int64>(0L, 0L, 1L, 0L, 0L, 1L, 1L), new QArray<Int64>(0L, 0L, 1L, 0L, 1L, 0L, 1L), new QArray<Int64>(0L, 0L, 1L, 0L, 1L, 1L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 1L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L, 1L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 0L, 0L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 0L, 1L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 1L, 0L, 1L, 1L), new QArray<Int64>(0L, 1L, 0L, 1L, 1L, 1L, 1L), new QArray<Int64>(0L, 1L, 1L, 0L, 1L, 1L, 1L), new QArray<Int64>(0L, 1L, 1L, 1L, 1L, 1L, 1L), new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 1L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 1L, 1L, 0L, 0L, 0L), new QArray<Int64>(1L, 0L, 1L, 1L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 1L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 1L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 0L, 1L, 0L, 0L, 0L), new QArray<Int64>(1L, 1L, 0L, 1L, 0L, 1L, 0L), new QArray<Int64>(1L, 1L, 0L, 1L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 0L, 0L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 1L, 1L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 0L, 1L, 1L, 0L), new QArray<Int64>(1L, 1L, 1L, 1L, 0L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 1L, 0L, 1L, 0L), new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 0L, 0L), new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 1L, 1L, 0L, 1L)), false));
#line 128 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L, 1L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 1L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L, 0L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L, 1L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 0L, 1L, 1L, 0L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 0L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L, 1L, 0L, 0L), new QArray<Int64>(0L, 0L, 1L, 1L, 1L, 1L, 0L), new QArray<Int64>(0L, 1L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 0L, 0L, 0L, 1L), new QArray<Int64>(0L, 1L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(0L, 1L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 0L, 1L, 0L, 1L), new QArray<Int64>(0L, 1L, 0L, 0L, 1L, 1L, 0L), new QArray<Int64>(0L, 1L, 0L, 1L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 1L, 0L, 0L, 1L), new QArray<Int64>(0L, 1L, 0L, 1L, 0L, 1L, 0L), new QArray<Int64>(0L, 1L, 0L, 1L, 1L, 0L, 0L), new QArray<Int64>(0L, 1L, 0L, 1L, 1L, 0L, 1L), new QArray<Int64>(0L, 1L, 0L, 1L, 1L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 0L, 0L, 0L, 1L), new QArray<Int64>(0L, 1L, 1L, 0L, 0L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L, 0L, 0L, 1L, 1L), new QArray<Int64>(0L, 1L, 1L, 0L, 1L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 0L, 1L, 0L, 1L), new QArray<Int64>(0L, 1L, 1L, 0L, 1L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 0L, 1L), new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 1L, 0L), new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 1L, 1L), new QArray<Int64>(0L, 1L, 1L, 1L, 1L, 0L, 0L), new QArray<Int64>(0L, 1L, 1L, 1L, 1L, 0L, 1L), new QArray<Int64>(0L, 1L, 1L, 1L, 1L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 0L, 1L), new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 1L, 1L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 0L, 1L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 0L, 1L, 1L, 1L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 0L, 1L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 0L, 1L, 1L), new QArray<Int64>(1L, 0L, 0L, 1L, 1L, 0L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 1L, 0L, 1L), new QArray<Int64>(1L, 0L, 0L, 1L, 1L, 1L, 0L), new QArray<Int64>(1L, 0L, 0L, 1L, 1L, 1L, 1L), new QArray<Int64>(1L, 0L, 1L, 0L, 0L, 0L, 1L), new QArray<Int64>(1L, 0L, 1L, 0L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 1L, 0L, 0L, 1L, 1L), new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L, 1L), new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 1L, 0L), new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 1L, 1L), new QArray<Int64>(1L, 0L, 1L, 1L, 0L, 0L, 1L), new QArray<Int64>(1L, 0L, 1L, 1L, 0L, 1L, 0L), new QArray<Int64>(1L, 0L, 1L, 1L, 0L, 1L, 1L), new QArray<Int64>(1L, 0L, 1L, 1L, 1L, 0L, 1L), new QArray<Int64>(1L, 0L, 1L, 1L, 1L, 1L, 0L), new QArray<Int64>(1L, 0L, 1L, 1L, 1L, 1L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L, 0L, 1L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 0L, 1L, 1L, 0L), new QArray<Int64>(1L, 1L, 0L, 0L, 1L, 1L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L, 0L, 1L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 0L, 1L, 1L, 1L, 0L), new QArray<Int64>(1L, 1L, 0L, 1L, 1L, 1L, 1L), new QArray<Int64>(1L, 1L, 1L, 0L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 0L, 0L, 1L, 1L), new QArray<Int64>(1L, 1L, 1L, 0L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 0L, 1L, 1L, 1L), new QArray<Int64>(1L, 1L, 1L, 1L, 0L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 1L, 0L, 1L, 1L), new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 0L, 1L), new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L, 1L)), true));
#line 218 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>(new QArray<Int64>(1L, 0L, 0L, 0L, 0L, 0L, 0L), new QArray<Int64>(0L, 0L, 0L, 0L, 0L, 1L, 1L), new QArray<Int64>(0L, 0L, 1L, 1L, 0L, 1L, 1L)), false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve7_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Solve71_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve71_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve71_Test";
        String ICallable.FullName => "Solution.Solve71_Test";
        protected ICallable<(QArray<QArray<Int64>>,Boolean), QVoid> Assert
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 226 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            Assert.Apply((new QArray<QArray<Int64>>()
            {new QArray<Int64>(0L, 0L, 0L, 0L, 1L, 0L, 0L)}, true));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Assert = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,Boolean), QVoid>>(typeof(Assert));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve71_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Equal_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Equal_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Equal_Test";
        String ICallable.FullName => "Solution.Equal_Test";
        protected ICallable<(QArray<Int64>,QArray<Int64>,Boolean), QVoid> AssertEqual
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 232 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            AssertEqual.Apply((new QArray<Int64>(1L, 1L), new QArray<Int64>(0L, 0L), false));
#line 235 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            AssertEqual.Apply((new QArray<Int64>()
            {1L}, new QArray<Int64>()
            {0L}, false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqual = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,Boolean), QVoid>>(typeof(AssertEqual));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Equal_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class AssertEqual : Operation<(QArray<Int64>,QArray<Int64>,Boolean), QVoid>, ICallable
    {
        public AssertEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>,Boolean)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertEqual";
        String ICallable.FullName => "Solution.AssertEqual";
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

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> Equal
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid> MatchBits
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>,Boolean), QVoid> Body => (__in__) =>
        {
            var (bits1,bits2,equal) = __in__;
#line hidden
            {
#line 241 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                var left = Allocate.Apply(bits1.Length);
#line hidden
                {
#line 242 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    var right = Allocate.Apply(bits1.Length);
#line 243 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    MatchBits.Apply((left?.Copy(), bits1?.Copy(), false));
#line 244 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    MatchBits.Apply((right?.Copy(), bits2?.Copy(), false));
#line hidden
                    {
#line 245 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                        var y = Allocate.Apply(1L);
#line 246 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                        Equal.Apply((left?.Copy(), right?.Copy(), y[0L]));
#line 247 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                        if (equal)
                        {
#line 248 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
                        }

#line hidden
                        Release.Apply(y);
                    }

#line 251 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    MatchBits.Apply((left?.Copy(), bits1?.Copy(), false));
#line 252 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    MatchBits.Apply((right?.Copy(), bits2?.Copy(), false));
#line hidden
                    Release.Apply(right);
                }

#line hidden
                Release.Apply(left);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Equal = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(Equal));
            this.MatchBits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid>>(typeof(MatchBits));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> bits1, QArray<Int64> bits2, Boolean equal)
        {
            return __m__.Run<AssertEqual, (QArray<Int64>,QArray<Int64>,Boolean), QVoid>((bits1, bits2, equal));
        }
    }

    public class Assert : Operation<(QArray<QArray<Int64>>,Boolean), QVoid>, ICallable
    {
        public Assert(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,Boolean)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Assert";
        String ICallable.FullName => "Solution.Assert";
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

        protected ICallable<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid> MatchBits
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
            var (bits,periodic) = __in__;
#line 258 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            foreach (var bit in bits)
#line hidden
            {
#line 259 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                Message.Apply(String.Format("try {0} expect: {1}", bit, periodic));
#line 260 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                foreach (var inv in new QArray<Boolean>(true, false))
#line hidden
                {
#line hidden
                    {
#line 261 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                        var x = Allocate.Apply(bit.Length);
#line hidden
                        {
#line 262 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            var y = Allocate.Apply(1L);
#line 263 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            MatchBits.Apply((x?.Copy(), bit?.Copy(), inv));
#line 264 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            Solve.Apply((x?.Copy(), y[0L]));
#line 265 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            MatchBits.Apply((x?.Copy(), bit?.Copy(), inv));
#line 266 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            if (periodic)
                            {
#line 267 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                                MicrosoftQuantumPrimitiveX.Apply(y[0L]);
                            }

#line 269 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                            MicrosoftQuantumExtensionsTestingAssertAllZero.Apply((x + y));
#line hidden
                            Release.Apply(y);
                        }

#line hidden
                        Release.Apply(x);
                    }
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
            this.MatchBits = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid>>(typeof(MatchBits));
            this.Solve = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(Solve));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<QArray<Int64>> bits, Boolean periodic)
        {
            return __m__.Run<Assert, (QArray<QArray<Int64>>,Boolean), QVoid>((bits, periodic));
        }
    }

    public class MatchBits : Operation<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid>, ICallable
    {
        public MatchBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,Boolean)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,Boolean) data) : base(data)
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

        public override Func<(QArray<Qubit>,QArray<Int64>,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,bits,inv) = __in__;
#line 277 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
            foreach (var ix in new Range(0L, (bits.Length - 1L)))
#line hidden
            {
#line 278 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                if ((!(inv) && (bits[ix] != 0L)))
                {
#line 279 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
                    MicrosoftQuantumPrimitiveX.Apply(x[ix]);
                }
                else if ((inv && (bits[ix] == 0L)))
                {
#line 281 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
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

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Int64> bits, Boolean inv)
        {
            return __m__.Run<MatchBits, (QArray<Qubit>,QArray<Int64>,Boolean), QVoid>((x, bits, inv));
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
#line 288 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
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
#line 292 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tests.qs"
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