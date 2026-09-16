using System;

namespace ExCSharp
{
    public class Ex5
    {
        public static void Run()
        {
            // Reason: We declare the variables 'x' and 'y' outside the loop block. 
            // This is crucial for variable "scope" management. If we declared them inside the loop, 
            // their values would be erased and reset every time the loop restarts.
            // We use 'double' to accommodate real numbers (floating-point data type).
            double x = 0;
            double y = 0;
            
            // A boolean flag to control the execution flow of our menu loop.
            bool isRunning = true;

            // Reason: We implement a 'do-while' loop. This iteration structure guarantees 
            // that the code block (the menu interface) is executed at least once before 
            // evaluating the termination condition (isRunning).
            do
            {
                Console.WriteLine("\n=== MENU BAI 5 ===");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang theo so thu tu : ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Nhap so thuc x: ");
                        // Reason: We utilize double.TryParse() for robust validation. 
                        // It safely attempts to parse the string into a double without throwing runtime exceptions.
                        if (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Loi: Gia tri x khong phai so thuc hop le!");
                        }
                        
                        Console.Write("Nhap so thuc y: ");
                        if (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.WriteLine("Loi: Gia tri y khong phai so thuc hop le!");
                        }
                        break;

                    case "2":
                        // Reason: Math.Pow() inherently accepts and returns 'double' values, 
                        // making it perfectly compatible with our variables.
                        double powerResult = Math.Pow(x, y);
                        Console.WriteLine($"Ket qua {x}^{y} = {powerResult}");
                        break;

                    case "3":
                        // Reason: Math.Sqrt() computes the square root. However, mathematically, 
                        // the square root of a negative number is undefined in real numbers. 
                        // In C#, it yields 'NaN' (Not a Number). We apply conditional statements 
                        // to prevent illogical mathematical operations.
                        if (x >= 0) 
                            Console.WriteLine($"Can bac 2 cua {x} la: {Math.Sqrt(x)}");
                        else 
                            Console.WriteLine($"Khong the tinh can bac 2 cua {x} vi x la so am.");

                        if (y >= 0) 
                            Console.WriteLine($"Can bac 2 cua {y} la: {Math.Sqrt(y)}");
                        else 
                            Console.WriteLine($"Khong the tinh can bac 2 cua {y} vi y la so am.");
                        break;

                    case "4":
                        // Reason: By setting the boolean flag to false, we instruct the program 
                        // to terminate the iteration at the end of the current cycle.
                        isRunning = false;
                        Console.WriteLine("Da thoat menu Bai 5.");
                        break;

                    default:
                        Console.WriteLine("Loi: Vui long chon chuc nang tu 1 den 4!");
                        break;
                }
            } while (isRunning);
        }
    }
}