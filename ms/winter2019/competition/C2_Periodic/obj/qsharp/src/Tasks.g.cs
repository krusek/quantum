#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_old\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_old\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":11,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_old\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":19,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Sum\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":13}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controls\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":23}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Sum\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":13}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Equal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"left\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"right\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Equal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":31,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Equal\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":51,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":68,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_new\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_new\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"Solve_new\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":113,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"CheckPeriods\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ps\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"CheckPeriods\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":117,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"CheckPeriods\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":126,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"AlreadyChecked\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ix\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"print\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"AlreadyChecked\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"OrOracle\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"OrOracle\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":141,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"OrOracle\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":148,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"OrOracle\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":147,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"OrOracle\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":149,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"IsPeriodic\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":152,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"IsPeriodic\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":153,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"IsPeriodic\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":161,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":164,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":164,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"UseBigger\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":174,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"UseBigger\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":174,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetSmallerControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetSmallerControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetControlsLength\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":198,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetControlsLength\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":198,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"GetBiggerControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":207,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"GetBiggerControls\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":207,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyPeriod\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"cp\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyPeriod\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":220,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Solution\",\"Name\":\"ApplyPeriod\"},\"SourceFile\":\"/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs\",\"Position\":{\"Item1\":235,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Solution
{
    public class Solve_old : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public Solve_old(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Solve_old";
        String ICallable.FullName => "Solution.Solve_old";
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

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Int64)> CheckPeriods
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> OrOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 13 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = x.Length;
#line hidden
            {
#line 14 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var ps = Allocate.Apply((N - 1L));
#line 15 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                CheckPeriods.Apply((x?.Copy(), ps?.Copy(), N));
#line 16 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                OrOracle.Apply((ps?.Copy(), y));
#line 17 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                CheckPeriods.Adjoint.Apply((x?.Copy(), ps?.Copy(), N));
#line hidden
                Release.Apply(ps);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var N = x.Length;
#line hidden
            {
#line hidden
                var ps = Allocate.Apply((N - 1L));
#line hidden
                CheckPeriods.Adjoint.Adjoint.Apply((x?.Copy(), ps?.Copy(), N));
#line hidden
                OrOracle.Adjoint.Apply((ps?.Copy(), y));
#line hidden
                CheckPeriods.Adjoint.Apply((x?.Copy(), ps?.Copy(), N));
#line hidden
                Release.Apply(ps);
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
            this.CheckPeriods = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Int64)>>(typeof(CheckPeriods));
            this.OrOracle = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(OrOracle));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve_old, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Sum : Function<QArray<QArray<QArray<Qubit>>>, Int64>, ICallable
    {
        public Sum(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Sum";
        String ICallable.FullName => "Solution.Sum";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<QArray<QArray<QArray<Qubit>>>, Int64> Body => (__in__) =>
        {
            var controls = __in__;
#line 24 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var sum = 0L;
#line 25 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var control in controls)
#line hidden
            {
#line 26 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                sum = (sum + control.Length);
            }

#line 28 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            return sum;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(QArray<QArray<QArray<Qubit>>> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<QArray<QArray<Qubit>>> controls)
        {
            return __m__.Run<Sum, QArray<QArray<QArray<Qubit>>>, Int64>(controls);
        }
    }

    public class Equal : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public Equal(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Equal";
        String ICallable.FullName => "Solution.Equal";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

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

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> self
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (left,right,y) = __in__;
#line 33 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = left.Length;
#line 34 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            if ((N == 1L))
            {
#line 35 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var all = (left + right);
#line 36 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((all?.Copy(), y));
#line 37 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, all?.Copy()));
#line 38 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((all?.Copy(), y));
#line 39 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, all?.Copy()));
            }
            else
            {
#line 41 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var half = (N / 2L);
#line hidden
                {
#line 42 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    var q = Allocate.Apply(2L);
#line 43 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    self.Apply((left?.Slice(new Range(0L, (half - 1L))), right?.Slice(new Range(0L, (half - 1L))), q[0L]));
#line 44 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    self.Apply((left?.Slice(new Range(half, (N - 1L))), right?.Slice(new Range(half, (N - 1L))), q[1L]));
#line 46 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    MicrosoftQuantumPrimitiveX.Controlled.Apply((q?.Copy(), y));
#line 47 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    self.Apply((left?.Slice(new Range(0L, (half - 1L))), right?.Slice(new Range(0L, (half - 1L))), q[0L]));
#line 48 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    self.Apply((left?.Slice(new Range(half, (N - 1L))), right?.Slice(new Range(half, (N - 1L))), q[1L]));
#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.self = this;
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> left, QArray<Qubit> right, Qubit y)
        {
            return __m__.Run<Equal, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((left, right, y));
        }
    }

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

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> Equal
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> OrOracle
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 57 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = x.Length;
#line hidden
            {
#line 58 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var periods = Allocate.Apply((N / 2L));
#line 59 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                foreach (var p in new Range(0L, ((N / 2L) - 1L)))
#line hidden
                {
#line 61 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    Equal.Apply((x?.Slice(new Range(0L, p)), x?.Slice(new Range(((N - p) - 1L), (N - 1L))), periods[p]));
                }

#line 63 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                OrOracle.Apply((periods?.Copy(), y));
#line 64 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                foreach (var p in new Range(0L, ((N / 2L) - 1L)))
#line hidden
                {
#line 65 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    Equal.Apply((x?.Slice(new Range(0L, p)), x?.Slice(new Range(((N - p) - 1L), (N - 1L))), periods[p]));
                }

#line hidden
                Release.Apply(periods);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Equal = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(Equal));
            this.OrOracle = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(OrOracle));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Solve_new : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public Solve_new(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Solve_new";
        String ICallable.FullName => "Solution.Solve_new";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable<Range, QArray<Int64>> MicrosoftQuantumCanonIntArrayFromRange
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonMap
        {
            get;
            set;
        }

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

        protected ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> GetControls
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,Qubit)> OrOracle
        {
            get;
            set;
        }

        protected ICallable<QArray<QArray<QArray<Qubit>>>, Int64> Sum
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 74 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = x.Length;
#line hidden
            {
#line 75 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var periods = Allocate.Apply((N - 1L));
#line 76 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var AllControls = MicrosoftQuantumCanonMap.Apply<QArray<QArray<QArray<Qubit>>>>((GetControls.Partial(new Func<Int64, (QArray<Qubit>,Int64)>((__arg1__) => (x?.Copy(), __arg1__))), MicrosoftQuantumCanonIntArrayFromRange.Apply(new Range(1L, (N - 1L)))));
#line 77 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var controlsLength = Sum.Apply(AllControls);
#line hidden
                {
#line 79 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    var bigcontrols = Allocate.Apply(controlsLength);
#line 80 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    var start = 0L;
#line 81 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    foreach (var p in new Range(1L, (N - 1L)))
#line hidden
                    {
#line 83 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        var controls = AllControls[(p - 1L)];
#line 84 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        var qc = bigcontrols?.Slice(new Range(start, ((start + controls.Length) - 1L)));
#line 85 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        foreach (var ix in new Range(0L, (controls.Length - 1L)))
#line hidden
                        {
#line 86 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            var cnt = controls[ix];
#line 87 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), qc[ix]));
#line 88 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
#line 89 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), qc[ix]));
#line 90 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
                        }

#line 92 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((qc?.Copy(), periods[(p - 1L)]));
#line 93 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        start = (start + controls.Length);
                    }

#line 95 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    OrOracle.Apply((periods?.Copy(), y));
#line 96 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    start = 0L;
#line 97 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    foreach (var p in new Range(1L, (N - 1L)))
#line hidden
                    {
#line 98 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        var controls = AllControls[(p - 1L)];
#line 99 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        var qc = bigcontrols?.Slice(new Range(start, ((start + controls.Length) - 1L)));
#line 100 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((qc?.Copy(), periods[(p - 1L)]));
#line 101 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        foreach (var ix in new Range(0L, (controls.Length - 1L)))
#line hidden
                        {
#line 102 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            var cnt = controls[ix];
#line 103 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), qc[ix]));
#line 104 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
#line 105 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), qc[ix]));
#line 106 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
                        }

#line 108 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        MicrosoftQuantumPrimitiveX.Controlled.Apply((qc?.Copy(), periods[(p - 1L)]));
#line 109 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        start = (start + controls.Length);
                    }

#line hidden
                    Release.Apply(bigcontrols);
                }

#line hidden
                Release.Apply(periods);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonIntArrayFromRange = this.Factory.Get<ICallable<Range, QArray<Int64>>>(typeof(Microsoft.Quantum.Canon.IntArrayFromRange));
            this.MicrosoftQuantumCanonMap = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Map<,>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.GetControls = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>>(typeof(GetControls));
            this.OrOracle = this.Factory.Get<IUnitary<(QArray<Qubit>,Qubit)>>(typeof(OrOracle));
            this.Sum = this.Factory.Get<ICallable<QArray<QArray<QArray<Qubit>>>, Int64>>(typeof(Sum));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve_new, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class CheckPeriods : Adjointable<(QArray<Qubit>,QArray<Qubit>,Int64)>, ICallable
    {
        public CheckPeriods(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CheckPeriods";
        String ICallable.FullName => "Solution.CheckPeriods";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Boolean), Boolean> AlreadyChecked
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Int64,Qubit)> IsPeriodic
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,ps,N) = __in__;
#line 119 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var p in new Range(1L, (N - 1L)))
#line hidden
            {
#line 120 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                if (!(AlreadyChecked.Apply((p, N, true))))
                {
#line 123 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    IsPeriodic.Apply((x?.Copy(), p, ps[(p - 1L)]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,ps,N) = __in__;
#line hidden
            foreach (var p in RangeReverse.Apply(new Range(1L, (N - 1L))))
#line hidden
            {
#line hidden
                if (!(AlreadyChecked.Apply((p, N, true))))
                {
#line hidden
                    IsPeriodic.Adjoint.Apply((x?.Copy(), p, ps[(p - 1L)]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.AlreadyChecked = this.Factory.Get<ICallable<(Int64,Int64,Boolean), Boolean>>(typeof(AlreadyChecked));
            this.IsPeriodic = this.Factory.Get<IAdjointable<(QArray<Qubit>,Int64,Qubit)>>(typeof(IsPeriodic));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Qubit> ps, Int64 N)
        {
            return __m__.Run<CheckPeriods, (QArray<Qubit>,QArray<Qubit>,Int64), QVoid>((x, ps, N));
        }
    }

    public class AlreadyChecked : Function<(Int64,Int64,Boolean), Boolean>, ICallable
    {
        public AlreadyChecked(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Boolean)>, IApplyData
        {
            public In((Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AlreadyChecked";
        String ICallable.FullName => "Solution.AlreadyChecked";
        protected ICallable<(Int64,Int64,Boolean), Boolean> self
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Boolean), Boolean> Body => (__in__) =>
        {
            var (ix,N,print) = __in__;
#line 131 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var overlaps = 0L;
#line 132 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var iy in new Range((ix + 1L), (N - 1L)))
#line hidden
            {
#line 133 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                if ((((iy % ix) == 0L) && !(self.Apply<Boolean>((iy, N, false)))))
                {
#line 134 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    overlaps = (overlaps + 1L);
                }
            }

#line 137 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var skip = ((overlaps % 2L) == 1L);
#line 138 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            return skip;
        }

        ;
        public override void Init()
        {
            this.self = this;
        }

        public override IApplyData __dataIn((Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 ix, Int64 N, Boolean print)
        {
            return __m__.Run<AlreadyChecked, (Int64,Int64,Boolean), Boolean>((ix, N, print));
        }
    }

    public class OrOracle : Unitary<(QArray<Qubit>,Qubit)>, ICallable
    {
        public OrOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "OrOracle";
        String ICallable.FullName => "Solution.OrOracle";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
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
#line 143 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 144 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((x?.Copy(), y));
#line 145 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line 146 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            MicrosoftQuantumPrimitiveX.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Apply(y);
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((x?.Copy(), y));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, x?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, x?.Copy())));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (x?.Copy(), y)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, x?.Copy())));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Apply((__controlQubits__?.Copy(), y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveX.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), y));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, x?.Copy())));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (x?.Copy(), y)));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (MicrosoftQuantumPrimitiveX, x?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<OrOracle, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class IsPeriodic : Adjointable<(QArray<Qubit>,Int64,Qubit)>, ICallable
    {
        public IsPeriodic(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "IsPeriodic";
        String ICallable.FullName => "Solution.IsPeriodic";
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

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Int64)> ApplyPeriod
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), Int64> GetControlsLength
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,p,y) = __in__;
#line 155 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var length = GetControlsLength.Apply((x?.Copy(), p));
#line hidden
            {
#line 156 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var q = Allocate.Apply(length);
#line 157 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                ApplyPeriod.Apply((x?.Copy(), q?.Copy(), p));
#line 158 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((q?.Copy(), y));
#line 159 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                ApplyPeriod.Apply((x?.Copy(), q?.Copy(), p));
#line hidden
                Release.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Int64,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (x,p,y) = __in__;
#line hidden
            var length = GetControlsLength.Apply((x?.Copy(), p));
#line hidden
            {
#line hidden
                var q = Allocate.Apply(length);
#line hidden
                ApplyPeriod.Adjoint.Apply((x?.Copy(), q?.Copy(), p));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((q?.Copy(), y));
#line hidden
                ApplyPeriod.Adjoint.Apply((x?.Copy(), q?.Copy(), p));
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
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.ApplyPeriod = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Int64)>>(typeof(ApplyPeriod));
            this.GetControlsLength = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), Int64>>(typeof(GetControlsLength));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p, Qubit y)
        {
            return __m__.Run<IsPeriodic, (QArray<Qubit>,Int64,Qubit), QVoid>((x, p, y));
        }
    }

    public class GetControls : Function<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>, ICallable
    {
        public GetControls(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GetControls";
        String ICallable.FullName => "Solution.GetControls";
        protected ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> GetBiggerControls
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> GetSmallerControls
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), Boolean> UseBigger
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> Body => (__in__) =>
        {
            var (x,p) = __in__;
#line 167 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            if (UseBigger.Apply((x?.Copy(), p)))
            {
#line 169 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return GetBiggerControls.Apply((x?.Copy(), p));
            }
            else
            {
#line 171 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return GetSmallerControls.Apply((x?.Copy(), p));
            }
        }

        ;
        public override void Init()
        {
            this.GetBiggerControls = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>>(typeof(GetBiggerControls));
            this.GetSmallerControls = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>>(typeof(GetSmallerControls));
            this.UseBigger = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), Boolean>>(typeof(UseBigger));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Qubit>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Qubit>>> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p)
        {
            return __m__.Run<GetControls, (QArray<Qubit>,Int64), QArray<QArray<Qubit>>>((x, p));
        }
    }

    public class UseBigger : Function<(QArray<Qubit>,Int64), Boolean>, ICallable
    {
        public UseBigger(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "UseBigger";
        String ICallable.FullName => "Solution.UseBigger";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), Boolean> Body => (__in__) =>
        {
            var (x,p) = __in__;
#line 176 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            if ((p >= ((x.Length - 1L) / 2L)))
            {
#line 177 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return true;
            }
            else
            {
#line 179 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return false;
            }
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p)
        {
            return __m__.Run<UseBigger, (QArray<Qubit>,Int64), Boolean>((x, p));
        }
    }

    public class GetSmallerControls : Function<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>, ICallable
    {
        public GetSmallerControls(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GetSmallerControls";
        String ICallable.FullName => "Solution.GetSmallerControls";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> Body => (__in__) =>
        {
            var (x,p) = __in__;
#line 184 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var controls = new QArray<QArray<Qubit>>(p);
#line 185 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var ix in new Range(0L, (p - 1L)))
#line hidden
            {
#line 186 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var cntrl = new QArray<Qubit>(0L);
#line 187 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                foreach (var iy in new Range(ix, (x.Length - 1L)))
#line hidden
                {
#line 188 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    if ((ix == (iy % p)))
                    {
#line 189 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                        cntrl = (cntrl + new QArray<Qubit>()
                        {x[iy]});
                    }
                }

#line 192 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                if ((cntrl.Length > 1L))
                {
#line 193 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                    controls[ix] = cntrl?.Copy();
                }
            }

#line 196 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            return controls;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Qubit>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Qubit>>> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p)
        {
            return __m__.Run<GetSmallerControls, (QArray<Qubit>,Int64), QArray<QArray<Qubit>>>((x, p));
        }
    }

    public class GetControlsLength : Function<(QArray<Qubit>,Int64), Int64>, ICallable
    {
        public GetControlsLength(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GetControlsLength";
        String ICallable.FullName => "Solution.GetControlsLength";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), Boolean> UseBigger
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), Int64> Body => (__in__) =>
        {
            var (x,p) = __in__;
#line 200 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = x.Length;
#line 201 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            if (UseBigger.Apply((x?.Copy(), p)))
            {
#line 202 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return (N - p);
            }
            else
            {
#line 204 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                return p;
            }
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.UseBigger = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), Boolean>>(typeof(UseBigger));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p)
        {
            return __m__.Run<GetControlsLength, (QArray<Qubit>,Int64), Int64>((x, p));
        }
    }

    public class GetBiggerControls : Function<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>, ICallable
    {
        public GetBiggerControls(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "GetBiggerControls";
        String ICallable.FullName => "Solution.GetBiggerControls";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), Int64> GetControlsLength
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> Body => (__in__) =>
        {
            var (x,p) = __in__;
#line 209 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var N = x.Length;
#line 210 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var len = GetControlsLength.Apply((x?.Copy(), p));
#line 211 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var controls = new QArray<QArray<Qubit>>(len);
#line 213 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var ix in new Range(0L, (len - 1L)))
#line hidden
            {
#line 215 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                controls[ix] = new QArray<Qubit>(x[ix], x[((N - len) + ix)]);
            }

#line 217 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            return controls;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.GetControlsLength = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), Int64>>(typeof(GetControlsLength));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<QArray<Qubit>> data) => data;
        public static System.Threading.Tasks.Task<QArray<QArray<Qubit>>> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 p)
        {
            return __m__.Run<GetBiggerControls, (QArray<Qubit>,Int64), QArray<QArray<Qubit>>>((x, p));
        }
    }

    public class ApplyPeriod : Adjointable<(QArray<Qubit>,QArray<Qubit>,Int64)>, ICallable
    {
        public ApplyPeriod(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyPeriod";
        String ICallable.FullName => "Solution.ApplyPeriod";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>> GetControls
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,q,cp) = __in__;
#line 222 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var p = q.Length;
#line 223 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            var controls = GetControls.Apply((x?.Copy(), cp));
#line 224 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
            foreach (var ix in new Range(0L, (controls.Length - 1L)))
#line hidden
            {
#line 225 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                var cnt = controls[ix];
#line 229 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), q[ix]));
#line 230 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
#line 231 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumPrimitiveX.Controlled.Apply((cnt?.Copy(), q[ix]));
#line 232 "/Users/korbenrusek/Documents/code/quantum_winter_2019/competition/C2_Periodic/Tasks.qs"
                MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,q,cp) = __in__;
#line hidden
            var p = q.Length;
#line hidden
            var controls = GetControls.Apply((x?.Copy(), cp));
#line hidden
            foreach (var ix in RangeReverse.Apply(new Range(0L, (controls.Length - 1L))))
#line hidden
            {
#line hidden
                var cnt = controls[ix];
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((cnt?.Copy(), q[ix]));
#line hidden
                MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, cnt?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((cnt?.Copy(), q[ix]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.GetControls = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QArray<QArray<Qubit>>>>(typeof(GetControls));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, QArray<Qubit> q, Int64 cp)
        {
            return __m__.Run<ApplyPeriod, (QArray<Qubit>,QArray<Qubit>,Int64), QVoid>((x, q, cp));
        }
    }
}