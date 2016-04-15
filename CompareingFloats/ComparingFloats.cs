using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            bool result = false;
            double comparing = firstNumber - secondNumber;
            comparing = Math.Abs(comparing);
           
            if (comparing < 0.000001)
            {
                result = true;
            }
           
            Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, result );
        }
    }
}
