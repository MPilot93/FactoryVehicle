using System;

namespace FactoryMethodVehicle
{
    class Program
    {
        static void Main()
        {
            var vehicleWith4wheels = VehicleFactory.Build(4,2000,1200);
            Console.WriteLine($"I'm a ... {vehicleWith4wheels.GetType()}, Weight: {vehicleWith4wheels.GetWeight()}");


            var vehicleWith2wheels = VehicleFactory.Build(2,50, 400);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels.GetType()}, power: {vehicleWith2wheels.GetPower()} , Weight: {vehicleWith2wheels.GetWeight()}");

            var vehicleWith2wheels2 = VehicleFactory.Build(2, 150, 500);
            Console.WriteLine($"I'm a ... {vehicleWith2wheels2.GetType()}, power: {vehicleWith2wheels.GetPower()} , Weight: {vehicleWith2wheels.GetWeight()}");

            var vehicleWith6wheels = VehicleFactory.Build(6, 6000,5000);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels.GetType()}, Weight: {vehicleWith6wheels.GetWeight()}");

            var vehicleWith6wheels2 = VehicleFactory.Build(6, 6000, 3400);
            Console.WriteLine($"I'm a ... {vehicleWith6wheels2.GetType()}, Weight: {vehicleWith6wheels2.GetWeight()}");



            Console.ReadLine();
        }
    }
}
