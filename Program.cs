using System;
using System.Collections.Generic;

namespace dio_bank
{
  class Program
  {
    static List<Account> accountList = new List<Account>();
    static void Main(string[] args)
    {
      int option;
      do
      {
        option = UserOption();
        switch (option)
        {
          case 1:
            ListAccount();
            Console.ReadLine();
            break;
          case 2:
            CreateAccount();
            Console.ReadLine();
            break;
          case 3:
            Transfer();
            Console.ReadLine();
            break;
          case 4:
            Withdraw();
            Console.ReadLine();
            break;
          case 5:
            Deposit();
            Console.ReadLine();
            break;
          default:
            throw new ArgumentOutOfRangeException();
            Console.ReadLine();
        }
      } while (option != 0);
    }

    private static void Transfer()
    {
      System.Console.WriteLine("Transfer");
      System.Console.WriteLine("Inform the origin account index:");
      int originIndex = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Inform the target account index:");
      int targetIndex = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Type the ammount you want to transfer:");
      double ammount = double.Parse(Console.ReadLine());
      accountList[originIndex].Transfer(ammount, accountList[targetIndex]);
    }

    private static void Deposit(){
      System.Console.WriteLine("Deposit");
      System.Console.WriteLine("Inform the account index:");
      int accountIndex = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Type the ammount you wish to deposit:");
      double ammount = double.Parse(Console.ReadLine());
      accountList[accountIndex].Deposit(ammount);
    }

    private static void Withdraw()
    {
      System.Console.WriteLine("Withdraw");
      System.Console.WriteLine("Inform the account index:");
      int accountIndex = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Type the ammount you wish to withdraw:");
      double ammount = double.Parse(Console.ReadLine());
      accountList[accountIndex].Withdraw(ammount);
    }

    private static void ListAccount()
    {
      System.Console.WriteLine("Account List");
      if(accountList.Count==0){
        System.Console.WriteLine("No accounts registered");
        return;
      }
      foreach(Account acc in accountList){
        System.Console.WriteLine(acc);
      }
    }

    private static void CreateAccount()
    {
      System.Console.WriteLine("Create Account");
      System.Console.WriteLine("Type 1 for Personal Account or 2 for Business Account:");
      int accountType = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Type the client name:");
      string name = Console.ReadLine();
      System.Console.WriteLine("Type the initial balance:");
      double balance = double.Parse(Console.ReadLine());
      System.Console.WriteLine("Type the credit:");
      double credit = double.Parse(Console.ReadLine());
      Account newAccount = new Account(name, balance, credit, (AccountType)accountType);
      accountList.Add(newAccount);
    }

    private static int UserOption()
    {
      System.Console.WriteLine();
      Console.Clear();
      System.Console.WriteLine("DIO Bank");
      System.Console.WriteLine("1 - List Accounts");
      System.Console.WriteLine("2 - Create Account");
      System.Console.WriteLine("3 - Transfer");
      System.Console.WriteLine("4 - Withdraw");
      System.Console.WriteLine("5 - Deposit");
      System.Console.WriteLine("0 - Exit");

      int option = int.Parse(Console.ReadLine());
      return option;
    }
  }
}
