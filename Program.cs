using System;
using System.Collections.Generic;

namespace PairsGivenSum
{
    class Program
    {
        /// <summary>
        /// Given an array of integers, finds all the pairs that add up to a specified sum.
        /// </summary>
        /// <remarks>
        /// Order of the integers per pair returned does NOT matter.
        /// </remarks>
        /// <param name="arr">The array of numbers</param>
        /// <param name="sum">The target sum</param>
        /// <returns>A list of integer arrays of length 2, containing all the pairs</returns>
        static List<int[]> FindPairsGivenSum(int[] arr, int sum)
        {
            List<int[]> result = new List<int[]>(arr.Length); // Result to be returned.
            HashSet<int> visited = new HashSet<int>(arr.Length); // All the visited integers.

            for (int i = 0; i < arr.Length; ++i)
            {
                // The remainder should be one of the numbers visited before to make a pair.
                int remainder = sum - arr[i];
                if (visited.Contains(remainder))
                {
                    result.Add(new int[2] { arr[i], remainder });
                }
                visited.Add(arr[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<int[]> pairs = FindPairsGivenSum(new int[] { 5, 8, 9, 6, -4, 18 }, 14);
            Console.WriteLine($"{pairs.Count} pair(s) found.");
            foreach (int[] pair in pairs)
            {
                Console.WriteLine(string.Join(", ", pair));
            }
        }
    }
}
