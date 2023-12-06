namespace DesafioFundamentos.Models 
    {
    internal class Vehicle
    {
        public string VehiclePlate { get; private set; }

        public Vehicle(string plate) => VehiclePlate = plate;

        public override string ToString()
        {
            return VehiclePlate;
        }

    }
}
