namespace dio_bank
{
  public class Account
  {
    private string _Name { get; set; }
    private double _Balance { get; set; }
    private double _Credit { get; set; }
    private AccountType _AccountType { get; set; }

    public Account(string name, double balance, double credit,
     AccountType accountType)
    {
      _Name = name;
      _Balance = balance;
      _Credit = credit;
      _AccountType = accountType;
    }

    public bool Withdraw(double value)
    {
      if (_Balance - value < (_Credit * -1))
      {
        System.Console.WriteLine("Insufficient balance.");
        return false;
      }

      _Balance -= value;

      System.Console.WriteLine($@"Hello, {_Name}.Your current balance is:
        {_Balance}");
      return true;
    }

    public bool Deposit(double value)
    {
      _Balance += value;
      System.Console.WriteLine($@"Hello, {_Name}. Your current balance is:
        {_Balance}");
      return true;
    }

    public void Transfer(double value, Account targetAccount)
    {
      if (this.Withdraw(value))
        targetAccount.Deposit(value);
    }

    public override string ToString()
    {
      return $@"Account info:
                Account Type: {_AccountType} 
                Name: {_Name} 
                Balance: {_Balance} 
                Credit: {_Credit}";
    }
  }
}