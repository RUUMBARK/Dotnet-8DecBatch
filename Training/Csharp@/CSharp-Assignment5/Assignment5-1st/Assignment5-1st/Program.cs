using System;

namespace Assignment5_1st
{
    class Program
    {
        public static void print_r(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine(" ");
        }

        public static void print_I(int[] arr)
        {
            for(int i =0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }

        static void Main(string [] args )
        {
            int [] arr = new int[6];
            string[] str = new string[6];
            int val = 0;
            Console.WriteLine("Enter the value of int arrays");
            for (int i = 0; i < 6; i ++)
            {
                val = Convert.ToInt32(Console.ReadLine());
                arr[i] = val;
            }
            string value;
            Console.WriteLine("Enter the values of string"); 
            for (int i= 0; i < 6; i++ )
            {
                value = Console.ReadLine();
                str[i] = value; 
            }
            int[] c_arr = new int[100];
            string[] c_str = new string[100];
            Array.Copy(arr, c_arr, arr.Length);
            Array.Copy(str, c_str, str.Length);
            Array.Sort(arr);
            Array.Sort(str);
            Console.WriteLine("The sorted arrays are as follows ");
            print_I(arr);
            print_r(str);
            Array.Reverse(arr);
            Array.Reverse(str);
            Console.WriteLine("Reversed Array");
            print_I(arr);
            print_r(str);
            Array.Clear(arr, 0, arr.Length);
            Array.Clear(str, 0, str.Length);
        }
    }
}
