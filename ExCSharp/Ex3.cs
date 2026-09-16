using System;
namespace ExCSharp
{
    public class Ex3
    {
        public static void Run()
        {
            //We prompt the user for the base integer. Console.Write() keeps the cursor on the same line.
            Console.Write("Nhap so nguyen x: ");
            
            //Console.ReadLine() strictly returns a string. We employ int.Parse() to explicitly 
            // convert this string sequence into an integer (int) data type, which is mandatory for mathematical operations.
            // The null-forgiving operator (!) ensures the compiler ignores the CS8600 null warning.
            int x = int.Parse(Console.ReadLine()!);

            // Reason: We prompt the user for the exponent integer.
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine()!);

            // Reason: The Math.Pow() method from the System namespace calculates a number raised to a specified power.
            // Note that Math.Pow() inherently returns a 'double' (floating-point numeric type) to accommodate 
            // potentially massive results, even if the inputs are integers.
            double result = Math.Pow(x, y);

            // Reason: String interpolation ($) is utilized to dynamically construct the final announcement,
            // directly embedding the variables x, y, and the computed 'result' into the console output.
            Console.WriteLine($"Ket qua {x} mu {y} la: {result}");
        }
    }
}