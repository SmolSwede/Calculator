using System;
using static System.Console;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();

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

                switch (methods.GetNumberFromUser())
                {
                    case 1:
                        WriteLine(methods.WriteOutAnswer('+'));
                        ReadKey();
                        break;
                    case 2:
                        WriteLine(methods.WriteOutAnswer('-'));
                        ReadKey();
                        break;
                    case 3:
                        WriteLine(methods.WriteOutAnswer('/'));
                        ReadKey();
                        break;
                    case 4:
                        WriteLine(methods.WriteOutAnswer('*'));
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
