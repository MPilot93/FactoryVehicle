namespace FactoryMethodVehicle
{
    public abstract class Vehicle : IVehicle
    {
        public int PistonDisplace;
        public int Weight;

        public Vehicle(int pistonDisplace, int weight)
        {
            PistonDisplace = pistonDisplace;
            Weight = weight;
        }
        public int GetPower() => PistonDisplace;

        public int GetWeight() => Weight;

    }
}
