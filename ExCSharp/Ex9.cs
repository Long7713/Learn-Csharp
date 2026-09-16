using System;

namespace ExCSharp
{
    public class Ex9
    {
        // Reason: A standard method can only return a single value via the 'return' keyword. 
        // When a method needs to yield multiple results (both minimum and maximum), 
        // using 'out' parameters is the industry-standard approach.
        // Unlike 'ref', 'out' parameters do not require prior initialization from the caller. 
        // However, this method is strictly obligated by the compiler to assign them a valid 
        // value before it terminates.
        public static void FindMinMax(double a, double b, double c, out double min, out double max)
        {
            // Reason: We utilize the nested Math.Min and Math.Max methods for concise evaluation.
            // The calculated results are directly assigned to the corresponding 'out' parameters.
            min = Math.Min(a, Math.Min(b, c));
            max = Math.Max(a, Math.Max(b, c));
            
            // Note: If we forget to assign a value to 'min' or 'max' before the closing brace '}', 
            // the C# compiler will actively block the build with error CS0177.
        }

        public static void Run()
        {
            Console.WriteLine("=== TIM MIN - MAX CUA 3 SO THUC (SU DUNG OUT) ===");
            
            Console.Write("Nhap so thuc thu nhat (a): ");
            double.TryParse(Console.ReadLine(), out double a);

            Console.Write("Nhap so thuc thu hai (b): ");
            double.TryParse(Console.ReadLine(), out double b);

            Console.Write("Nhap so thuc thu ba (c): ");
            double.TryParse(Console.ReadLine(), out double c);

            // Reason: C# 7.0 introduced "inline out variable declaration". 
            // We can elegantly declare 'minValue' and 'maxValue' right inside the method call. 
            // This eliminates the cumbersome need to declare them on separate lines beforehand, 
            // resulting in much cleaner and more readable code.
            FindMinMax(a, b, c, out double minValue, out double maxValue);

            // Output the multiple values extracted via the 'out' parameters.
            Console.WriteLine($"\nTrong 3 so ({a}, {b}, {c}):");
            Console.WriteLine($">> Gia tri NHO NHAT (Min) la: {minValue}");
            Console.WriteLine($">> Gia tri LON NHAT (Max) la: {maxValue}");
        }
    }
}