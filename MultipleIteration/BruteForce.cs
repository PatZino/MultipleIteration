using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleIteration
{
    public static class BruteForce
    {
        public static void Execute()
        {
            List<string> list1 = new List<string> { "apple", "banana", "orange" };
            List<string> list2 = new List<string> { "car", "bike", "bus", "train" };
            List<string> list3 = new List<string> { "red", "blue" };
            List<string> list4 = new List<string> { "cat", "dog", "fish", "bird", "rabbit" };

            // Iterate through the lists using nested loops
            foreach (string item1 in list1)
            {
                foreach (string item2 in list2)
                {
                    foreach (string item3 in list3)
                    {
                        foreach (string item4 in list4)
                        {
                            // Combine the elements and print the result
                            string result = $"{item1},{item2},{item3},{item4}";
                            Console.WriteLine(result);
                        }
                    }
                }
            }
        }
    }
}
