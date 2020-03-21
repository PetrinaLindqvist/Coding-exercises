using System;
using System.Collections.Generic;

namespace exercise_113
{
    class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> list = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string title = Console.ReadLine();
                if (title == "")
                {
                    break;
                }


                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());


                Console.Write("Publication year: ");
                string year = Console.ReadLine();

                list.Add(new Book(title, pages, year));
            }
            Console.WriteLine();
            Console.Write("What information will be printed? ");
            string anything = Console.ReadLine();

            foreach (Book item in list)
            {
                if (anything == "everything")

                {
                    Console.WriteLine(item);
                }
                else if (anything == "title")
                {
                    Console.WriteLine(item.title);
                }
                else
                {
                    break;
                }

            }


        }
    }
}




