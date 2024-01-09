using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Elements:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to be searched");
            int find = int.Parse(Console.ReadLine());

            LinearSearch linearSearch = new LinearSearch();
            if(linearSearch.LinearSearchAlgo(arr, find) == true)
            {
                Console.WriteLine("Search Complete");
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }
        }
    }
}
