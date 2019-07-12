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

      //LFruits.ToList().ForEach(fruit => System.Console.WriteLine(fruit));

      // Which of the following numbers are multiples of 4 or 6
      List<int> numbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

      IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

      //fourSixMultiples.ToList().ForEach(number => System.Console.WriteLine(number));



      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

      // List<string> descend = ...
      IEnumerable<string> descend = from name in names
                                    orderby name descending
                                    select name;

      //descend.ToList().ForEach(name => System.Console.WriteLine(name));


      // Build a collection of these numbers sorted in ascending order
      List<int> newNumbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};

      IEnumerable<int> sortedNumbers = from number in newNumbers
                                       orderby number ascending
                                       select number;

      //sortedNumbers.ToList().ForEach(number => System.Console.WriteLine(number));


      // Output how many numbers are in this list
      List<int> moreNumbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };


      int countOfNumbers = moreNumbers.Count;
      System.Console.WriteLine($"Count of numbers: {countOfNumbers}");

      // How much money have we made?
      List<double> purchases = new List<double>()
      {
          2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
      };


      System.Console.WriteLine($"Sum of purchases: ${purchases.Sum()}");



    }
  }
}
