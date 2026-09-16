using System;

namespace ExCSharp 
{
    public class Ex11
    {
        // Reason: This member method computes and returns the reversed iteration of the given string.
        public static string ReverseString(string input)
        {
            // Null check to prevent exceptions.
            if (string.IsNullOrEmpty(input)) 
            {
                return "";
            }

            // Step 1: Convert the immutable string into a mutable character array.
            char[] charArray = input.ToCharArray();

            // Step 2: Utilize the built-in Array.Reverse() method. 
            // This is a highly optimized native method for in-place array reversal.
            Array.Reverse(charArray);

            // Step 3: Reconstruct a new string entity from the reversed character array and return it.
            return new string(charArray);
        }

        public static void Run()
        {
            Console.WriteLine("=== DAO NGUOC CHUOI ===");
            Console.Write("Nhap vao mot chuoi bat ky: ");
            string? originalText = Console.ReadLine();

            // We invoke the method and capture the newly constructed reversed string.
            string reversedText = ReverseString(originalText!);

            Console.WriteLine($"\n>> Chuoi goc: {originalText}");
            Console.WriteLine($">> Chuoi dao nguoc: {reversedText}");
        }
    }
}