using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMath
{
    class Program
    {
        public delegate double MathDelegate(int x, int y);

        static void Main()
        {
            Console.WriteLine("Insert first number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert second number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert Math operation to perform\n (+, -, *, /");
            string z = Convert.ToString(Console.ReadLine());

            MathDelegate math = null;

            switch (z)
            {
                case "+":
                    math = (a, b) => { return a + b; };
                    break;
                case "-":
                    math = (a, b) => { return a - b; };
                    break;
                case "*":
                    math = (a, b) => { return a * b; };
                    break;
                case "/":
                    math = (a, b) => { return (b != 0) ? a /(double)b : 0; };
                    break;
                default:
                    Console.WriteLine("Incorrect Math operator!");
                    break;
            }

            if (math != null)
                Console.WriteLine("{0:##.###}", math(x, y));

            // Delay.
            Console.ReadKey();
        }
    }
}
