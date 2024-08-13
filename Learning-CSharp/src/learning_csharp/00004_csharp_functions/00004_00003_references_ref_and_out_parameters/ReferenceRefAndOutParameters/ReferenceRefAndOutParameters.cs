namespace ReferenceRefAndOutParameters
{
  class ReferenceRefAndOutParameters
  {
    /// <summary>
    /// C# program execution starts from built-in
    /// <code>System.Main</code> method
    /// </summary>
    /// <param name="arguments">Runtime arguments passed to program</param>
    static void Main(string[] arguments)
    {
      ReferenceRefAndOutParameters referenceRefAndOutParameters = new ReferenceRefAndOutParameters();

      int firstInputNumber = 10;
      int secondInputNumber = 20;
      
      System.Console.WriteLine("{0}Before swapping, first number: '{1}' and second number: '{2}'",System.Environment.NewLine,firstInputNumber,secondInputNumber);
      ReferenceRefAndOutParameters.DoesNotActuallySwapTwoNumbers(firstInputNumber,secondInputNumber);
      System.Console.WriteLine("{0}After swapping, first number: '{1}' and second number: '{2}'",System.Environment.NewLine,firstInputNumber,secondInputNumber);
      
      System.Console.WriteLine("{0}Before swapping, first number: '{1}' and second number: '{2}'",System.Environment.NewLine,firstInputNumber,secondInputNumber);
      ReferenceRefAndOutParameters.SwapTwoNumbers(secondNumber: ref secondInputNumber, firstNumber: ref firstInputNumber);
      System.Console.WriteLine("{0}After swapping, first number: '{1}' and second number: '{2}'",System.Environment.NewLine,firstInputNumber,secondInputNumber);

      int product = default;
      int sum = default;
      ReferenceRefAndOutParameters.ProductAndSumOfTwoNumbers(firstInputNumber, secondInputNumber, out product, out sum);
      System.Console.WriteLine("{0}Product of '{1}' and '{2}' is '{3}', and sum of '{1}' and '{2}' is '{4}'",System.Environment.NewLine,firstInputNumber,secondInputNumber,product,sum);
      return;
    }

    /// <summary>
    /// An attempt is made to swap two input parameters. However, they are NOT swapped
    /// </summary>
    /// <param name="firstNumber">First input number</param>
    /// <param name="secondNumber">Second input number</param>
    static void DoesNotActuallySwapTwoNumbers(int firstNumber, int secondNumber)
    {
      int temporary = firstNumber;
      firstNumber = secondNumber;
      secondNumber = temporary;
      return;
    }
    /// <summary>
    /// Swap two numbers
    /// </summary>
    /// <param name="firstNumber">First input number</param>
    /// <param name="secondNumber">Second input number</param>
    static void SwapTwoNumbers(ref int firstNumber, ref int secondNumber)
    {
      int temporary = firstNumber;
      firstNumber = secondNumber;
      secondNumber = temporary;
      return;
    }
    /// <summary>
    /// Perform multiplication and addition on two numbers
    /// </summary>
    /// <param name="firstNumber">The first input number</param>
    /// <param name="secondNumber">The second input number</param>
    /// <param name="product">Product of first-number and second-number</param>
    /// <param name="sum">Sum of first-number and second-number</param>
    static void ProductAndSumOfTwoNumbers(int firstNumber, int secondNumber, out int product, out int sum)
    {
      product = firstNumber * secondNumber;
      sum = firstNumber + secondNumber;
      return;
    }
  }
}