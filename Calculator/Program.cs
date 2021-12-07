using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static int GetNumberFromUser()
        {
            int userInput = 0;
            bool succeeded = false;

            Write("\r: ");
            succeeded = int.TryParse(ReadLine(), out userInput);

            return userInput;
        }
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                int num1 = 0;
                int num2 = 0;
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
                        Clear();
                        WriteLine("Enter the values you wish to add together");
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        Clear();
                        WriteLine(" {0} + {1} = {2}", num1, num2, num1 + num2);
                        ReadKey();
                        break;
                    case 2:
                        Clear();
                        WriteLine("Enter the values you wish to subtract from each other ");
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        Clear();
                        WriteLine(" {0} - {1} = {2}", num1, num2, num1 - num2);
                        ReadKey();
                        break;
                    case 3:
                        Clear();
                        WriteLine("Enter the values you wish to multiply");
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        Clear();
                        WriteLine(" {0} * {1} = {2}", num1, num2, num1 * num2);
                        ReadKey();
                        break;
                    case 4:
                        Clear();
                        WriteLine("Enter the values you wish to divide");
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        Clear();
                        try
                        {
                            WriteLine(" {0} / {1} = {2}", num1, num2, num1 / num2);
                        }
                        catch(DivideByZeroException)
                        {
                            WriteLine("Hmm... you tried to divide by 0.");
                        }
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
