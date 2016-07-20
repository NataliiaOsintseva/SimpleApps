using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args) {

            Figure myFigure = new Figure(new Point(3, 2, "A"), new Point(4, 1, "B"), new Point(5, 0, "C"), new Point(3, 9, "D"), new Point(6, 7, "E"));
            Console.Write("Name of Figure is {0}, its Perimeter is ", myFigure.Name);
            myFigure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
