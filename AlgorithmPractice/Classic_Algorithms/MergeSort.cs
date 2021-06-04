using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Classic_Algorithms
{
    public static class MergeSort
    {
        public static int[] Process() 
        {
            Console.WriteLine("Input number array for sort (whitespace separator):");
            var stringArray = Console.ReadLine().Split(' ');
            var intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            var sortedArray = MergeSortCall(intArray);
            return new int[5];
        }

        public static int[] MergeSortCall(int[] intArray) 
        {
            var buff = new int[intArray.Length];

            return null;        
        }
    }
}
