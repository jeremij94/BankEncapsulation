using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance = 0;

        public void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            double newDeposit = double.Parse(Console.ReadLine());
            Console.WriteLine($"Are you sure you would like to deposit ${newDeposit}?");
            var confirmation = Console.ReadLine();

            if (confirmation == "yes")
            {
                balance += newDeposit;
                Console.WriteLine("Your deposit was successful! Thank you for banking with us.");
                Console.WriteLine($"Your current balance is ${balance}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Deposit was cancelled. Thank you for banking with us!");
                Console.ReadLine();
            }
        }

        public string GetBalance()
        {
            return $"Your current balance is ${balance}";
            Console.ReadLine();
            
        }
    }
}

