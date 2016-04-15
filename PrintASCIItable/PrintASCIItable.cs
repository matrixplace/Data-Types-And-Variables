using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIItable
{
    class PrintASCIItable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            for (char c = (char)33; c <= (char)126; c++)
            {
                Console.Write(c);
            }
        }
    }
}
