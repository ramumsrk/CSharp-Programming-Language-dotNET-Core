namespace csharp_for_beginners_part_0002_data_types_tutorial
{
  class DataTypes
  {
    static void Main()
    {
        // Id of an employee
        int _employeeId = 0;
        // First-name of an employee
        string? _firstName = String.Empty;
        // Last-name of an employee
        string? _lastName = String.Empty;
        // Full-name of an employee
        string? _fullName = $"{_firstName} {_lastName}";
        // Annual-salary of an employee
        var _annualSalary = 0M;
        // Gender of an employee
        char _gender = '\0';
        // Is the employee a manager?
        bool _isManager = false;
        System.Console.Write("Enter employee id: ");
        _employeeId = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter employee first-name: ");
        _firstName = System.Console.ReadLine();
        System.Console.Write("Enter employee last-name: ");
        _lastName = System.Console.ReadLine();
        System.Console.Write("Enter employee annual salary: ");
        _annualSalary = System.Convert.ToDecimal(System.Console.ReadLine());
        _fullName = $"{_firstName} {_lastName}";
        System.Console.Write($"Is the employee '{_fullName}' a manager? ");
        _isManager = System.Convert.ToBoolean(System.Console.ReadLine());
        System.Console.Write("Enter employee gender: ");
        _gender = System.Convert.ToString(System.Console.ReadLine())[0];        
        var _narrative = $"Employee id: '{_employeeId}', full-name: '{_fullName}', annual-salary: '{_annualSalary:C2}', gender: '{((_gender == 'F')?"Female":"Male")}', is a manager? '{_isManager}'";
        System.Console.WriteLine($"{Environment.NewLine}{_narrative}");
      return;
    }
  }
}