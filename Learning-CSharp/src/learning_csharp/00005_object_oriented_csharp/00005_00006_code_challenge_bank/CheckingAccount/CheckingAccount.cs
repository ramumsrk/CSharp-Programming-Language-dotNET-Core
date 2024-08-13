namespace CheckingAccount;

public class CheckingAccount : Bank.Account
{
  /// <summary>
  /// Amount to withdraw
  /// </summary>
  /// <param name="amount">Amount to withdraw from balance</param>
  public override void Withdraw(decimal amount)
  {
    if (amount > Balance)
    {
      // Charge a fee of 35
      Balance -= 35M;
      Balance -= amount;
    }
    else
    {
      Balance -= amount;
    }
    return;
  }
  /// <summary>
  /// Initial state of a Checking account
  /// </summary>
  /// <param name="firstName">Customer first-name</param>
  /// <param name="lastName">Customer last-name</param>
  /// <param name="balance">Initial balance</param>
  public CheckingAccount(string? firstName, string? lastName, decimal balance) : base(firstName, lastName, balance)
  {
    return;
  }
}
