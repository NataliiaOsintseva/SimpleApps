using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Plane : Vehicle
    {
        public Plane(int xCoordinate, int yCoordinate, int price, int speed, int year)
            : base(xCoordinate, yCoordinate, price, speed, year)
        {

        }

        public Plane(int price, int speed, int year)
            : base(price, speed, year)
        {

        }

        private int height;
        public int Height {
            get { return height; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Height cannot be negative (at least in this application)...");
                }
                else {
                    height = value;
                }
            }
        }

        private int passengers;
        public int Passengers {
            get { return passengers; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Number of passangers should be more than zero...");
                }
                else
                {
                    passengers = value;
                }
            }
        }



    }
}
