using System;
namespace ExCSharp
{
       public class Ex1
    {
        public static void Run()
        {
            //Step 1: Notify Input name
            //Using Console.Write() to print word on screen (Not line break)
            Console.Write("Please input your name please");
            
            //Step 2: Typing in4 from keyboard
            //Using Console.ReadLine() read a string from user type in
            //"Hoten" variable have type is string
            string ? HoTen = Console.ReadLine();

            //Step 3: Print result in screen
            //Use Console.WriteLine() auto line break
            // Use operator '+' to concatenate annoucement with "HoTen"
            Console.WriteLine("Ho va ten ban vua nhap la: " + HoTen);
        }
    }
}