using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Classic_Algorithms
{
    public static class Colatz_Conjecture_Algorithm
    {
        public static void Process() {

            Console.WriteLine("Input natural number bigger than 1:");
            bool isParsed = false;
            int inputNumber = -1;

            while (isParsed == false)
            {
                string input = Console.ReadLine();
                isParsed = int.TryParse(input, out inputNumber);
                if (inputNumber <= 1) isParsed = false;
            }

            int result = RunAlgorithm(inputNumber);
            Console.WriteLine($"Number of needed operations is {result}");
        }

        private static int RunAlgorithm(int inputNumber)
        {
            if (inputNumber == -1) return 0;
            int counter = 0;
            do
            {
                inputNumber = inputNumber % 2 == 0 ? inputNumber / 2 : inputNumber * 3 + 1;
                counter++;

            } while (inputNumber != 1);

            return counter;
        }

    }
}
