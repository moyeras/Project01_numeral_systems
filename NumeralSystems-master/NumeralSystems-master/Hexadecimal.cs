using System;
using System.Collections.Generic;
using System.Text;

namespace NumeralSystems
{
    internal class Hexadecimal : NumberSystem
    {
        public string UserInput { get; set; }
        public Hexadecimal(string newUserInput)
        {
            this.UserInput = newUserInput;
        }
        public double HexadecimalToDecimal()
        {
            double Answer = 0;
            string FractionalPart = string.Empty;
            string IntegralPart;
            if (UserInput.Contains('.'))
            {
                string[] SplittedNumber = UserInput.Split('.');

                IntegralPart = SplittedNumber[0];
                FractionalPart = SplittedNumber[1];
            }
            else IntegralPart = UserInput;

            int count = IntegralPart.Length - 1;
            for (int i = 0; i < IntegralPart.Length; i++)
            {
                int temp = 0;
                switch (IntegralPart[i])
                {
                    case 'x': break;
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: temp = -48 + (int)IntegralPart[i]; break;
                }

                Answer += temp * (int)(Math.Pow(16, count));
                count--;
            }

            if (FractionalPart != string.Empty)
            {
                string _ = Answer.ToString();
                _ += '.';
                for (int i = 0; i < 16; ++i)
                {
                    double FractionalValue = Answer - Math.Truncate(Answer);
                    FractionalValue *= 16;
                    int digit = (int)FractionalValue;

                    _ = digit.ToString("X");

                    FractionalValue -= digit;

                    if (FractionalValue == 0)
                    {
                        break;
                    }
                    else
                    {
                        _ = Answer.ToString();
                    }
                }
            }

            return Answer;
        }

        public void ShowResults()
        {
            Console.WriteLine("In Hexadecimal: " + UserInput);
            Console.WriteLine("In Decimal: " + HexadecimalToDecimal());
            double result = HexadecimalToDecimal();
            Decimal decimalSystems = new Decimal(result.ToString());
            Console.WriteLine(decimalSystems.DecimalToBinary());
            Console.WriteLine(decimalSystems.DecimalToOctal());
        }
    }
}
