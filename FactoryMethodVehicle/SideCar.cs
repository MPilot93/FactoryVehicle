namespace FactoryMethodVehicle
{
    public class SideCar : Vehicle, IVehicle
    {
        public SideCar(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}