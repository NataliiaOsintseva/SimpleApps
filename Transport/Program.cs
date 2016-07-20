using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    class Program
    {
        static void Main(string[] args)
        {


            string carInfo = "Type of Transport: {0}, price {1}, speed{2}, year {3}";
            string shipInfo = carInfo + ", passengers {4}, port {5}";
            string planeInfo = carInfo + ", passengers {4}, height {5}";

            Vehicle vehicle = new Vehicle(0, 0, 0);
            Console.WriteLine("Specify type of Vehicle: Car, Ship or Plane\n");
            string typeOfVehicle = Console.ReadLine();

            Console.WriteLine("Insert the price\n");
            vehicle.Price = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Insert the speed\n");
            vehicle.Speed = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Insert the year\n");
            vehicle.Year = Convert.ToUInt16(Console.ReadLine());

            switch (typeOfVehicle) {
                case "Car":
                    vehicle = new Car(vehicle.Price, vehicle.Speed, vehicle.Year);
                    Console.WriteLine(carInfo, typeOfVehicle, vehicle.Price, vehicle.Speed, vehicle.Year);
                    break;

                case "Ship":

                    Console.WriteLine("Insert the number of passangers\n");
                    int number = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Insert the destination port\n");
                    string dest = Console.ReadLine();
                    vehicle = new Ship(vehicle.Price, vehicle.Speed, vehicle.Year) { Passengers = number, Port = dest };
                    Console.WriteLine(shipInfo, typeOfVehicle, vehicle.Price, vehicle.Speed, vehicle.Year, number, dest);
                    break;

                case "Plane":
                    Console.WriteLine("Insert the number of passangers\n");
                    int numberPlane = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Insert the height\n");
                    int height = Convert.ToInt16(Console.ReadLine());
                    vehicle = new Plane(vehicle.Price, vehicle.Speed, vehicle.Year) { Passengers = numberPlane, Height = height };

                    Console.WriteLine(shipInfo, typeOfVehicle, vehicle.Price, vehicle.Speed, vehicle.Year, numberPlane, height);
                    break;

                default:
                    Console.WriteLine("Specified vehicle type is incorrect");
                    break;
            }
          
            Console.ReadKey();
        }
    }
}
