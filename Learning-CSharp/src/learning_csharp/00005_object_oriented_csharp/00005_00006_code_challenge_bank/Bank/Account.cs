namespace Bank;

/// <summary>
/// A class representing a Bank account
/// </summary>
public class Account
{
  // Data - fields
  /// <summary>
  /// Customer first-name
  /// </summary>
  private string? _customerFirstName = default;
  /// <summary>
  /// Read-Write property of field customer first-name
  /// </summary>
  public string? CustomerFirstName
  {
    get => this._customerFirstName;
    init => this._customerFirstName = value;
  }
  /// <summary>
  /// Customer last-name
  /// </summary>
  private string? _customerLastName = default;
  /// <summary>
  /// Read-Write property of customer last-name
  /// </summary>
  public string? CustomerLastName
  {
    get => this._customerLastName;
    init => this._customerLastName = value;
  }
  /// <summary>
  /// Balance in a customer's bank-account
  /// </summary>
  private decimal _balance = 0.0M;
  /// <summary>
  /// Read-Write property of customer starting-balance field
  /// </summary>
  public decimal Balance
  {
    get => this._balance;
    set => this._balance = value;
  }
  /// <summary>
  /// Deposit a specified amount
  /// </summary>
  /// <param name="amount">Amount to deposit</param>
  public void Deposit(decimal amount)
  {
    Balance += amount;
    return;
  }
  /// <summary>
  /// Withdraw a specified amount 
  /// </summary>
  /// <param name="amount">Amount to withdraw</param>
  public virtual void Withdraw(decimal amount)
  {
    Balance -= amount;
    return;
  }
  /// <summary>
  /// Get-only property to customer's fullname
  /// </summary>
  public string AccountOwner => $"{CustomerFirstName} {CustomerLastName}";

  public Account(string? firstName, string? lastName, decimal amount)
  {
    CustomerFirstName = firstName;
    CustomerLastName = lastName;
    Balance = amount;
    return;
  }
}