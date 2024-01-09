using System;

namespace LinearSearchingAlgo
{
    internal class LinearSearch
    {
        public bool LinearSearchAlgo(int[] arr, int n)
        {
            // Added to GitHub Web
            Console.WriteLine("Linear Search");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine($"Element {n} found at index {i}");
                    return true;
                }
            }
            return false;
        }
    }
}
