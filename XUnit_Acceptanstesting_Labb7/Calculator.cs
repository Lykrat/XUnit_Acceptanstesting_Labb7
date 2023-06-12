using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Acceptanstesting_Labb7
{
    public class Calculator
    {
        public decimal total { get; set; }
        public string result { get; set; }

        public Calculator()
        {
            total = 0;
            result = "";
        }

        public void Addition(decimal firstNumber, decimal secondNumber)
        {
            total=firstNumber+secondNumber;
            result = ($"{firstNumber} + {secondNumber} = {total}");
        }
        public void Subtraction(decimal firstNumber, decimal secondNumber)
        {
            total = firstNumber - secondNumber;
            result = ($"{firstNumber} - {secondNumber} = {total}");
        }
        public void Multiplication(decimal firstNumber, decimal secondNumber)
        {
            total = firstNumber * secondNumber;
            result= ($"{firstNumber} * {secondNumber} = {total}");
        }
        public void Division(decimal firstNumber, decimal secondNumber)
        {
            total = firstNumber / secondNumber;
            result = ($"{firstNumber} / {secondNumber} = {total}");
        }
    }
}
