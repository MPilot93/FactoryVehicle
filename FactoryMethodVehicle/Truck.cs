namespace FactoryMethodVehicle
{
    public class Truck : Vehicle, IVehicle
    {
        public Truck(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}
