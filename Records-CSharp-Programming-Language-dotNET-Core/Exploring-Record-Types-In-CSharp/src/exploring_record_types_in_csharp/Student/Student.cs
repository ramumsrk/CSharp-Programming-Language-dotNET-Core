namespace Student;
/// <summary>
/// A class representing a Student
/// </summary>
public class Student
{
  /// <summary>
  /// Name of a Student instance
  /// </summary>
  private string? _studentName;
  /// <summary>
  /// A read-only property returning the value of field <code>_studentName</code>
  /// </summary>
  public string? StudentName
  {
    get
    {
      return this._studentName;
    }
    set
    {
      this._studentName = value;
    }
  }
}