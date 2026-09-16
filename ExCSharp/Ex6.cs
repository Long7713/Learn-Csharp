using System;

namespace ExCSharp
{
    public class Ex6
    {
        // Reason: Unlike previous methods that used 'void' (meaning they return nothing), 
        // this method explicitly declares an 'int' return type. 
        // It accepts three integer parameters (arguments) to process.
        public static int FindMax(int a, int b, int c)
        {
            // Approach 1: Using the built-in Math library (Professional & Concise)
            // Math.Max only compares two numbers at a time. By nesting them, 
            // we effectively compare 'a' with the larger of 'b' and 'c'.
            return Math.Max(a, Math.Max(b, c));

            /* 
            //Above function is tell How function max going, this only choose 2 vairiable to compare
            */
        }

        // The main execution method called from your Program.cs menu( also have function to put in value for vairiablex`)
        public static void Run()
        {
            Console.WriteLine("=== TIM SO LON NHAT TRONG 3 SO ===");
            
            // To keep the code clean for this specific lesson about 'return', 
            // we use TryParse but omit the strict error messages if the user types letters. 
            // If they type letters, TryParse simply defaults the variable to 0 safely.
            Console.Write("Nhap so nguyen thu nhat (a): ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.Write("Nhap so nguyen thu hai (b): ");
            int.TryParse(Console.ReadLine(), out int b);

            Console.Write("Nhap so nguyen thu ba (c): ");
            int.TryParse(Console.ReadLine(), out int c);

            // Reason: We invoke (call) the FindMax method and capture its returned value 
            // into a new local variable named 'maxValue'.
            int maxValue = FindMax(a, b, c);

            // Display the result
            Console.WriteLine($"\n>> Gia tri lon nhat trong 3 so ({a}, {b}, {c}) la: {maxValue}");
        }
    }
}