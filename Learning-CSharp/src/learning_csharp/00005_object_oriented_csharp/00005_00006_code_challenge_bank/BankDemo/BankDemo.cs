namespace BankDemo
{
  class BankDemo
  {
    static void Main(params string[] arguments)
    {
      BankDemo bankDemo = new BankDemo();

      CheckingAccount.CheckingAccount checkingAccount = new CheckingAccount.CheckingAccount("John", "Doe", 2_500.0M)
      {
        CustomerFirstName = "John",
        CustomerLastName = "Doe",
        Balance = 2_500.0M,
      };
      System.Console.WriteLine("{0}Checking account balance: '{1}'",System.Environment.NewLine,checkingAccount.Balance);
      System.Console.WriteLine("{0}Checking account owner name: '{1}'",System.Environment.NewLine,checkingAccount.AccountOwner);

      SavingsAccount.SavingsAccount savingsAccount = new SavingsAccount.SavingsAccount("Jane", "Doe", 0.03M, 1_000.0M)
      {
        CustomerFirstName = "Jane",
        CustomerLastName = "Doe",
        InterestRate = 0.03M,
        Balance = 1_000.0M,
      };
      System.Console.WriteLine("{0}Savings account balance: '{1}'",System.Environment.NewLine,savingsAccount.Balance);
      System.Console.WriteLine("{0}Savings account owner name: '{1}'",System.Environment.NewLine,savingsAccount.AccountOwner);
      
      checkingAccount.Deposit(200.0M);
      savingsAccount.Deposit(150.0m);
      System.Console.WriteLine("{0}Checking account balance: '{1}",System.Environment.NewLine,checkingAccount.Balance);
      System.Console.WriteLine("{0}Savings account balance: '{1}",System.Environment.NewLine,savingsAccount.Balance);
      
      checkingAccount.Withdraw(50.0M);
      savingsAccount.Withdraw(125.0m);
      System.Console.WriteLine("{0}Checking account balance: '{1}",System.Environment.NewLine,checkingAccount.Balance);
      System.Console.WriteLine("{0}Savings account balance: '{1}",System.Environment.NewLine,savingsAccount.Balance);
      
      savingsAccount.ApplyInterest();
      System.Console.WriteLine("{0}Savings account balance: '{1}",System.Environment.NewLine,savingsAccount.Balance);
      
      savingsAccount.Withdraw(10.0M);
      savingsAccount.Withdraw(20.0m);
      savingsAccount.Withdraw(30.0M);
      System.Console.WriteLine("{0}Savings account balance: '{1}",System.Environment.NewLine,savingsAccount.Balance);
      
      savingsAccount.Withdraw(2_000.0m);
      checkingAccount.Withdraw(3_000.0M);
      System.Console.WriteLine("{0}Checking account balance: '{1}",System.Environment.NewLine,checkingAccount.Balance);
      System.Console.WriteLine("{0}Savings account balance: '{1}",System.Environment.NewLine,savingsAccount.Balance);      
      return;
    }
  }
}