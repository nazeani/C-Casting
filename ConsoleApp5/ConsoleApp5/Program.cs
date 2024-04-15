using Core.Models;
using Core;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
            car.Marka = "alalla";
            car.PassengerCapacity = 10;
           Car car2 = new Car();
            car2.Marka = "alalla";
            car2.PassengerCapacity = 20;

            Truck truck = new Truck();
            truck.Marka = "Naz";
            truck.CarryingCapacity = 17;

           RentCar rentCar = new RentCar();
            rentCar.AddVehicle(car);
            rentCar.AddVehicle(truck);
            rentCar.AddVehicle(car2);
            rentCar.ShowAllVehicles(car2);

        }
    }
}
