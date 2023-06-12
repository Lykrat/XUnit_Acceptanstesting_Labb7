using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Acceptanstesting_Labb7
{
    public class ResultLogger
    {
        public void LogResult(string result)
        {
            string filePath = "CalculatorLogs.txt";
            if (!File.Exists(filePath))
            {
                using StreamWriter sw = File.CreateText(filePath);
                sw.Close();
            }
            File.AppendAllText(filePath, result+Environment.NewLine);
        }
        public void SeeLogResult()
        {
            string filePath = "CalculatorLogs.txt";
            string loggs=File.ReadAllText(filePath);
            Console.WriteLine("\n"+loggs+"\n");
        }
    }
}
