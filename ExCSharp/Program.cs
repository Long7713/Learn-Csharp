using System;
namespace ExCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher please chooose which exercise u want to run
            Console.WriteLine("=== TONG HOP BAI TAP ===");
            Console.WriteLine("Chon bai muon chay (1 - 15): ");
            
            // Convert the input string into an integer (int)
            // Use int.TryParse to handle cases where the user enters random letters instead of a number
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                //switch case: checking result and choose one of case
                switch(choice)
                {
                    case 1:
                        Ex1.Run();
                        Console.WriteLine("Chuong trinh Baitap1 dang chay");
                        break;
                    case 2:
                        Ex2.Run();
                        Console.WriteLine("Chuong trinh Baitap2 dang chay");
                        break;
                    case 3:
                        Ex3.Run();
                        Console.WriteLine("Chuong trinh Baitap3 dang chay");
                        break;
                    case 4:
                        Ex4.Run();
                        Console.WriteLine("Chuong trinh Baitap4 dang chay");
                        break;
                    case 5:
                        Ex5.Run();
                        Console.WriteLine("Chuong trinh Baitap5 dang chay");
                        break;
                    case 6:
                        Ex6.Run();
                        Console.WriteLine("Chuong trinh Baitap6 dang chay");
                        break;
                    case 7:
                        Ex7.Run();
                        Console.WriteLine("Chuong trinh Baitap7 dang chay");
                        break;
                
                    default:
                        Console.WriteLine("Loi: Chi co cac bai tap tu 1 den 15 thoi!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Loi:Vui long nhap dung so luong bai tap 1-15");
            }
                Console.WriteLine("\nNhan phím bat ky de thoat...");
                Console.ReadKey();
        }
    }
}
