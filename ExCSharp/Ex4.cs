using System;

namespace ExCSharp
{
    public class Ex4
    {
        public static void Run()
        {
            Console.Write("Nhap so nguyen x: ");
            
            // Reason: We utilize int.TryParse() as a safe parsing mechanism to evaluate the input.
            // Unlike int.Parse(), which throws a runtime exception (terminates the program abruptly) 
            // upon invalid input, TryParse handles it safely. 
            // The "out" keyword indicates that the method will output the parsed integer into the variable 'x'.
            // If the conversion is successful, it returns true. If it fails, it returns false.
            // The '!' operator negates the result, meaning: "If the parsing is NOT successful..."
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                // Display a clear error message and terminate the current method execution.
                Console.WriteLine("Loi: x khong phai la so nguyen hop le!");
                return; 
            }

            Console.Write("Nhap so nguyen y: ");
            
            // Replicate the robust validation for the exponent variable 'y'.
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Loi: y khong phai la so nguyen hop le!");
                return;
            }

            // Execute the mathematical computation.
            double result = Math.Pow(x, y);
            
            // Display the final output using string interpolation.
            Console.WriteLine($"Ket qua {x} mu {y} la: {result}");
        }
    }
}