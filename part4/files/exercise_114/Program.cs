using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
        int count = 0;
            while (true)
            {
                string anything = Console.ReadLine();

                if (anything == "end")
                {
                    break;
                }
                count++; 
        

                }
                Console.WriteLine(count);
        }

    }
}
