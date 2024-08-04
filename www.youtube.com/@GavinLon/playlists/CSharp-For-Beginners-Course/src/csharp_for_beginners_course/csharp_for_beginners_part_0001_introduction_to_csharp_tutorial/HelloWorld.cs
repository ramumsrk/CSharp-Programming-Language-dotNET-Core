namespace csharp_for_beginners_part_0001_introduction_to_csharp_tutorial;

class HelloWorld
{
  static void Main(string[] arguments)
  {
      const string? _helloWorld = "Hello, World";
      System.Console.WriteLine($"{Environment.NewLine}'{_helloWorld}'");
      System.Console.Write($"{Environment.NewLine}Enter your name: ");
      string? _sampleInputName = System.Console.ReadLine();
      System.Console.WriteLine($"{Environment.NewLine}You entered '{_sampleInputName}'");
    return;
  }
}