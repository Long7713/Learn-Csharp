using System;

namespace ExCSharp
{
    public class Ex7
    {
        // Reason: The method signature declares a 'bool' return type.
        // It strictly evaluates the mathematical condition of being a prime number
        // and returns 'true' if the condition is met, or 'false' otherwise.
        public static bool IsPrime(int n)
        {
            // By mathematical definition, prime numbers are integers strictly greater than 1.
            if (n < 2) 
            {
                return false;
            }

            // Optimization: We iterate only up to the square root of 'n' (i * i <= n).
            // This significantly reduces the time complexity. If 'n' has a divisor greater 
            // than its square root, it logically must have a corresponding divisor smaller than it.
            for (int i = 2; i * i <= n; i++)
            {
                // The modulo operator (%) calculates the remainder of a division.
                // If the remainder is 0, 'n' is completely divisible by 'i', hence not a prime.
                if (n % i == 0) 
                {
                    return false;
                }
            }

            // If the loop completes without returning false, the number is confirmed as prime.
            return true;
        }

        // The execution method
        public static void Run()
        {
            Console.WriteLine("=== KIEM TRA SO NGUYEN TO ===");
            Console.Write("Nhap vao so nguyen n: ");
            
            // Robust parsing to prevent application crash on invalid inputs
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // Reason: Since IsPrime(n) returns a boolean value, it acts as a logical statement.
                // We can seamlessly embed it directly within the 'if' condition statement.
                if (IsPrime(n))
                {
                    Console.WriteLine($"-> {n} la so nguyen to.");
                }
                else
                {
                    Console.WriteLine($"-> {n} KHONG phai la so nguyen to.");
                }
            }
            else
            {
                Console.WriteLine("Loi: Vui long nhap mot so nguyen hop le!");
            }
        }
    }
}