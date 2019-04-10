#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_Test\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AssertOperationMatrixMatchesPattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":41,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"Function\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[]]},{\"Case\":\"Function\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AssertOperationMatrixMatchesPattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":41,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"MainDiagonal_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"MainDiagonal_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AllNonZero_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":92,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AllNonZero_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":92,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Quarters_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Quarters_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"EvenChessPattern_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":107,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"EvenChessPattern_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":107,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"OddChessPattern_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"size\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"col\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"OddChessPattern_Pattern\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":125,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":125,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":127,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":127,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs\",\"Position\":{\"Item1\":131,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public Solve_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Solve_Pattern";
        String ICallable.FullName => "Solution.Solve_Pattern";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 23 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            var r = (row / 4L);
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            var c = (col / 4L);
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            var val = ((c - (c % 2L)) == (r - (r % 2L)));
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            Message.Apply(String.Format("row: {0}, col: {1}, size: {2}, val: {3}", row, col, size, val));
#line 27 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            Message.Apply(String.Format("mrow: {0}, mcol: {1}, size: {2}, val: {3}", (row - (row % 2L)), (col - (col % 2L)), size, val));
#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return val;
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<Solve_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
        }
    }

    public class Solve_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Solve_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve_Test";
        String ICallable.FullName => "Solution.Solve_Test";
        protected ICallable<(Int64,ICallable,ICallable), QVoid> AssertOperationMatrixMatchesPattern
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> Solve
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Boolean> Solve_Pattern
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 32 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            foreach (var n in new Range(2L, 5L))
#line hidden
            {
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                AssertOperationMatrixMatchesPattern.Apply((n, Solve, Solve_Pattern));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertOperationMatrixMatchesPattern = this.Factory.Get<ICallable<(Int64,ICallable,ICallable), QVoid>>(typeof(AssertOperationMatrixMatchesPattern));
            this.Solve = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(Solve));
            this.Solve_Pattern = this.Factory.Get<ICallable<(Int64,Int64,Int64), Boolean>>(typeof(Solve_Pattern));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Solve_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class AssertOperationMatrixMatchesPattern : Operation<(Int64,ICallable,ICallable), QVoid>, ICallable
    {
        public AssertOperationMatrixMatchesPattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,ICallable)>, IApplyData
        {
            public In((Int64,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertOperationMatrixMatchesPattern";
        String ICallable.FullName => "Solution.AssertOperationMatrixMatchesPattern";
        protected IUnitary<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)> MicrosoftQuantumCanonApplyPauliFromBitString
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Double,Microsoft.Quantum.Canon.LittleEndian,Double), QVoid> MicrosoftQuantumCanonAssertProbInt
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> MicrosoftQuantumCanonBoolArrFromPositiveInt
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

        protected ICallable<(QArray<Pauli>,QArray<Qubit>), Result> Measure
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

        protected ICallable GetOracleCallsCount
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> ResetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (N,op,pattern) = __in__;
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            var size = (1L << (int)N);
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            var ε = 1E-06D;
#line hidden
            {
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                var qs = Allocate.Apply(N);
#line 49 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                foreach (var k in new Range(0L, (size - 1L)))
#line hidden
                {
#line 51 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    var binary = MicrosoftQuantumCanonBoolArrFromPositiveInt.Apply((k, N));
#line 55 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    MicrosoftQuantumCanonApplyPauliFromBitString.Apply((Pauli.PauliX, true, binary?.Copy(), qs?.Copy()));
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    ResetOracleCallsCount.Apply(QVoid.Instance);
#line 61 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    op.Apply(qs?.Copy());
#line 64 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    MicrosoftQuantumCanonAssertIntEqual.Apply((GetOracleCallsCount.Apply<Int64>(M), 0L, "You are not allowed to use measurements in this task"));
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    MicrosoftQuantumCanonAssertIntEqual.Apply((GetOracleCallsCount.Apply<Int64>(Measure), 0L, "You are not allowed to use measurements in this task"));
#line 69 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    foreach (var j in new Range(0L, (size - 1L)))
#line hidden
                    {
#line 70 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                        var nonZero = pattern.Apply<Boolean>((size, j, k));
#line 72 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                        if (nonZero)
                        {
#line 73 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                            MicrosoftQuantumCanonAssertProbInt.Apply((j, (0.5D + ε), new Microsoft.Quantum.Canon.LittleEndian(qs?.Copy()), 0.5D));
                        }
                        else
                        {
#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                            MicrosoftQuantumCanonAssertProbInt.Apply((j, 0D, new Microsoft.Quantum.Canon.LittleEndian(qs?.Copy()), ε));
                        }
                    }

#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
                    ResetAll.Apply(qs?.Copy());
                }

#line hidden
                Release.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyPauliFromBitString = this.Factory.Get<IUnitary<(Pauli,Boolean,QArray<Boolean>,QArray<Qubit>)>>(typeof(Microsoft.Quantum.Canon.ApplyPauliFromBitString));
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumCanonAssertProbInt = this.Factory.Get<ICallable<(Int64,Double,Microsoft.Quantum.Canon.LittleEndian,Double), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertProbInt));
            this.MicrosoftQuantumCanonBoolArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromPositiveInt));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Measure = this.Factory.Get<ICallable<(QArray<Pauli>,QArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Primitive.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GetOracleCallsCount = this.Factory.Get<ICallable>(typeof(GetOracleCallsCount<>));
            this.ResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(ResetOracleCallsCount));
        }

        public override IApplyData __dataIn((Int64,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable op, ICallable pattern)
        {
            return __m__.Run<AssertOperationMatrixMatchesPattern, (Int64,ICallable,ICallable), QVoid>((N, op, pattern));
        }
    }

    public class MainDiagonal_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public MainDiagonal_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MainDiagonal_Pattern";
        String ICallable.FullName => "Solution.MainDiagonal_Pattern";
        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return (row == col);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<MainDiagonal_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
        }
    }

    public class AllNonZero_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public AllNonZero_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AllNonZero_Pattern";
        String ICallable.FullName => "Solution.AllNonZero_Pattern";
        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 94 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return true;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<AllNonZero_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
        }
    }

    public class Quarters_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public Quarters_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Quarters_Pattern";
        String ICallable.FullName => "Solution.Quarters_Pattern";
        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 103 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return ((row / (size / 2L)) == (col / (size / 2L)));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<Quarters_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
        }
    }

    public class EvenChessPattern_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public EvenChessPattern_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "EvenChessPattern_Pattern";
        String ICallable.FullName => "Solution.EvenChessPattern_Pattern";
        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 112 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return ((row % 2L) == (col % 2L));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<EvenChessPattern_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
        }
    }

    public class OddChessPattern_Pattern : Function<(Int64,Int64,Int64), Boolean>, ICallable
    {
        public OddChessPattern_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "OddChessPattern_Pattern";
        String ICallable.FullName => "Solution.OddChessPattern_Pattern";
        public override Func<(Int64,Int64,Int64), Boolean> Body => (__in__) =>
        {
            var (size,row,col) = __in__;
#line 121 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
            return ((row % 2L) != (col % 2L));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 size, Int64 row, Int64 col)
        {
            return __m__.Run<OddChessPattern_Pattern, (Int64,Int64,Int64), Boolean>((size, row, col));
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
#line 126 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
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
#line 130 "/Users/korbenrusek/Documents/code/quantum_winter_2019/warmup/U2_chessboard/Tests.qs"
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