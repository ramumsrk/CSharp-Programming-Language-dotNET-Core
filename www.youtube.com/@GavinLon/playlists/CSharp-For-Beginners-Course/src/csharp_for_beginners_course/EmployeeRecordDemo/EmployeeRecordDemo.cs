namespace EmployeeRecordDemo
{
  class EmployeeRecordDemo
  {
    static void Main()
    {
        foreach (EmployeeRecord.EmployeeRecord _employeeRecord in EmployeeRecordDemo.GetListOfEmployeeRecords())
        {
          System.Console.WriteLine($"{Environment.NewLine}{_employeeRecord}");
        }
      return;
    }
    /// <summary>
    /// Return a list of employee-records
    /// </summary>
    /// <returns>List of employee-records</returns>
    static System.Collections.Generic.List<EmployeeRecord.EmployeeRecord> GetListOfEmployeeRecords()
    {
      return new System.Collections.Generic.List<EmployeeRecord.EmployeeRecord>()
      {
        new EmployeeRecord.EmployeeRecord()
        {
          EmployeeId =1,
          FirstName = "Sarah",
          LastName = "Johnson",
          AnnualSalary = 60_000.1_345_632_178M,
          EmployeeGender = EmployeeGender.EmployeeGender.Female,
          IsManager = true
        },
      };
    }
  }
}