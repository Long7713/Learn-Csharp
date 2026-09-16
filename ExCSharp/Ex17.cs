using System;
using System.Collections.Generic;

namespace ExCSharp
{
 
    public class MatrixProcessor
    {
        // What it means: Generates a 2D array (matrix) of size n x m with random values within [10, 100].
        //  Automates data population, saving time compared to manual entry for large matrices.
        public static int[,] GenerateMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // rand.Next(minValue, maxValueExclusive) -> generates numbers from 10 up to 100
                    matrix[i, j] = rand.Next(10, 101);
                }
            }
            return matrix;
        }

        // What it means: Prints the 2D array in a structured, matrix-like layout.
        // Provides clear visual formatting so rows and columns align neatly.
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Print each element with fixed width formatting for a clean grid look
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine(); // Newline after each row
            }
        }

        // What it means: Splits all elements of the 2D matrix into two separate 1D arrays of evens and odds.
        // Demonstrates how to use 'out' parameters to return multiple collections simultaneously.
        public static void ExtractEvensAndOdds(int[,] matrix, out int[] evens, out int[] odds)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = matrix[i, j];
                    if (value % 2 == 0)
                    {
                        evenList.Add(value);
                    }
                    else
                    {
                        oddList.Add(value);
                    }
                }
            }

            // Convert lists back to standard arrays via out parameters
            evens = evenList.ToArray();
            odds = oddList.ToArray();
        }
    }

  
    public class Ex17
    {
        public static void Run()
        {
            Console.WriteLine("=== BAI 17: XU LY MANG HAI CHIEU (MATRIX) ===");

            Console.Write("Nhap so hang (n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0) n = 3;

            Console.Write("Nhap so cot (m): ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0) m = 3;

            // Step 1: Generate the random 2D array
            int[,] matrix = MatrixProcessor.GenerateMatrix(n, m);

            Console.WriteLine($"\n>> Ma tran ngau nhien ({n}x{m}) trong doan [10, 100]:");
            MatrixProcessor.PrintMatrix(matrix);

            // Step 2: Extract evens and odds using out parameters
            MatrixProcessor.ExtractEvensAndOdds(matrix, out int[] evenArray, out int[] oddArray);

            // Step 3: Display results
            Console.Write("\n>> Mang cac so CHAN: ");
            Console.WriteLine(evenArray.Length > 0 ? $"[{string.Join(", ", evenArray)}]" : "(Khong co)");

            Console.Write(">> Mang cac so LE: ");
            Console.WriteLine(oddArray.Length > 0 ? $"[{string.Join(", ", oddArray)}]" : "(Khong co)");
        }
    }
}