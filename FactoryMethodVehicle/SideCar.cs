namespace FactoryMethodVehicle
{
    public class SideCar : Vehicle, IVehicle
    {
        public SideCar(int cilindrata) : base(cilindrata)
        {
        }
    }
}