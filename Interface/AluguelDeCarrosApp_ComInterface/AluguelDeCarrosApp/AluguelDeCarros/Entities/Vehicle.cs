namespace AluguelDeCarros.Entities
{
    public class Vehicle
    {
        public string CarModel { get; set; }

        public Vehicle(string carModel)

        {
            CarModel = carModel;
        }
    }
}
