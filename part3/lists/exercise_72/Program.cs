using System;
using System.Collections.Generic;

namespace exercise_72
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }

            int smallest = list[0];


            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];

                if (smallest > number)
                {
                    smallest = number;
                }


            }
                Console.WriteLine("Smallest number: " + smallest);

            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                if (smallest == number)
                {

                    Console.WriteLine("Found at index: " + i);
                }

            }
        }

    }
}