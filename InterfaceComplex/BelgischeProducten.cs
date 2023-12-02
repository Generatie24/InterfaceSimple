using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    public class BelgischeProducten : IProduct
    {
        public string Naam { get; private set; }

        public decimal Prijs { get; set; }

        public BelgischeProducten(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public decimal BerekenBelasting()
        {
            return Prijs * 0.21m;
        }
    }
}
