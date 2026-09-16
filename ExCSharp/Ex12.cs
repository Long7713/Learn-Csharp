using System;

namespace ExCSharp 
{
    public class Ex12
    {
        // Reason: We extract the word-counting logic into a separate member method.
        // This adheres to the Single Responsibility Principle (SRP) in software design.
        public static int CountWords(string input)
        {
            // Edge case: string.IsNullOrWhiteSpace checks if the string is null, 
            // completely empty (""), or consists only of whitespace characters (like spaces or tabs).
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            // Reason: The Split() method divides a string into an array of substrings.
            // We pass an array of delimiters (space, tab, newline) to define where to cut.
            // CRITICAL: StringSplitOptions.RemoveEmptyEntries is used to filter out empty strings 
            // that occur when the user types multiple consecutive spaces (e.g., "Hello    World").
            char[] delimiters = new char[] { ' ', '\t', '\n' };
            string[] wordsArray = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Reason: The Length property of an array returns the total number of its elements.
            return wordsArray.Length;
        }

        public static void Run()
        {
            Console.WriteLine("=== XU LY CHUOI: HOA, THUONG, DEM TU ===");
            Console.Write("Nhap vao mot chuoi gom nhieu tu: ");
            string? input = Console.ReadLine();

            // Safely default to an empty string if null is encountered.
            string text = input ?? "";

            // Step 1: Convert to lowercase
            // Reason: ToLower() returns a copy of the string converted to lowercase.
            string lowerCaseText = text.ToLower();

            // Step 2: Convert to uppercase
            // Reason: ToUpper() returns a copy of the string converted to uppercase.
            string upperCaseText = text.ToUpper();

            // Step 3: Count the words
            int wordCount = CountWords(text);

            // Output the formatted results
            Console.WriteLine("\n>> KET QUA:");
            Console.WriteLine($"- Chuoi in thuong: {lowerCaseText}");
            Console.WriteLine($"- Chuoi in hoa: {upperCaseText}");
            Console.WriteLine($"- So luong tu trong chuoi: {wordCount} tu");
        }
    }
}