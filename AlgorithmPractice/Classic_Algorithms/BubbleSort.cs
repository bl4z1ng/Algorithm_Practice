using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Classic_Algorithms
{
    public class BubbleSort
    {
        public static List<int> inputNumbersList;
        public static void Process()
        {
            Console.Write("Input list of numbers: ");

            var input = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);

            inputNumbersList = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                inputNumbersList.Add(int.Parse(input[i]));
            }

            Console.WriteLine($"Sorted list: {string.Join(", ", Sort())}");

            Console.ReadLine();
        }

        public static List<int> Sort() 
        {
            var count = inputNumbersList.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var a = inputNumbersList[i];
                    var b = inputNumbersList[i + 1];
                    if (a > b)
                    {
                        Swop(i, i + 1);
                    }
                }
            }

            return inputNumbersList;
        }   

        public static void Swop(int posA, int posB) 
        {
            if (posA< inputNumbersList.Count && posB< inputNumbersList.Count)
            {
                int buff = inputNumbersList[posA];
                inputNumbersList[posA] = inputNumbersList[posB];
                inputNumbersList[posB] = buff;
            }

        }
    }
}
