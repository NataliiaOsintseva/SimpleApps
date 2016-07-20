using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
     class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("constructing object" + GetHashCode());

        }
        private int xCoordinate;
        public int XCoordinate {
            get { return xCoordinate; }
        }

        private int yCoordinate;
        public int YCoordinate {
            get { return yCoordinate; }
        }

        private int price;
        public int Price {
            get { return price; }
            set { price = value; }
        }

        private int year;
        public int Year {
            get { return year; }
            set { year = value; }
        }

        private int speed;
        public int Speed {
            get { return speed; }
            set { speed = value; }
        }

        public Vehicle(int xCoordinate, int yCoordinate, int price, int speed, int year) : this()
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(int price, int speed, int year) : this(0, 0, price, speed, year)
        {

        }

    }
}
