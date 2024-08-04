namespace StudentRecord;

public record class StudentRecord
{
  private int _studentId;
  public int StudentId
  {
    get
    {
      return this._studentId;
    }
    init
    {
      this._studentId = value;
    }
  }
  private string? _firstName;
  public string? FirstName
  {
    get
    {
      return this._firstName;
    }
    init
    {
      this._firstName = value;
    }
  }
  private string? _lastName;
  public string? LastName
  {
    get
    {
      return this._lastName;
    }
    init
    {
      this._lastName = value;
    }
  }
  private string? _fullName;
  public string? FullName
  {
    get
    {
      return $"{this._firstName} {this._lastName}";
    }
    init
    {
      this._fullName = $"{this._firstName} {this._lastName}";
    }
  }
  private decimal _loanAmount;
  public decimal LoanAmount
  {
    get
    {
      return this._loanAmount;
    }
    init
    {
      this._loanAmount = value;
    }
  }
  private StudentGender.StudentGender _studentGender;
  public StudentGender.StudentGender StudentGender
  {
    get
    {
      return this._studentGender;
    }
    init
    {
      this._studentGender = value;
    }
  }
}