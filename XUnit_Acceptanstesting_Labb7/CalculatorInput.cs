using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Acceptanstesting_Labb7
{
    public class CalculatorInput
    {
        public CalculatorInput()
        {

        }
        public Tuple<decimal,decimal> CalculatorUserInput()
        {
            decimal first=0;
            decimal second=0;
            bool end=false;

            while (!end)
            {
                Console.WriteLine("\nWrite the first number in the equation");
                if(!decimal.TryParse(Console.ReadLine(),out decimal firstNumber))
                {
                    Console.WriteLine("\nIt needs to be a number or decimal");
                }
                else
                {
                    first = firstNumber;
                    while (true)
                    {
                        Console.WriteLine("\nWrite the second number in the equation");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal secondNumber))
                        {
                            Console.WriteLine("\nIt needs to be a number or decimal");
                        }
                        else
                        {
                            second = secondNumber;
                            end = true;
                            break;
                        }
                    }
                }
            }
            return Tuple.Create(item1: first, item2: second);
        }
    }
}
