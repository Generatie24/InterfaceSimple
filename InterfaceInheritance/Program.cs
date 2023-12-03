using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creëren van een instantie van Auto
            Auto mijnAuto = new Auto();

            // Aanroepen van de methoden
            mijnAuto.Starten();
            mijnAuto.Tanken();
            mijnAuto.Stoppen();
        }
    }
}
