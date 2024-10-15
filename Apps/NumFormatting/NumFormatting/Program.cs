using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Left justified width 10: {0,-10}" , 99 );
            Console.WriteLine("Right justified width 10: {0,10}", 99);

            Console.WriteLine("\n\nFormatting\n============");
            Console.WriteLine("Currency Formatting: {0:C}", 22.2);
            Console.WriteLine("Integer Formatting: {0:D5}", 22);
            Console.WriteLine("Exponential Formatting: {0:E}", 222.2);
            Console.WriteLine("Fixed Point Formatting: {0:F}", 222.2222);
            Console.WriteLine("General Formatting: {0:G}", 222.2222);
            Console.WriteLine("Number Formatting: {0:N}", 2222222.2);
            Console.WriteLine("Hexadecimal Formatting: {0:X}", 22);

        }
    }
}
