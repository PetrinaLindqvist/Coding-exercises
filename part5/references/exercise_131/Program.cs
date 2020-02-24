using System;
using System.Collections.Generic;

namespace exercise_131
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string identifier = Console.ReadLine();
                if (identifier == "")
                {
                    break;
                }
                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                Item item = new Item(identifier, name);
                if (items.Contains(item))
                {
                    continue;
                }
                else
                {
                    items.Add(item);
                }
            }
            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

        }

    }
}
