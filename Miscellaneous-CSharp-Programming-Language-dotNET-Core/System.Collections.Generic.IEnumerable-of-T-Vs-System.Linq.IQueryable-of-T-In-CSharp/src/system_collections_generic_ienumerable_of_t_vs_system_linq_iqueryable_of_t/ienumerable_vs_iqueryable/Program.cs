{
  // Data-source or sourc from which data is read
  System.Collections.Generic.IEnumerable<int> _numbers = [
    1,
    2,
    3,
    4,
    5,
  ];

  // Query expression
  System.Collections.Generic.IEnumerable<int> _queryNumbersGreaterThanTwo = from number in _numbers where number > 2 select number;

  System.Console.WriteLine($"{System.Environment.NewLine}Listing of numbers greater than '2'");
  foreach (int aNumber in _queryNumbersGreaterThanTwo)
  {
    System.Console.WriteLine($"{System.Environment.NewLine}'{aNumber}' is greater than '2'");
  }

  // Method expression
  var _queryAnotherListOfNumbersGreaterThanTwo = _numbers.Where(number => number > 2);
}