using System;

namespace extra_16 {
  class Program {
    public static void Main (string[] args) {
      // Add your code here:
      Person informative = new Person ("Master Blaster", 300, 200, 200);
      Person lightweight = new Person ("Youngling", 25);
      Person baby = new Person ("Waa");

      Console.WriteLine (informative);
      Console.WriteLine (lightweight);
      Console.WriteLine (baby);
    }
  }
}