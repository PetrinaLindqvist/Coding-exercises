using System;
using System.Collections.Generic;

namespace Exercise {
  public class Program {
    public static void Main (string[] args) {
      // Do something here
      Dictionary<string, string> nickNames = new Dictionary<string, string> ();
      nickNames.Add ("matthew", "matt");
      nickNames.Add ("michael", "mix");
      nickNames.Add ("arthur", "artie");

      foreach (KeyValuePair<string, string> kvp in nickNames) 
      {
        Console.WriteLine ("{0}'s nickname is {1}",
          kvp.Key, kvp.Value);
      }

    }

  }
}