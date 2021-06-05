using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Classic_Algorithms
{
    public static class MergeSort
    {
        public static void Process()
        {
            Console.Write("Input list of numbers: ");

            var input = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                list.Add(int.Parse(input[i]));
            }

            Console.WriteLine($"Sorted list: {string.Join(", ", MergeSortCall(list))}");

            Console.ReadLine();
        }

        public static List<int> MergeSortCall(List<int> list)
        {
            if (list.Count == 1)
            {
                return list;
            }

            int middleIndex = list.Count / 2;

            var leftList = list.Take(middleIndex).ToList<int>();
            var rightList = list.Skip(middleIndex).ToList<int>();

            return Merge(MergeSortCall(leftList), MergeSortCall(rightList));
        }

        private static List<int> Merge(List<int> leftList, List<int> rightList)
        {
            var count = leftList.Count + rightList.Count;

            var leftPointer = 0;
            var rightPointer = 0;
            var resultList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (leftPointer < leftList.Count && rightPointer < rightList.Count)
                {
                    if (leftList[leftPointer] < rightList[rightPointer])
                    {
                        resultList.Add(leftList[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        resultList.Add(rightList[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < rightList.Count)
                    {
                        //if first statement in first check (line 52) is false, second statement won't be checked
                        //so push elements remaining elements from right pool to resultList
                        resultList.Add(rightList[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        //adding of remaining elements, if right pool of elements is empty
                        resultList.Add(leftList[leftPointer]);
                        leftPointer++;
                    }
                }
            }
            return resultList;
        }
    }
}
