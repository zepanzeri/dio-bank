using System;

namespace dio_bank
{
  class Program
  {
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
