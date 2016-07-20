using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Ship : Vehicle
    {
        public Ship(int xCoordinate, int yCoordinate, int price, int speed, int year) :
            base(xCoordinate, yCoordinate, price, speed, year)
        { 
        }

        public Ship(int price, int speed, int year) :
            base(price, speed, year)
        {
        }

        private int passengers;
        public int Passengers
        {
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

        private string port;
        public string Port {
            get { return port; }
            set {
                if (value != null)
                {
                    port = value;
                }
                else {
                    Console.WriteLine("Port value cannot be null");
                }
            }
        }
    }

    class Car : Vehicle {
        public Car(int xCoordinate, int yCoordinate, int price, int speed, int year) :
            base(xCoordinate, yCoordinate, price, speed, year)
        {
        }

        public Car(int price, int speed, int year) : base(price, speed, year)
        {
        }
    }
}
