namespace EmployeeRecord;

/// <summary>
/// A record class type representing an Employee
/// </summary>
public record class EmployeeRecord
{
  /// <summary>
  /// Id of an employee
  /// </summary>
  private int _employeeId;
  /// <summary>
  /// Firstname of an employee
  /// </summary>
  private string? _firstName;
  /// <summary>
  /// Lastname of an employee
  /// </summary>
  private string? _lastName;
  /// <summary>
  /// Fullname of an employee
  /// </summary>
  private string? _fullName;
  /// <summary>
  /// Annual-salary of an employee
  /// </summary>  
  private decimal _annualSalary;
  /// <summary>
  /// Gender of an employee
  /// </summary>
  private EmployeeGender.EmployeeGender _employeeGender;
  /// <summary>
  /// Is the employee a Manager?
  /// </summary>
  private bool _isManager;
  /// <summary>
  /// Read-Write property to Get and Set value of field <code>_employeeId</code> respectively
  /// </summary>
  public int EmployeeId
  {
    get
    {
      return this._employeeId;
    }
    init
    {
      this._employeeId = value;
    }
  }
  /// <summary>
  /// Read-Write property to Get and Set value of field <code>_firstName</code> respectively
  /// </summary>
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
  /// <summary>
  /// Read-Write property to Get and Set value of field <code>_lastName</code> respectively
  /// </summary>
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
  /// <summary>
  /// Read-Only property to Get value of field <code>_fullName</code> respectively
  /// </summary>
  public string? FullName
  {
    get
    {
      return $"{this._firstName} {this._lastName}";
    }
    private set
    {
      this._fullName = $"{_firstName} {_lastName}";
    }
  }
  /// <summary>
  /// Read-Write property to Get and Set value of the field <code>_annualSalary</code>
  /// </summary>
  public decimal AnnualSalary
  {
    get
    {
      return this._annualSalary;
    }
    init
    {
      this._annualSalary = value;
    }
  }
  /// <summary>
  /// Read-Write property to Get and Set the value of field <code>_employeeGender</code>
  /// </summary>
  public EmployeeGender.EmployeeGender EmployeeGender
  {
    get
    {
      return this._employeeGender;
    }
    init
    {
      this._employeeGender = value;
    }
  }
  /// <summary>
  /// Read-Write property to Get and Set value of field <code>_isManager</code>
  /// </summary>
  public bool IsManager
  {
    get
    {
      return this._isManager;
    }
    init
    {
      this._isManager = value;
    }
  }
}