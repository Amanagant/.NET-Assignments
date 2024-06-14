using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    internal class Binary
 
    {
        static int BinaryStringToDecimal(string binaryString)
        {
            // Convert binary string to decimal integer
            int decimalValue = Convert.ToInt32(binaryString, 2);
            return decimalValue;
        }

        static void main(string[] args)
        {
            string binaryString = "11100";
            int decimalValue = BinaryStringToDecimal(binaryString);
            Console.WriteLine($"The decimal value of binary string {binaryString} is: {decimalValue}");
        }
    }
}

