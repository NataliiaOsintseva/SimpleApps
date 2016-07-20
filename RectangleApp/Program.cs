using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Insert value of side 1, please...");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert value of side 2, please...");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculations...");

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("area : {0}, perimeter : {1}", rectangle.Area, rectangle.Perimeter);
            Console.ReadKey();

        }
    }
}
