namespace SavingsAccount;

public class SavingsAccount : Bank.Account
{
  /// Behaviour - Constructors
  /// <summary>
  /// Initial state of a savings-account instance
  /// </summary>
  /// <param name="firstName">Customer first-name</param>
  /// <param name="lastName">Customer last-name</param>
  /// <param name="amount">Initial amount in account</param>
  public SavingsAccount(string? firstName, string? lastName, decimal interestRate, decimal amount) : base(firstName, lastName, amount)
  {
    InterestRate = interestRate;
    return;
  }
  // Data - fields
  /// <summary>
  /// Interest rate applied on savings-account
  /// </summary>
  private decimal _interestRate;
  /// <summary>
  /// Read-Write property of a savings-account interest-rate 
  /// </summary>
  public decimal InterestRate
  {
    get => this._interestRate;
    set => this._interestRate = value;
  }
  /// <summary>
  /// Interest-rate applied on a customer's balance
  /// </summary>
  public void ApplyInterest()
  {
    Balance += (Balance * InterestRate);
    return;
  }
  /// <summary>
  /// Withdraw a specified amount from balance  
  /// </summary>
  /// <param name="amount"></param>
  public override void Withdraw(decimal amount)
  {
    if (amount > Balance)
    {
      ;
    }
    else
    {
      Balance -= amount;
    }
    if (NumberOfWithdrawals > 3)
    {
      Balance -= 2;
    }
    NumberOfWithdrawals += 1;
    return;
  }
  // Data - fields
  private int _numberOfWithdrawals = default;
  // Read-Write property for number of withdrawals
  private int NumberOfWithdrawals
  {
    get => this._numberOfWithdrawals;
    set => this._numberOfWithdrawals += 1;
  }
}