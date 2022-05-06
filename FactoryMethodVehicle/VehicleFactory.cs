namespace FactoryMethodVehicle
{
    public class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels, int pistonDisplace, int weight) => numberOfWheels switch
        {
            2 => pistonDisplace > 125 ? new Motorbike(pistonDisplace,weight) : new Scooter(pistonDisplace, weight),
            3 => new SideCar(pistonDisplace, weight),
            4 => new Car(pistonDisplace, weight),
            6 => weight> 3500 ?  new Tir(pistonDisplace, weight) : new Truck(pistonDisplace, weight),

            _ => throw new NumberOfWheelsNotSupported()
        };
    }
}

