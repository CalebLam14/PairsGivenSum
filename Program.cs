using System;
using System.Collections;
using System.Collections.Generic;

namespace PairsGivenSum
{
    class Program
    {
        
        static List<int[]> FindPairsGivenSum(int[] arr, int sum)
        {
            List<int[]> result = new List<int[]>(arr.Length);
            HashSet<int> visited = new HashSet<int>(arr.Length);

            for (int i = 0; i < arr.Length; ++i)
            {
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
            List<int[]> pairs = FindPairsGivenSum(new int[5] { 5, 8, 9, -4, 11 }, 4);
            Console.WriteLine($"{pairs.Count} pair(s) found.");
            foreach (int[] pair in pairs)
            {
                Console.WriteLine(string.Join(", ", pair));
            }
        }
    }
}
