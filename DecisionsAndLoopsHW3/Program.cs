using System.ComponentModel;

namespace DecisionsAndLoopsHW3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNum = 0, secondNum = 0;
            bool castResult;

            void GetTwoNums()
            {
                for (int i = 0; i < 2; i++)
                {
                    do
                    {
                        Console.WriteLine($"Input {i + 1} integer:");
                        var num = Console.ReadLine();
                        castResult = int.TryParse(num, out var inpurResult);
                        if (castResult)
                        {
                            switch (i)
                            {
                                case 0: firstNum = inpurResult; break;
                                case 1: secondNum = inpurResult; break;
                                default: Console.WriteLine("Something went wrong!!!"); break;
                            }
                        }
                        else
                        {
                            Console.Write("Input data incorrect! ");
                        }
                    } while (castResult == false);
                }
            };

            //Write a C# program to check two given integers and return true if one is negative and one is positive
            Console.WriteLine($"Hello, now I'll check two your integers and return true if one is negative and one is positive");
            GetTwoNums();

            bool res = ((firstNum < 0 && secondNum > 0) || (firstNum > 0 && secondNum < 0));
            Console.Write("Check if one is negative and one is positive: ");
            switch (res)
            {
                case true:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TrUe".ToUpper());
                        break;
                    }
                case false:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("FaLsE".ToUpper());
                        break;
                    }
            }
            Console.ForegroundColor = ConsoleColor.Gray;

            //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            Console.WriteLine("\n\nLet's check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20");
            firstNum = 0; secondNum = 0;
            GetTwoNums();

            // logical
            res = ((firstNum == 20 || secondNum == 20 || firstNum + secondNum == 20));

            //if
            bool resIf;
            if (firstNum + secondNum == 20)
            {
                resIf = true;
            }
            else if (firstNum == 20)
            {
                resIf = true;
            }
            else if (secondNum == 20)
            {
                resIf = true;
            }
            else
            {
                resIf = false;
            }

            //ternary
            bool resTernary;
            resTernary = (firstNum + secondNum == 20) ? true :
                            (firstNum == 20) ? true :
                                (secondNum == 20) ? true : false;

            Console.WriteLine($"Logical calc = {res.ToString().ToUpper()} \n" +
                              $"If calc      = {resIf.ToString().ToUpper()} \n" +
                              $"Ternary calc = {resTernary.ToString().ToUpper()} \n");

            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            Console.WriteLine("\n\nI'll print odd numbers from 1 to 99 for you \nPress Enter:");
            Console.ReadLine();
            
            int num = 1;
            while (num <= 99)
            {
                if (num % 2 != 0)
                    Console.WriteLine(num);
                num++;
            }

            //Write a C# program to compute the sum of the first 500 prime numbers.
            //             Sample Output:
            //             Sum of the first 500 prime numbers:
            //             824693
            Console.WriteLine("\n\nPress Enter:");
            Console.ReadLine();

            bool IsPrimeNumber(int num)
            {
                if (num == 0 || num == 1)
                {
                    return false;
                }
                else
                {
                    for (int a = 2; a <= num / 2; a++)
                    {
                        if (num % a == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }

            int numm = 0, count = 0, sum = 0;
            while (count < 500)
            {
                if (IsPrimeNumber(numm))
                {
                    sum += numm;
                    count++;
                }
                numm++;
            }
            Console.WriteLine("Sum of the first 500 prime numbers: {0}", sum);

            //Write a C# program and compute the sum of the digits of an integer.
            //             Sample Output:
            //             Input a number(integer): 12(string.Length)
            //             Sum of the digits of the said integer: 3
            string inputStr;
            int intNum = 0;

            Console.WriteLine($"\n\nInput INTEGER number then I compute the sum of the digits of the integer");
            inputStr = Console.ReadLine();

            for (int i = 0; i < inputStr.Length; i++)
            {
                intNum += Convert.ToInt32(inputStr.Substring(i, 1));
                //Console.WriteLine($"subStr {inputStr.Substring(i, 1)}");
            }
            Console.WriteLine($"Sum of the digits of the said integer: {intNum}");
        }
    }
}