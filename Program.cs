using System;
using System.Linq;
using System.Collections.Generic;

namespace linqed_list
{
  class Program
  {
    static void Main(string[] args)
    {

      // find the words that start with "L"
      List<string> fruits = new List<string>() {
              "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Longberry"
          };
      IEnumerable<string> LFruits = from fruit in fruits
                                    where fruit.StartsWith("L")
                                    select fruit;

      LFruits.ToList().ForEach(fruit => System.Console.WriteLine(fruit));
    }
  }
}
