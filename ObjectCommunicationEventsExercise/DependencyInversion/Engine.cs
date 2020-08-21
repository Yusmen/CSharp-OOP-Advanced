using P03_DependencyInversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInversion
{
    public class Engine
    {
        private PrimitiveCalculator calculator;

        public Engine(PrimitiveCalculator calculator)
        {
            this.calculator = calculator;
        }



        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (char.IsDigit(input[0]) || input[0] == '-')
                {
                    int[] operands = input.Split().Select(int.Parse).ToArray();

                    int firstNumber = operands[0];
                    int secondNumber = operands[1];

                    Console.WriteLine("RESULT:" + calculator.PerformCalculation(firstNumber, secondNumber));
                }
                else
                {
                    string[] args = input.Split();

                    IStrategy strategy = null;
                    switch (args[1])
                    {
                        case "+":
                            strategy = new AdditionStrategy();
                            break;
                        case "-":
                            strategy = new SubtractionStrategy();
                            break;
                        case "*":
                            strategy = new MultiplyStrategy();
                            break;
                        case "/":
                            strategy = new DivisionStrategy();
                            break;

                    }
                    calculator.ChangeStrategy(strategy);
                }

            }
        }

    }
}
