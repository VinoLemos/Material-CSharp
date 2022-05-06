namespace Interfaces.Entities
{
    public class Vehicle
    {
        public string Modelo { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string model)
        {
            Modelo = model;
        }
    }
}