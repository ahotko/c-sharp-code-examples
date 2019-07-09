# C# Code Examples (mostly for myself)

A collection of code samples I have used C# and think they might be useful in the future.

## Sample Categories
* [Design Patterns](CSharp%20Code%20Samples/CodeSamples/Patterns)
  * Creational Patterns
	* [Singleton Pattern](CSharp%20Code%20Samples/CodeSamples/Patterns/Creational/SingletonPattern.cs)
  * Behavioral Patterns
	* [Strategy Pattern](CSharp%20Code%20Samples/CodeSamples/Patterns/Behavioral/StrategyPattern.cs)
	* [Observer Pattern](CSharp%20Code%20Samples/CodeSamples/Patterns/Behavioral/ObserverPattern.cs)
	* [State Pattern](CSharp%20Code%20Samples/CodeSamples/Patterns/Behavioral/StatePattern.cs)
* [Syntactic Sugars](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars)
  * [Auto Property](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/PropertiesSample.cs#L34)
  * [Auto Property with default value](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/PropertiesSample.cs#L35)
  * [Property getter/setter](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/PropertiesSample.cs#L11)
  * [String Interpolation](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/StringInterpolationSample.cs)
  * [Using](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/UsingSample.cs)
  * [Pattern Matching](CSharp%20Code%20Samples/CodeSamples/SyntacticSugars/PatternMatchingSample.cs)
* [Tuple Deconstruction](CSharp%20Code%20Samples/CodeSamples/TupleDeconstruction) (requires [`System.ValueTuple`](https://www.nuget.org/packages/System.ValueTuple/)); Additional links: [Link](https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct)
* [Object Pool](CSharp%20Code%20Samples/CodeSamples/UsefulClasses/ObjectPoolSample.cs)
* [Dictionaries](CSharp%20Code%20Samples/CodeSamples/UsefulClasses/Dictionaries.cs)
  * ["Ordinary" Dictionary](CSharp%20Code%20Samples/CodeSamples/UsefulClasses/Dictionaries.cs#L42) Additional links: [Link](https://www.dotnetperls.com/dictionary)
  * [`OrderedDictionary`](CSharp%20Code%20Samples/CodeSamples/UsefulClasses/Dictionaries.cs#L50) (requires [`System.Collections.Specialized`](https://www.nuget.org/packages/System.Collections.Specialized/)); Additional links: [Link](https://www.geeksforgeeks.org/c-sharp-ordereddictionary-class/)
  * [`SortedDictionary`](CSharp%20Code%20Samples/CodeSamples/UsefulClasses/Dictionaries.cs#L65) Additional links: [Link](https://www.dotnetperls.com/sorteddictionary)
* [Abstract Class](CSharp%20Code%20Samples/CodeSamples/SampleExecute.cs)
* [Interface](CSharp%20Code%20Samples/CodeSamples/ISampleExecute.cs)
* [Classes](CSharp%20Code%20Samples/CodeSamples/Classes)
  * [Get current Class name](CSharp%20Code%20Samples/CodeSamples/Classes/ClassAndMethodNamesSample.cs#L9)
  * [Get current Method Name](CSharp%20Code%20Samples/CodeSamples/Classes/ClassAndMethodNamesSample.cs#L10)
  * [Constructor Chaining](CSharp%20Code%20Samples/CodeSamples/Classes/ConstructorChainingSample.cs)
* [`LINQ`](CSharp%20Code%20Samples/CodeSamples/Useful/LinqSample.cs)
  * Sum
  * Sum by Groups
  * Ordering (asc, desc)
  * Skipping
  * Take N elements
* [Operator Overloading](CSharp%20Code%20Samples/CodeSamples/Alterations/OperatorOverloadingSample.cs)
* [Implicit/Explicit Conversion operators](CSharp%20Code%20Samples/CodeSamples/Alterations/EntityConversionSample.cs)
* [Attributes and Conditionals](CSharp%20Code%20Samples/CodeSamples/Attributes)
  * [Debugger](CSharp%20Code%20Samples/CodeSamples/Attributes/DebuggingSample.cs)
    * [`DebuggerDisplay`](CSharp%20Code%20Samples/CodeSamples/Attributes/DebuggingSample.cs)
	* [`DebuggerBrowsable`](CSharp%20Code%20Samples/CodeSamples/Attributes/DebuggingSample.cs)
	* [`Conditional`](CSharp%20Code%20Samples/CodeSamples/Attributes/DebuggingSample.cs)
	* [`#if - #define - #endif`](CSharp%20Code%20Samples/CodeSamples/Attributes/DebuggingSample.cs)
  * [`Obsolete`](CSharp%20Code%20Samples/CodeSamples/Attributes/ObsoleteSample.cs)
    * [Compiler Warning](CSharp%20Code%20Samples/CodeSamples/Attributes/ObsoleteSample.cs)
	* [Compiler Error](CSharp%20Code%20Samples/CodeSamples/Attributes/ObsoleteSample.cs)
* [Threading](CSharp%20Code%20Samples/CodeSamples/MultiThreading)
  * [`BackgroundWorker`](CSharp%20Code%20Samples/CodeSamples/MultiThreading/BackgroundWorkerSample.cs)

  
## Useful Libraries

### Universal
* Excel (Native)
  * [EPPlus](https://github.com/JanKallman/EPPlus)
* QR Codes
  * [QRCoder](https://github.com/codebude/QRCoder)
* PDF
  * [PdfFileWriter.NET](https://github.com/jeske/PdfFileWriter.NET)
* JSON
  * [Json.NET](https://www.newtonsoft.com/json)
  * [Jil - Fast .NET JSON (De)Serializer, Built On Sigil](https://github.com/kevin-montrose/Jil)
* Logging
  * [NLog](https://nlog-project.org/)
  
### WPF Specific
* UI/UX
  * Frameworks
    * [MahApps.Metro](https://github.com/MahApps/MahApps.Metro)
	* [Modern UI for WPF](https://github.com/firstfloorsoftware/mui)
  * Iconpacks
    * [MahApps.IconPack](https://github.com/MahApps/MahApps.Metro.IconPacks)
