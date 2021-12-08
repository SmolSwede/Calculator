using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static double GetNumberFromUser()
        {
            double userInput;

            Write("\r: ");
            double.TryParse(ReadLine(), out userInput);

            return userInput;
        }

        static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Suptraction(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                WriteLine("You can't divide by 0");
            }
            return -1;
        }

        static string WriteOutAnswer(char mathMethod)
        {
            Clear();
            double num1 = GetNumberFromUser();
            double num2 = GetNumberFromUser();
            double sum = 0;
            if (mathMethod == '+')
            {
                sum = Addition(num1, num2);
            }
            if (mathMethod == '-')
            {
                sum = Suptraction(num1, num2);
            }
            if (mathMethod == '/')
            {
                sum = Multiplication(num1, num2);
            }
            if (mathMethod == '*')
            {
                sum = Division(num1, num2);
            }
            return $"{num1} {mathMethod} {num2} = {sum}";
        }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                
                Clear();
                WriteLine("--------Calculator--------");
                WriteLine("1. Addition");
                WriteLine("2. Suptraction");
                WriteLine("3. Multiplication");
                WriteLine("4. Division");
                WriteLine("5. Exit");
                WriteLine("--------------------------");
                Write("\r: ");

                switch (GetNumberFromUser())
                {
                    case 1:
                        WriteLine(WriteOutAnswer('+'));
                        ReadKey();
                        break;
                    case 2:
                        WriteLine(WriteOutAnswer('-'));
                        ReadKey();
                        break;
                    case 3:
                        WriteLine(WriteOutAnswer('/'));
                        ReadKey();
                        break;
                    case 4:
                        WriteLine(WriteOutAnswer('*'));
                        ReadKey();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
