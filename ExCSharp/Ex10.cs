using System;

namespace ExCSharp // Nho doi ten namespace cho khop voi project cua ban nhe
{
    public class Ex10
    {
        // Reason: This member method evaluates if a string is a "Palindrome".
        // It returns a boolean (true/false).
        public static bool IsPalindrome(string input)
        {
            // Edge case handling: If the string is empty or null, it's technically not a valid palindrome to process.
            if (string.IsNullOrEmpty(input)) 
            {
                return false;
            }

            // Reason: We implement the "Two Pointers" algorithm.
            // 'left' starts at the beginning (index 0), 'right' starts at the end (Length - 1).
            int left = 0;
            int right = input.Length - 1;

            // The loop forces the pointers to move towards the center.
            while (left < right)
            {
                // If any corresponding characters mismatch, the condition is violated (false).
                // We use char.ToLower() to make the comparison case-insensitive (e.g., 'M' == 'm').
                if (char.ToLower(input[left]) != char.ToLower(input[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            
            // If the loop completes without violations, it is fundamentally a palindrome.
            return true; 
        }

        public static void Run()
        {
            Console.WriteLine("=== KIEM TRA CHUOI DOI XUNG ===");
            Console.Write("Nhap vao mot chuoi: ");
            string? text = Console.ReadLine();

            // Null-forgiving operator (!) ensures 'text' is treated as non-null for the method argument.
            if (IsPalindrome(text!))
            {
                Console.WriteLine($"-> Chuoi '{text}' LA chuoi doi xung.");
            }
            else
            {
                Console.WriteLine($"-> Chuoi '{text}' KHONG phai la chuoi doi xung.");
            }
        }
    }
}