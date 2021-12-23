using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Calculator
{
    public class Methods
    {
        public double GetNumberFromUser()
        {
            double userInput;

            Write("\r: ");
            double.TryParse(ReadLine(), out userInput);

            return userInput;
        }

        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Addition(double[] numArray)
        {
            return numArray[0] + numArray[1];
        }

        public double Suptraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Suptraction(double[] numArray)
        {
            return numArray[0] - numArray[1];
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            double sum = num1 / num2;
            
            if(double.IsInfinity(sum))
            {
                WriteLine("You can't divide by 0");
                return 0;
            }
            return sum;
        }

        public string WriteOutAnswer(char mathMethod)
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
    }
}
