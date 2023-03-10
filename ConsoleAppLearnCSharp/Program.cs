using System;
using System.Globalization;

namespace VariableHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intA = 10; 
            int intB = 25;
            double doubleA = 10;
            double doubleB = 25;

            //print the sum of two numbers
            Console.WriteLine($"Sum of two INTEGER numbers a({intA}) and b({intB}) = {intA + intB} \n");

            // print the result of dividing two numbers
            var originalColor = Console.ForegroundColor;
            var expectType = "System.Double";
            var resultType = (intA / intB).GetType().ToString();
            Console.Write($"Dividing two INTEGER numbers a({intA}) / b({intB}) = ");
            if (expectType == resultType)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else 
            { 
                Console.ForegroundColor = ConsoleColor.Red; 
            }
            Console.Write($"{intA / intB} \n");
            Console.ForegroundColor = originalColor;

            Console.Write($"Dividing two DOUBLE  numbers a({doubleA}) / b({doubleB}) = ");
            resultType = (doubleA / doubleB).GetType().ToString();
            if (expectType == resultType)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write($"{doubleA / doubleB} \n \n");
            Console.ForegroundColor = originalColor;


            // print the result of the specified operations
            double a, b, c, d, e, f, res;
            int opNum = 0;

            a = -1; b = 4; c = 6;
            res = a + b * c;
            Console.WriteLine($"Operation {++opNum}: -1 + 4 * 6                Result = {res}");

            a = 35; b = 5; c = 7;
            res = (a + b) % c;
            Console.WriteLine($"Operation {++opNum}: (35 + 5) % 7              Result = {res}");

            a = 14; b = -4; c = 6; d = 11;
            res = a + b * c / d;
            Console.WriteLine($"Operation {++opNum}: 14 + -4 * 6 / 11          Result = {res}");

            a = 2; b = 15; c = 6; d = 1; e = 7; f = 2;
            res = a + b / c * d - e % f;
            Console.WriteLine($"Operation {++opNum}: 2 + 15 / 6 * 1 - 7 % 2    Result = {res} \n");

            
            int firstNum, secondNum;
            do
            {
                Console.WriteLine("Pls input the First Number : 5");
                firstNum = 5;

            } while (Convert.ToInt32(Console.ReadLine()) != 5);

            do
            {
                Console.WriteLine("Pls input the Second Number : 6");
                secondNum = 6;
            } while (Convert.ToInt32(Console.ReadLine()) != 6);

            Console.WriteLine($"\nfirstNum  = {firstNum}");
            Console.WriteLine($"secondNum = {secondNum}");

            Console.Write("\nMagic Swapping ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(". ");
                Thread.Sleep(300);
            }
            Console.Write("\n");

            // old style code
                //int temp = firstNum;
                //firstNum = secondNum;
                //secondNum = temp;

            (firstNum, secondNum) = (secondNum, firstNum); // #C 7 style

            Console.WriteLine($"\nfirstNum  = {firstNum}");
            Console.WriteLine($"secondNum = {secondNum}\n");

            // print the output of multiplication of three numbers which will be entered by the user
            bool result;
            double firstMNumm = 0d, secondMNum = 0d, thirdMNum = 0d;
            string? input;
            Console.WriteLine($"Lets multiply three numbers (Please use '{CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator}' decimal symbol if need)");
            do
            {
                Console.WriteLine("Input the first number to multiply:");
                input = Console.ReadLine();
                result = double.TryParse(input, out var inputRes);
                if (result)
                { 
                    firstMNumm = inputRes; 
                }
                else 
                {
                    Console.Write("Input data incorrect! ");
                }

            } while (result == false);

            do
            {
                Console.WriteLine("Input the second number to multiply:");
                input = Console.ReadLine();
                result = double.TryParse(input, out var inputRes);
                if (result)
                {
                    secondMNum = inputRes;
                }
                else
                {
                    Console.Write("Input data incorrect! ");
                }

            } while (result == false);

            do
            {
                Console.WriteLine("Input the third number to multiply:");
                input = Console.ReadLine();
                result = double.TryParse(input, out var inputRes);
                if (result)
                {
                    thirdMNum = inputRes;
                }
                else
                {
                    Console.Write("Input data incorrect! ");
                }

            } while (result == false);


            Console.WriteLine($"\nResult = {firstMNumm * secondMNum * thirdMNum}");


        }
    }
}