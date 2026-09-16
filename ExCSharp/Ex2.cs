using System;
namespace ExCSharp
{
       public class Ex2
    {
        public static void Run()
        {
            // We use Console.Write() instead of Console.WriteLine() here. 
            // Reason: It displays the prompt without terminating the line. 
            // This allows the user's keystrokes to appear on the exact same line as the prompt.
            Console.Write("Nhap ho ten cua ban: ");
            
            // RConsole.ReadLine() captures the sequence of characters typed by the user. 
            // The input reading process terminates immediately when the user presses the 'Enter' key.
            // We consciously declare the variable as a nullable string ('string?') to prevent 
            // the CS8600 warning, ensuring the code complies with strict null-safety rules.
            string? HoTen = Console.ReadLine();
            
            // The '$' prefix initiates "string interpolation". This syntax allows us 
            // to seamlessly embed the variable 'hoTen' directly within the string literal, 
            // which is much cleaner than using the '+' operator for concatenation. 
            // Console.WriteLine() then prints this formatted string and appends a line break.
            Console.WriteLine($"Chao ban {HoTen}!");
        }
    }
}