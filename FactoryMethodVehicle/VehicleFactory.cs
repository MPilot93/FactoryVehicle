namespace FactoryMethodVehicle
{
    public class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels, int cilindrata, bool carico) => numberOfWheels switch
        {
            2 => cilindrata > 125 ? new Motorbike(cilindrata) : new Scooter(cilindrata),
            3 => new SideCar(cilindrata),
            4 => new Car(cilindrata),
            6 => carico==true ?  new Tir(cilindrata) : new Truck(cilindrata),

            _ => throw new NumberOfWheelsNotSupported()
        };
    }
}

//if (carico == true) new Tir(cilindrata);
//else new Truck(cilindrata),