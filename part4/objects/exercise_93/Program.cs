using System;

namespace exercise_93
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            Account lisasAccount = new Account("Lisa's account", 100.00);
            
            lisasAccount.Deposit(20);
            
            Console.WriteLine(lisasAccount.balance);
            
            
            
        }
    }
}



