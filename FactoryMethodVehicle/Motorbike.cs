namespace FactoryMethodVehicle
{
    public class Motorbike : Vehicle, IVehicle
    {
        public Motorbike(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}
