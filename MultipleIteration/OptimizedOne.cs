using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MultipleIteration
{
    public class OptimizedOne
    {
        public static void Execute()
        {
            List<string> list1 = new List<string> { "apple", "banana", "orange" };
            List<string> list2 = new List<string> { "car", "bike", "bus", "train" };
            List<string> list3 = new List<string> { "red", "blue" };
            List<string> list4 = new List<string> { "cat", "dog", "fish", "bird", "rabbit" };

            List<List<string>> allLists = new List<List<string>> { list1, list2, list3, list4 };
            List<string> currentCombination = new List<string>();

            GenerateCombinations(allLists, 0, currentCombination);
        }

        static void GenerateCombinations(List<List<string>> allLists, int currentIndex, List<string> currentCombination)
        {
            if (currentIndex == allLists.Count)
            {
                // All lists have been processed, print the combination
                string result = string.Join(",", currentCombination);
                Console.WriteLine(result);
                return;
            }

            List<string> currentList = allLists[currentIndex];
            foreach (string item in currentList)
            {
                // Add the current item to the combination
                currentCombination.Add(item);

                // Recur to the next list
                GenerateCombinations(allLists, currentIndex + 1, currentCombination);

                // Backtrack by removing the last item to explore other combinations
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
