using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XUnit_Acceptanstesting_Labb7;

namespace XUnit_Acceptanstesting_Labb7_XUnitTesting
{
    public class ResultWriter_Tests
    {
        [Fact]
        public void WriteResultStringTester()
        {
            //Arrange
            ResultWriter resultWriter=new ResultWriter();
            string result = "Testing if this works";
            string expected = "\n"+result+"\n\r\n";

            var output = new StringWriter();
            Console.SetOut(output);

            //Act
            resultWriter.WriteResult(result);
            var outputString=output.ToString();

            //Assert
            Assert.Equal(expected, outputString);


        }
    }
}
