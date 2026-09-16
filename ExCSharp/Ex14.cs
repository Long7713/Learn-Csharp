using System;

namespace ExCSharp
{
    // Reason: We define an 'Employee' entity to encapsulate payroll data and logic.
    public class Employee
    {
        public string FullName { get; set; } = string.Empty;
        
        // Reason: The 'decimal' data type is the industry standard for financial 
        // and monetary calculations in C# due to its high precision and avoidance of rounding errors.
        public decimal BaseSalary { get; set; }
        
        public int DaysAbsent { get; set; }

        // Reason: A member method that encapsulates the business logic (business rules) 
        // for payroll calculation.
        public decimal CalculateFinalSalary()
        {
            // The literal suffix 'm' or 'M' tells the compiler to treat the number as a decimal type.
            decimal deduction = DaysAbsent * 100000m;
            return BaseSalary - deduction;
        }

        public void DisplayPayroll()
        {
            decimal finalSalary = CalculateFinalSalary();

            Console.WriteLine("\n=== PHIEU LUONG NHAN VIEN ===");
            Console.WriteLine($"- Ho ten: {FullName}");
            // The "N0" format string formats the number with thousands separators (e.g., 10,000,000)
            Console.WriteLine($"- Muc luong co ban: {BaseSalary:N0} VND");
            Console.WriteLine($"- So ngay vang: {DaysAbsent} ngay");
            Console.WriteLine($"- Tien phat (100k/ngay): {(DaysAbsent * 100000m):N0} VND");
            Console.WriteLine($"=> THUC LANH: {finalSalary:N0} VND");
            Console.WriteLine("=============================");
        }
    }

    public class Ex14
    {
        public static void Run()
        {
            Console.WriteLine("=== TINH LUONG NHAN VIEN ===");
            
            // Instantiate a new Employee object
            Employee emp = new Employee();

            Console.Write("Nhap ho ten nhan vien: ");
            emp.FullName = Console.ReadLine() ?? "";

            Console.Write("Nhap muc luong co ban (VND): ");
            // Robust parsing for the decimal data type
            if (decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                emp.BaseSalary = salary;
            }
            else
            {
                Console.WriteLine("Luong nhap khong hop le, gan mac dinh la 0.");
                emp.BaseSalary = 0;
            }

            Console.Write("Nhap so ngay vang: ");
            if (int.TryParse(Console.ReadLine(), out int absent))
            {
                // Prevent negative absent days for logical integrity
                emp.DaysAbsent = absent < 0 ? 0 : absent; 
            }
            else
            {
                Console.WriteLine("[!] So ngay vang khong hop le, gan mac dinh la 0.");
                emp.DaysAbsent = 0;
            }

            // Execute the output protocol
            emp.DisplayPayroll();
        }
    }
}