﻿using System;

namespace exercise_104
{
  class Program
  {
    public static void Main(string[] args)
    {
      Multiplier multiplyByThree = new Multiplier(3);

      Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

      Multiplier multiplyByFour = new Multiplier(4);

      Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
      Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
      Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
    }
  }
}



