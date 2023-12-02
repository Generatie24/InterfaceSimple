using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct standaardProduct = new BelgischeProducten("Sport schoenen",100);
            IProduct luxeProduct = new ImportProducten(100, "electronica", false);
            IProduct luxeProduct1 = new ImportProducten(100, "electronica", true);
            IProduct luxeProduct2 = new ImportProducten(100, "sieraden", true);

            Console.WriteLine($"Belasting voor Belgische product: {standaardProduct.BerekenBelasting()}");
            Console.WriteLine($"Belasting voor Import product: {luxeProduct.BerekenBelasting()}");
            Console.WriteLine($"Belasting voor Import product1: {luxeProduct1.BerekenBelasting()}");
            Console.WriteLine($"Belasting voor Import product2: {luxeProduct2.BerekenBelasting()}");

        }
    }
}
