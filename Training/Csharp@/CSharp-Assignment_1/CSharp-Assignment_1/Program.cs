using System;

namespace CSharp_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice, Num1, Num2;
            Console.WriteLine("Enter \n 1.Addition \n 2.Subraction \n 3.Multiplication \n 4.Division");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 Number- ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Addition Result- " + (Num1 + Num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Result:- " + (Num1 - Num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication Result- " + (Num1 * Num2));
                    break;
                case 4:
                    Console.WriteLine("Division Result- " + (Num1 / Num2));
                    break;
                default:
                    Console.WriteLine("Enter Correct Choice.");
                    break;
            }
        }
    }
}

