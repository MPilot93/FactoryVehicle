namespace FactoryMethodVehicle
{
    public class Tir : Vehicle, IVehicle
    {
        public Tir(int pistonDisplace, int weight) : base(pistonDisplace, weight)
        {
        }
    }
}