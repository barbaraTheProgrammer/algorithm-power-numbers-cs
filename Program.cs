using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace problemA
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> goodNumbers = new HashSet<int>();
            HashSet<int> badNumbers = new HashSet<int>();
            ArrayList listOfNumbersToTest = new ArrayList();

            readNumbers(listOfNumbersToTest);

            foreach (int number in listOfNumbersToTest)
            {
                int tempNumber = number;
                do
                {
                    while (IsNotGood(tempNumber, badNumbers, goodNumbers)) tempNumber++;
                    tempNumber++;
                } while (IsNotGood(tempNumber, badNumbers, goodNumbers));
                Console.WriteLine((tempNumber - 1) + " " + tempNumber);
            }
        }

        public static void readNumbers(ArrayList listOfNumbersToTest)
        {
            int numberOfTests = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTests; i++)
            {
                listOfNumbersToTest.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public static bool IsNotGood(int number, HashSet<int> badNumbers, HashSet<int> goodNumbers)
        {
            if (goodNumbers.Contains(number)) return false;
            if (badNumbers.Contains(number)) return true;
            int currentValue = number;
            List<int> numbersGotWhileTesting = new List<int>();

            while (currentValue != 1)
            {
                int sumOfDigitsSquares = 0;
                sumOfDigitsSquares += countNextValue(currentValue, 0);
                if (numbersGotWhileTesting.Contains(sumOfDigitsSquares))
                {
                    badNumbers.UnionWith(numbersGotWhileTesting);
                    return true;
                }
                numbersGotWhileTesting.Add(sumOfDigitsSquares);
                currentValue = sumOfDigitsSquares;
            }
            goodNumbers.UnionWith(numbersGotWhileTesting);
            return false;
        }

        public static int countNextValue(int value, int sumOfDigitsSquares)
        {
            sumOfDigitsSquares += (int)Math.Pow(value % 10, 2);
            int digitSquare = sumOfDigitsSquares;
            if (value > 9) digitSquare = countNextValue(value / 10, sumOfDigitsSquares);
            return digitSquare;
        }
    }
}
