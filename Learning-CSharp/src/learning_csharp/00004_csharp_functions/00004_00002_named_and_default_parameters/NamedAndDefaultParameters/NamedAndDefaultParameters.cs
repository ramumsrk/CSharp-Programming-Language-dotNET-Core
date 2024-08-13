namespace NamedAndDefaultParameters
{
  class NamedAndDefaultParameters
  {
    /// <summary>
    /// C# program execution starts from built-in
    /// <code>System.Main</code> method
    /// </summary>
    /// <param name="arguments">Runtime arguments passed to the program</param>
    static void Main(params string[] arguments)
    {
      NamedAndDefaultParameters namedAndDefaultParameters = new NamedAndDefaultParameters();
      NamedAndDefaultParameters.PrintAStringWithAPrefix("Hello There!");
      NamedAndDefaultParameters.PrintAStringWithAPrefix("Hello There!", ">: ");
      NamedAndDefaultParameters.PrintAStringWithAPrefix(prefix: "Ternary prompt >>>", sampleInputString: "Prefixed by a ternary prompt");
      return;
    }
    /// <summary>
    /// Print a string prefixed by another string to standard-output
    /// </summary>
    /// <param name="sampleInputString">A string literal following the prefix</param>
    /// <param name="prefix">The string literal prefixing a sample string literal. Default value being an empty string literal</param>
    static void PrintAStringWithAPrefix(string? sampleInputString, string? prefix="")
    {
      System.Console.WriteLine("{0}'{1}' '{2}'",System.Environment.NewLine,prefix,sampleInputString);
      return;
    }
  }
}