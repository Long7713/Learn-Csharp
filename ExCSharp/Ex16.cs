using System;

namespace ExCSharp
{
    public class Ex16
    {
        public static void Run()
        {
            Console.WriteLine("=== BAI 16: NHAP VA SAP XEP MANG HO TEN (TANG DAN) ===");

            Console.Write("Nhap so luong nguoi (n): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("[!] So luong khong hop le. Mac dinh chon n = 3.");
                n = 3;
            }

            // What it means: Declares a string array to store names.
            string[] names = new string[n];
            Console.WriteLine($"Nhap ho ten cho {n} nguoi:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nguoi thu {i + 1}: ");
                names[i] = Console.ReadLine() ?? string.Empty;
            }

            Console.WriteLine("\n[Truoc khi sap xep]:");
            Console.WriteLine(string.Join(" | ", names));

            // What it means: Utilizes the native Array.Sort() method.
            // Automatically sorts string elements alphabetically (ascending order A-Z) 
            // based on standard lexicographical rules, saving us from writing complex sorting algorithms (like Bubble Sort).
            Array.Sort(names);

            Console.WriteLine("\n[Sau khi sap xep tang dan (A - Z)]:");
            Console.WriteLine(string.Join(" | ", names));
        }
    }
}