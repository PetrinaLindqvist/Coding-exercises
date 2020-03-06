using System;
using System.Collections.Generic;

namespace exercise_134
{
    class Program
    {
        public static void Main(string[] args)
        {
            GradeRegister register = new GradeRegister();

            UserInterface ui = new UserInterface(register);
            ui.Start();
           
            Console.WriteLine("The average of points: " + register.AverageOfPoints());
            Console.WriteLine("The average of grades: " + register.AverageOfGrades());
        }

    }
}
