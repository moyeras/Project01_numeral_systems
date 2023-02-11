using System;

namespace NumeralSystems
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            MainProgram();

            void MainProgram()
            {
                Console.WriteLine("Type a number:");
                string input = Console.ReadLine();
                try
                {
                    NumberSystem numberSystem;
                    if (input[0] == '0' && input[1] != 'x' && input[1] != 'X' && input[1] != '.')   
                    {
                        numberSystem = new Octal(input);
                    }
                    else if (input[1] == 'x' || input[1] == 'X') 
                    {
                        numberSystem = new Hexadecimal(input);
                    }
                    else 
                    {
                        numberSystem = new Decimal(input);
                    }
                    numberSystem.ShowResults();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                LoopOfMainProgram();
            }
            
            void LoopOfMainProgram()
            {
                while (true)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); MainProgram(); break;
                }
            }
        }
    }
}
