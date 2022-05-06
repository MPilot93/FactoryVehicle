namespace FactoryMethodVehicle
{
    public class Car : Vehicle, IVehicle
    {
        public Car(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}
