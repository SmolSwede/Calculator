using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static double num1 = 0;
        static double num2 = 0;
        static double GetNumberFromUser()
        {
            double userInput = 0;

            Write("\r: ");
            double.TryParse(ReadLine(), out userInput);

            return userInput;
        }
        static void Addition()
        {
            Clear();
            WriteLine("Enter the values you wish to add together");
            num1 = GetNumberFromUser();
            num2 = GetNumberFromUser();
            Clear();
            WriteLine(" {0} + {1} = {2}", num1, num2, num1 + num2);
            ReadKey();
        }
        static void Suptraction()
        {
            Clear();
            WriteLine("Enter the values you wish to subtract from each other ");
            num1 = GetNumberFromUser();
            num2 = GetNumberFromUser();
            Clear();
            WriteLine(" {0} - {1} = {2}", num1, num2, num1 - num2);
            ReadKey();
        }
        static void Multiplication()
        {
            Clear();
            WriteLine("Enter the values you wish to multiply");
            num1 = GetNumberFromUser();
            num2 = GetNumberFromUser();
            Clear();
            WriteLine(" {0} * {1} = {2}", num1, num2, num1 * num2);
            ReadKey();
        }
        static void Division()
        {
            Clear();
            WriteLine("Enter the values you wish to divide");
            num1 = GetNumberFromUser();
            num2 = GetNumberFromUser();
            Clear();
            try
            {
                WriteLine(" {0} / {1} = {2}", num1, num2, num1 / num2);
            }
            catch (DivideByZeroException)
            {
                WriteLine("Hmm... you tried to divide by 0.");
            }
            ReadKey();
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
                        Addition();
                        break;
                    case 2:
                        Suptraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
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
