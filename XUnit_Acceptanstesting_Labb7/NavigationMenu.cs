using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Acceptanstesting_Labb7
{
    public class NavigationMenu
    {
        public void NavigationMenu_MainMenu()
        {
            Calculator calculator = new Calculator();
            CalculatorInput input = new CalculatorInput();
            ResultWriter results = new ResultWriter();
            ResultLogger logger = new ResultLogger();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("-----Main Menu-----\n" +
                    "1. Addition\n" +
                    "2. Subtraction\n" +
                    "3. Multiplication\n" +
                    "4. Division\n" +
                    "5. Records\n" +
                    "6. Exit\n");

                string userInput = Console.ReadLine();
                    
                switch (userInput)
                {
                    case "1":
                        var (x, y) = input.CalculatorUserInput();
                        calculator.Addition(x,y);
                        results.WriteResult(calculator.result);
                        logger.LogResult(calculator.result);
                        break;
                    case "2":
                        var (a, b) = input.CalculatorUserInput();
                        calculator.Subtraction(a,b);
                        results.WriteResult(calculator.result);
                        logger.LogResult(calculator.result);
                        break;
                    case "3":
                        var (c, d) = input.CalculatorUserInput();
                        calculator.Multiplication(c, d);
                        results.WriteResult(calculator.result);
                        logger.LogResult(calculator.result);
                        break;
                    case "4":
                        var (e, f) = input.CalculatorUserInput();
                        calculator.Division(e, f);
                        results.WriteResult(calculator.result);
                        logger.LogResult(calculator.result);
                        break;
                    case "5":
                        logger.SeeLogResult();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Input needs to be a number between 1 and 6\n");
                        break;
                }
            }
        }
        
    }
}
