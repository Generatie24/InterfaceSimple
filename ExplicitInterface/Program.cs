using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{

    interface IInterfaceA
    {
        void DoeIets();
    }

    interface IInterfaceB
    {
        void DoeIets();
    }

    public class DemoKlasse : IInterfaceA, IInterfaceB
    {
        void IInterfaceA.DoeIets()
        {
            Console.WriteLine("DoeIets methode aangeroepen via IInterfaceA");
        }

        void IInterfaceB.DoeIets()
        {
            Console.WriteLine("DoeIets methode aangeroepen via IInterfaceB");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoKlasse demo = new DemoKlasse();

            // Aanroepen via IInterfaceA
            IInterfaceA a = demo;
            a.DoeIets();

            // Aanroepen via IInterfaceB
            IInterfaceB b = demo;
            b.DoeIets();
        }
    }
}
