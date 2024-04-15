using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        Vehicle[] _vehicles = { };
        public int CarLimit { get; } = 3;
        public int TruckLimit { get; } = 3;
        Car[] cars = { };
        Truck[] trucks = { };
        public void AddVehicle(Vehicle vehicle)
        {
            if(vehicle is Car) 
            {
                if(cars.Length<CarLimit)
                {
                    Array.Resize(ref cars, cars.Length+1);
                    cars[cars.Length-1]= (Car)vehicle;
                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("CarLimit is full!");
                }

            }
            if (vehicle is Truck)
            {
                if (trucks.Length < TruckLimit)
                {
                    Array.Resize(ref trucks, trucks.Length + 1);
                    trucks[trucks.Length - 1] = (Truck)vehicle;
                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("TruckLimit is full!");
                }
            }
        }
        public void ShowAllVehicles(Vehicle vehicle)
        {

            if (vehicle is Car)
            {
                var car= (Car)vehicle;
                Console.WriteLine($"PassengerCapacity:{car.PassengerCapacity}");
            }
            if (vehicle is Truck)
            {
                var truck= (Truck)vehicle;
                Console.WriteLine($"CarryingCapacity:{truck.CarryingCapacity}");
            }
        }

    }
}
