using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            double secondNumber = double.Parse(Console.ReadLine());

            bool result = false;
            double compare = firstNumber - secondNumber;
            compare = Math.Abs(compare);

            if (compare < 0.000001)
            {
                result = true;
            
            }
            Console.WriteLine(result);
            


        }
    }
}
