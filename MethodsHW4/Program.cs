using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MethodsHW4
{
    internal class Program
    {
        const int twenty = 20;
        static void Main(string[] args)
        {

            Console.WriteLine("Find the largest & lowest value from three integer value");
            Console.WriteLine("Enter three integer number:");
            Console.WriteLine("First:");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third:");
            var num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Max value = {GetMaxInt(num1, num2, num3)}\nMin value = {GetMinInt(num1, num2, num3)}");

            Console.WriteLine($"\nCheck the nearest value of 20 of two given integers and return 0 if two numbers are same:");
            Console.WriteLine("Enter two integer number:");
            Console.WriteLine("First:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result = {GetNearestInt(num1, num2)}");


            Console.WriteLine($"\nCompute the sum of all the elements of an array of integers [1, 2, 3, 4, 99, -15]. Press Enter:");
            Console.WriteLine($"Sum = {ArraySum(new int[] { 1, 2, 3, 4, 99, -15 })}");
            Console.WriteLine($"\nCompute the sum of all the elements of an array of integers in string '123, 244, 1, 55, 99, 100'. Press Enter:");
            Console.WriteLine($"Sum = {ArraySum("123, 244, 1, 55, 99, 100")}");

            Console.WriteLine($"\nGet the larger value from array [126, 99, 3, 4, 99, -15]. Press Enter:");
            Console.WriteLine($"Result = {ArrayMaxValue(new int[] { 126, 99, 3, 4, 99, -15 })}");

            Console.WriteLine($"\nGget the larger value from array [ {{ 1, 33 }}, {{2,100500}}, {{3,55}}, {{-12,999}} ]. Press Enter:ss Enter:");
            Console.WriteLine($"Result = {ArrayMaxValue(new int[,] { { 1, 33 }, { 2, 100500 }, { 3, 55 }, { -12, 999 } })}");

        }
        /// <summary>  
        /// Method to find the largest value from three integer value  
        /// </summary>  
        static int GetMaxInt(int a, int b, int c)
        {
            int res = a >= b ? a : b;
            res = res >= c ? res : c;
            return res;
        }

        /// <summary>  
        /// Method to find the lowest value from three integer value
        /// </summary> 
        static int GetMinInt(int a, int b, int c)
        {
            int res = a <= b ? a : b;
            res = res <= c ? res : c;
            return res;
        }

        /// <summary> 
        /// Method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        /// </summary>
        static int GetNearestInt(int a, int b)
        {
            int res = 0;
            if (a == b) return res;
            else res = (Math.Abs(twenty - a) > Math.Abs(twenty - b)) ? b : a;

            return res;
        }

        /// <summary>
        /// Method to compute the sum of all the elements of an array of integers
        /// </summary>
        static int ArraySum(int[] a)
        {
            int res = 0;
            foreach (int x in a) res += x;
            return res;
        }

        static int ArraySum(string str) // some castom bicycle :)
        {
            var res = 0;

            str = str.Replace(" ", "");
            string ss = "";
            int indx = 0;
            int num = 0, i = 0;

            int numCount = str.Length - str.Replace(",", "").Length + ((str.Length > 0) ? 1 : 0);
            int[] arr = new int[numCount];

            while (str.Length > 0)
            {
                indx = str.IndexOf(',', 0);
                if (indx != -1)
                    ss = str.Substring(0, indx);
                else
                    ss = str.Substring(0, str.Length);

                if (int.TryParse(ss, out num))
                {
                    arr[i] = num;
                    i++;
                }

                if (indx != -1)
                    str = str.Substring(indx + 1);
                else
                    str = "";
            }

            foreach (int x in arr)
            { 
                res += x;
            }

            return res;
        }

        /// <summary>
        /// Method to get the larger value from array
        /// </summary>
        static int ArrayMaxValue(int[] a)
        {
            var res = a.Max();
            return res;
        }

        static int ArrayMaxValue(int[,] a)
        {
            var res = a.Cast<int>().Max(); // google
            //int res = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        res = (res < a[i, j] ? a[i, j] : res);
            //    }
            //}
            return res;
        }
    }
}