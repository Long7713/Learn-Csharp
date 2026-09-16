using System;

namespace ExCSharp 
{
    // Reason: We define a 'Student' class acting as a blueprint (khuôn mẫu) 
    // to encapsulate (đóng gói) all related data pertaining to a single student entity.
    public class Student
    {
        // Reason: We utilize Auto-Implemented Properties (get; set;) instead of raw variables.
        // This is a strict C# convention providing secure data encapsulation.
        // 'string.Empty' is the formal equivalent of an empty string "".
        public string StudentID { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int YearOfStudy { get; set; }

        // Reason: A member method explicitly responsible for displaying the object's internal state.
        public void DisplayInfo()
        {
            Console.WriteLine("\n=== THONG TIN KET XUAT ===");
            Console.WriteLine($"Ma SV: {StudentID}");
            Console.WriteLine($"Ho ten: {FullName}");
            Console.WriteLine($"Dia chi: {Address}");
            Console.WriteLine($"Sinh vien nam thu: {YearOfStudy}");
            Console.WriteLine("==========================");
        }
    }

    public class Ex13
    {
        public static void Run()
        {
            Console.WriteLine("=== NHAP THONG TIN SINH VIEN ===");
            
            // Reason: We instantiate (khởi tạo) a new object of type 'Student' 
            // allocating memory in the RAM using the 'new' keyword.
            Student myStudent = new Student();

            // Object population (Gán giá trị cho các thuộc tính của đối tượng)
            Console.Write("Nhap ma sinh vien: ");
            myStudent.StudentID = Console.ReadLine() ?? "";

            Console.Write("Nhap ho ten: ");
            myStudent.FullName = Console.ReadLine() ?? "";

            Console.Write("Nhap dia chi: ");
            myStudent.Address = Console.ReadLine() ?? "";

            Console.Write("Sinh vien nam thu may (bang so): ");
            // Robust parsing with a default fallback (Gán giá trị mặc định nếu nhập sai)
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                myStudent.YearOfStudy = year;
            }
            else
            {
                myStudent.YearOfStudy = 1; 
                Console.WriteLine("[!] Nam hoc khong hop le, he thong tu dong luu mac dinh la nam 1.");
            }

            // Reason: We invoke the member method to execute the output protocol.
            myStudent.DisplayInfo();
        }
    }
}