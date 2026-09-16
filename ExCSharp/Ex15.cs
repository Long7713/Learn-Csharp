using System;
using System.Collections.Generic;

namespace ExCSharp
{
    // What it means: Defines a class to encapsulate various array operations.
    public class ArrayProcessor
    {
        // What it means: A member method to input array elements dynamically.
        // Allows the user to populate an integer array of custom size 'n' at runtime.
        public static int[] InputArray()
        {
            Console.Write("Nhap so luong phan tử n: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("[!] Gia tri n khong hop le. Mac dinh chon n = 5.");
                n = 5;
            }

            int[] arr = new int[n];
            Console.WriteLine($"Nhap {n} phan tu cho mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Phan tu thu {i} [{i + 1}]: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("[!] Vui long nhap vao mot so nguyen hop le: ");
                }
            }
            return arr;
        }

        // What it means: A member method to render array elements to the console.
        //Provides visual feedback of the current array state to the user.
        public static void PrintArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("[!] Mang đang trong.");
                return;
            }
            // string.Join compactly concatenates array elements separated by a space and a comma
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        // What it means: Finds both the minimum and maximum values using 'out' parameters.
        //Efficiently retrieves multiple results from a single method execution.
        public static void FindMinMax(int[] arr, out int min, out int max)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Mang khong duoc trong.");
            }

            min = arr[0];
            max = arr[0];

            foreach (int val in arr)
            {
                if (val < min) min = val;
                if (val > max) max = val;
            }
        }

        // Helper method to check if a number is prime
        private static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // What it means: Scans the array and returns a new sub-array containing only prime numbers.
        //Utilizes List<T> dynamically to filter specific elements based on mathematical business rules.
        public static int[] GetPrimes(int[] arr)
        {
            List<int> primeList = new List<int>();
            foreach (int num in arr)
            {
                if (IsPrime(num))
                {
                    primeList.Add(num);
                }
            }
            // Convert List back to a standard array
            return primeList.ToArray();
        }
    }

    public class Ex15
    {
        public static void Run()
        {
            Console.WriteLine("=== BAI 15: THAO TAC VOI MANG SO NGUYEN ===");
            int[] myArray = ArrayProcessor.InputArray();

            Console.Write("\n>> Mang ban vua nhap: ");
            ArrayProcessor.PrintArray(myArray);

            // Find Min & Max
            ArrayProcessor.FindMinMax(myArray, out int minVal, out int maxVal);
            Console.WriteLine($">> Phan tu NHO NHAT la: {minVal}");
            Console.WriteLine($">> Phan tu LON NHAT la: {maxVal}");

            // Get Primes
            int[] primes = ArrayProcessor.GetPrimes(myArray);
            Console.Write(">> Cac so nguyen to trong mang: ");
            ArrayProcessor.PrintArray(primes);
        }
    }
}