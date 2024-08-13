namespace ReturningMultipleValues;

class ReturningMultipleValues
{
  /// <summary>
  /// C# program execution starts from built-in
  /// <code>System.Main</code> method
  /// </summary>
  /// <param name="arguments">Arguments passed to the program at runtime</param>
  static void Main(params string[] arguments)
  {
    ReturningMultipleValues returningMultipleValues = new ReturningMultipleValues();
    (int firstNumber, int secondNumber) firstTuple = (10, 20);
    var secondTuple = (30, 40);
    System.Console.WriteLine("{0} '{1}', '{2}', '{3}', and '{4}'",System.Environment.NewLine,firstTuple.firstNumber,firstTuple.secondNumber,secondTuple.Item1,secondTuple.Item2);

    (int sum, int product) sumAndProductTuple =
      ReturningMultipleValues.SumAndProductOfTwoNumbers(firstTuple.firstNumber, firstTuple.secondNumber);
    System.Console.WriteLine("{0}'{1}' and '{2}' is the sum and product of '{3}' and '{4}' respectively",System.Environment.NewLine,sumAndProductTuple.sum,sumAndProductTuple.product,firstTuple.firstNumber,firstTuple.secondNumber);
    return;
  }

  /// <summary>
  /// Calculate sum and product of two numbers   
  /// </summary>
  /// <param name="firstNumber"></param>
  /// <param name="secondNumber"></param>
  /// <returns>A tuple containing sum and product of two numbers</returns>
  static (int, int) SumAndProductOfTwoNumbers(int firstNumber, int secondNumber)
  {
    (int sum, int product) resultTuple = (default, default);
    resultTuple.sum = firstNumber + secondNumber;
    resultTuple.product = firstNumber * secondNumber;
    return resultTuple;
  }
}