using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Calculator : BasicCalculatorInterface, ScientificCalculatorInterface
    {
        int result;
        public int division(int x, int y)
        {
            result = (x/y);
            Console.WriteLine("The division result is :"+ result + "\n");
            return result;
        }

        public int multipilication(int x, int y)
        {
            result = (x * y);
            Console.WriteLine("The multipilication result is :" + result + "\n");
            return result;
        }

        public int sub(int x, int y)
        {
            result = (x - y);
            Console.WriteLine("The subtraction result is :" + result + "\n");
            return result;
        }

        public int sum(int x, int y)
        {
            result = (x + y);
            Console.WriteLine("The addition result is :" + result + "\n");
            return result;
        }

        public double squreRoot(int x)
        {
            Console.WriteLine("The Squre root result is :" + (Math.Sqrt(x)) + "\n");
            return (Math.Sqrt(x));
        }

        public int XtoY(int x, int y)
        {
            
            Console.WriteLine("The power result is :" + (Math.Pow(x, y)) + "\n");
            return 0;
        }
    }
}
