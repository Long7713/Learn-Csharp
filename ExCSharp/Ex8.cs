using System;

namespace ExCSharp
{
    public class Ex8
    {
        // Reason: The 'ref' (reference) keyword modifies the parameter passing mechanism.
        // Instead of passing a copy of the variable's value (Pass by Value), 
        // it passes a reference to the actual memory address (Pass by Reference).
        // Consequently, any modifications made to 'a' and 'b' inside this method 
        // will directly reflect on the original variables passed from the caller.
        public static void Swap(ref double a, ref double b)
        {
            // Reason: A temporary variable ('temp') is mandatory for a standard swap operation.
            // Without it, assigning 'a = b' would overwrite and permanently lose the original value of 'a'.
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Run()
        {
            Console.WriteLine("=== HOAN VI HAI SO THUC (SU DUNG REF) ===");
            
            Console.Write("Nhap so thuc thu nhat (x): ");
            double.TryParse(Console.ReadLine(), out double x);

            Console.Write("Nhap so thuc thu hai (y): ");
            double.TryParse(Console.ReadLine(), out double y);

            // Display states before the swap operation
            Console.WriteLine($"\n[Truoc khi hoan vi]: x = {x}, y = {y}");

            // Reason: When invoking a method that defines 'ref' parameters, 
            // C# enforces the explicit use of the 'ref' keyword at the call site as well.
            // This is a safety feature, making the programmer visually acknowledge 
            // that the variables 'x' and 'y' are subject to external modification.
            Swap(ref x, ref y);

            // Display states after the swap operation to prove the memory was altered
            Console.WriteLine($"[Sau khi hoan vi]: x = {x}, y = {y}");
        }
    }
}