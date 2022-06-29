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
        
        private double price;
        private double iva;

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                iva = price * 0.21;
            }
        }

        public double Iva
        {
            get { return iva; }
        }
        
        public Product(string name, string description, double price)
        {
            Code = new Random().Next(1, 99999999);
            Name = name;
            Description = description;
            Price = price;
        }

        public string GetExtendedName()
        {
            return $"{Code} - {Name}";
        }

        public double GetTaxedPrice()
        {
            return price + iva;
        }

        public string GetPriceString()
        {
            return String.Format("{0:0.00}", Price) + "$"; // € is not displayed in console
        }

        public string GetTaxedPriceString()
        {
            return String.Format("{0:0.00}", GetTaxedPrice()) + "$";
        }

        public string GetPaddedCode() {
            // return Code.ToString().PadLeft(8, '0');
            string paddedCode = "";
            string code = Code.ToString();
            for (int i = 0; i < 8 - code.Length; i++)
            {
                paddedCode += "0";
            }
            return paddedCode + code;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{GetExtendedName()}");
            Console.Write("Descrizione: ");
            Console.WriteLine(Description);
            Console.Write("Prezzo: ");
            Console.WriteLine(GetPriceString());
            Console.Write("IVA: ");
            Console.WriteLine(Iva);
        }
    }
}
