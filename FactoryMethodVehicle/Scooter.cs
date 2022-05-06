namespace FactoryMethodVehicle
{
    public class Scooter : Vehicle, IVehicle
    {
        public Scooter(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}