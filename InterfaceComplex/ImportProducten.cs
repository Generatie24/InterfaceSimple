using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{

    public class ImportProducten : IProduct
    {
        public decimal Prijs { get; set; }
        public string Categorie { get; private set; }
        public bool IsDuurzaam { get; private set; }

        public ImportProducten(decimal prijs, string categorie, bool isDuurzaam)
        {
            Prijs = prijs;
            Categorie = categorie;
            IsDuurzaam = isDuurzaam;
        }

        public decimal BerekenBelasting()
        {
            decimal basisBelasting = Prijs * 0.30m; // Standaard luxebelasting
            decimal categorieToeslag = BerekenCategorieToeslag();
            decimal milieubelasting;
            if (IsDuurzaam)
            {
                milieubelasting = 0;
            }
            else
            {
                milieubelasting = Prijs * 0.05m; // 5% extra voor niet-duurzame producten
            }
            // deze geeft hetzelfe resultaat als boven met if
            // decimal milieubelasting = IsDuurzaam ? 0 : Prijs * 0.05m; // 5% extra voor niet-duurzame producten


            decimal totaleBelasting = basisBelasting + categorieToeslag + milieubelasting;


            return totaleBelasting;

            // niet geimplementeerd, Zorgt dat de totale belasting nooit meer dan 40% van de prijs is
            //return Math.Min(totaleBelasting, Prijs * 0.40m);
        }

        private decimal BerekenCategorieToeslag()
        {
            switch (Categorie.ToLower())
            {
                case "electronica":
                    return Prijs * 0.02m; // 2% toeslag voor electronica
                case "sieraden":
                    return Prijs * 0.05m; // 5% toeslag voor sieraden
                case "kleding":
                    return Prijs * 0.03m; // 3% toeslag voor kleding
                default:
                    return 0;
            }
        }
    }

}
