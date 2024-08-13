namespace FunctionBasics
{
  class FunctionBasics
  {
    /// <summary>
    /// C# program execution starts from built-in
    /// <code>System.Main</code> method
    /// </summary>
    static void Main()
    {
      FunctionBasics functionBasics = new FunctionBasics();
      
      System.Console.Write("Enter distance travelled: ");
      double distanceTravelledInMiles = System.Convert.ToDouble(System.Console.ReadLine());
      double distanceTravelledInKilometers = FunctionBasics.MilesToKilometers(distanceTravelledInMiles);
      System.Console.WriteLine("{0}'{1}' miles is equal to '{2}' kilometers",
        System.Environment.NewLine,
        distanceTravelledInMiles,
        distanceTravelledInKilometers
      );

      foreach (var sampleInputString in new string[] { "Test string", "Another test string" })
      {
        FunctionBasics.PrintWithPrefix(sampleInputString);
      }

      foreach (var sampleInputDistanceInMiles in new double[] { 8.0, 52.0 })
      {
        System.Console.WriteLine("{0}'{1}' miles is equal to '{2}' kilometers",
          System.Environment.NewLine,
          sampleInputDistanceInMiles,
          FunctionBasics.MilesToKilometers(sampleInputDistanceInMiles)
        );        
      }
      return;
    }

    /// <summary>
    /// Convert distance in miles to kilometers
    /// </summary>
    /// <param name="miles">Distance in miles</param>
    /// <returns>Distance in kilometers</returns>
    static double MilesToKilometers(double miles) => miles * 1.6;

    /// <summary>
    /// Print a string-literal prefixed with another string-literal to standard-output
    /// </summary>
    /// <param name="sampleInputString"></param>
    static void PrintWithPrefix(string? sampleInputString) => System.Console.WriteLine(
      "{0}::> '{1}'",System.Environment.NewLine,sampleInputString);
  }
}