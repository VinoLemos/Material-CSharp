using System;
using System.Globalization;

namespace MetodoFunc.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price {get; set;}

                public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string GetPrice()
        {
            return "R$ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return GetName() + ", " + GetPrice();
        }

        /* public int CompareTo(Product? other)
        {
            return GetName().ToUpper().CompareTo(other.GetName().ToUpper());
        } */
    }
}
