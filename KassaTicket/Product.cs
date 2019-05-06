using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassaTicket
{
    class Product
    {
        public string Naam { get; set; }
        public double Eenheidsprijs { get; set; }
        private string _code;

        public string Code
        {
            get { return _code; }
            set {
                if (!value.StartsWith("P") | value.Length != 6)
                {
                    throw new ArgumentException("Invalid product code");
                }

                _code = value;
            }
        }

        
        public Product(string nm, double eenhpr, string cd)
        {
            Naam = nm;
            Eenheidsprijs = eenhpr;
            Code = cd;

        }

        public static bool ValideerCode(string code)
        {
            bool correct = true;
            if ((!code.StartsWith("P") | code.Length != 6))
            {
                correct = false;
            }
            return correct;
        }

        public override string ToString()
        {
            string productString = $"({_code}) {Naam} {Eenheidsprijs}";
            return productString; 
        }
    }
}
