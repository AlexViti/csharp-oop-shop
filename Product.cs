using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Product
    {
        public int Code { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        private double iva;

        public Product(string name, string description, double price)
        {
            Code = new Random().Next(1, 99999999);
            Name = name;
            Description = description;
            Price = price;
            iva = 0.21 * price;
        }
    }
}
