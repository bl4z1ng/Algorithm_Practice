using AlgorithmPractice.Classic_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Program
    {
        public static IList<string> Algorithm_Collection = new List<string> { "1. Colatz_Conjecture" };

        static void Main()
        {
            Console.WriteLine("Choose algorythm:");
            foreach (var item in Algorithm_Collection)
            {
                Console.WriteLine(item);
            }
            string key = Console.ReadLine();

            switch (key)
            {
                case "1":
                    Colatz_Conjecture_Algorithm.Process();
                    break;
                case "2":
                    MergeSort.Process();
                    break;
                default:
                    break;
            }
        }
    }

}
