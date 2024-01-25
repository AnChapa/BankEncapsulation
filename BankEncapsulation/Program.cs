namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            string doneString = "";
            double deposit = 0;
            while (doneString != "done")
            {
                Console.WriteLine("What would you like to do today?\nWe can Deposit, Withdraw, or Check your balance for you.\nIf you are finished, type Done.");
                doneString = Console.ReadLine().ToLower();
                Console.WriteLine("---------------------------------");
                switch (doneString)
                {
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit:");
                        account.Deposit(deposit = double.Parse(Console.ReadLine()));
                        Console.WriteLine($"We have deposited the ${deposit} into your account.");
                        break;
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw:");
                        deposit = double.Parse(Console.ReadLine());
                        if(deposit > account.GetBalance())
                        {
                            Console.WriteLine($"You do not have ${deposit} in your account.");
                        }
                        else
                        {
                            account.Withdraw(deposit);
                            Console.WriteLine($"We have successfully retrieved ${deposit} from your account.");
                        }
                        break;
                    case "check":
                        Console.WriteLine($"You have ${account.GetBalance()} in your account.");
                        break;
                    case "done":
                        break;
                    default:
                        Console.WriteLine("We are sorry, but this is not a valid command.");
                        break;
                }
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("Thank you for your time. We hope to serve you again.");
        }
    }
}
