using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleIteration
{
    public static class OptimizedTwo
    {
        public static void Execute()
        {
            List<string> list1 = new List<string> { "apple", "banana", "orange" };
            List<string> list2 = new List<string> { "car", "bike", "bus", "train" };
            List<string> list3 = new List<string> { "red", "blue" };
            List<string> list4 = new List<string> { "cat", "dog", "fish", "bird", "rabbit" };

            List<List<string>> allLists = new List<List<string>> { list1, list2, list3, list4 };
            List<List<string>> result = GenerateCombinations(allLists, 0, new List<string>());

            // Print or use the result as needed
            foreach (List<string> combination in result)
            {
                string resultString = string.Join(",", combination);
                Console.WriteLine(resultString);
            }
        }

        private static List<List<string>> GenerateCombinations(List<List<string>> allLists, int currentIndex, List<string> currentCombination)
        {
            List<List<string>> result = new List<List<string>>();

            if (currentIndex == allLists.Count)
            {
                // Base case: All lists have been processed, add the current combination to the result
                result.Add(new List<string>(currentCombination));
                return result;
            }

            List<string> currentList = allLists[currentIndex];
            foreach (string item in currentList)
            {
                // Add the current item to the combination
                currentCombination.Add(item);

                // Recur to the next list and get the combinations
                List<List<string>> subCombinations = GenerateCombinations(allLists, currentIndex + 1, currentCombination);
                result.AddRange(subCombinations);

                // Backtrack by removing the last item to explore other combinations
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }

            return result;
        }
    }
    
}
