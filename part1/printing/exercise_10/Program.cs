using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string userName1 = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string userName2 = Console.ReadLine();
            Console.WriteLine("Here is the story:\n" + "Once upon a time there was a Data Scientist called " + userName1 + "\n"
            + "On her way to work, Ada often pondered what being " + userName2 + " meant to them." + "\n"
            + "When you work as a " + userName2 + " you meet interesting people." + "\n"
            + userName1 + " enjoys their work as " + userName2 + ", The end.");
        }
    }
}
