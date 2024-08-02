namespace User;

/// <summary>
/// A class representing a User
/// </summary>
public class User
{
  /// <summary>
  /// First-name of a User
  /// </summary>
  private string? _firstName;
  /// <summary>
  /// Last-name of a User
  /// </summary>
  private string? _lastName;
  /// <summary>
  /// Fullname of a User. It is a concatenation of <code>_firstName</code> and <code>_lastName</code> fields
  /// </summary>
  private string? _fullName;
  /// <summary>
  /// Property to Get and Set <code>_firstName</code> field. This is a read-write property
  /// </summary>
  public string? FirstName
  {
    get
    {
      return this._firstName;
    }
    set
    {
      this._firstName = value;
    }
  }
  /// <summary>
  /// Property to Get and Set <code>_lastName</code> field. This is a read-write property
  /// </summary>  
  public string? LastName
  {
    get
    {
      return this._lastName;
    }
    set
    {
      this._lastName = value;
    }
  }
  /// <summary>
  /// Property to get and <em>internally</em> set the <code>_fullName</code> of a User. This is a read-only property
  /// </summary>
  public string? FullName
  {
    get
    {
      return $"{this._firstName} {this._lastName}";
    }
    private set
    {
      this._fullName = $"{this._firstName} {this._lastName}";
    }
  }
}