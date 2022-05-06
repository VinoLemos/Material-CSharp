using System;
using System.Globalization;

namespace Comparacao.Entites
{
    class Product
    {
        private string _name { get; set; }
        private double _price {get; set;}

                public Product()
        {
        }

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPrice()
        {
            return "R$ " + _price.ToString("F2", CultureInfo.InvariantCulture);
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