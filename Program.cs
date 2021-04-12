using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            char[,] charMatrix = new char[numb, numb];

            bool isFound = false;

            for (int row = 0; row < charMatrix.GetLength(0); row++)
            {
                string lineSymbols = Console.ReadLine();

                for (int col = 0; col < charMatrix.GetLength(1); col++)
                {
                    charMatrix[row, col] = lineSymbols[col];
                }
            }

            char currGivenSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < numb; row++)
            {
                for (int col = 0; col < numb; col++)
                {
                    if (charMatrix[row, col] == currGivenSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }                    
                }

                if (isFound == true)
                {
                    break;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{currGivenSymbol} does not occur in the matrix ");
            }
        }
    }
}
