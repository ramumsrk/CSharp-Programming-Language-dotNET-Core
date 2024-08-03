namespace AnotherStudentRecord;

/// <summary>
/// An immutable Student record
/// </summary>
public record class AnotherStudentRecord
{
  /// <summary>
  /// Name of a Student
  /// </summary>
  private string? _studentName;
  /// <summary>
  /// A read-write property to get and set the value of <code>_studentName</code> field
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
  /// <summary>
  /// Id of a Student
  /// </summary>
  private int _studentId;
  /// <summary>
  /// A read-write property to get and set <code>_studentId</code> field
  /// </summary>
  public int StudentId
  {
    get
    {
      return this._studentId;
    }
    set
    {
      this._studentId = value;
    }
  }
}