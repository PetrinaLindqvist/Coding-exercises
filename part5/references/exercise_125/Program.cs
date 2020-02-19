using System;

namespace exercise_125
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            // Create new Station
            HealthStation childrensHospital = new HealthStation();

            // Create two new persons
            Person ethan = new Person("Ethan", 1, 110, 7);
            Person peter = new Person("Peter", 33, 176, 85);

            // Try out the Persons and method Weigh
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Test feeding the persons
            childrensHospital.Feed(ethan);
            childrensHospital.Feed(peter);

            // See that the weights have changed
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Keep weighing to increase the 'int weighings'
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);

            // See that the variable has increased to 8
            Console.WriteLine("weighings performed: " + childrensHospital.weighings);
        }
    }
}

