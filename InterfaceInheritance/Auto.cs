using System;

namespace InterfaceInheritance
{
    // Een klasse Auto die IMotorVoertuig implementeert
    public class Auto : IMotorVoertuig
    {
        public void Starten()
        {
            // Implementatie van Starten
            Console.WriteLine("De auto start.");
        }

        public void Stoppen()
        {
            // Implementatie van Stoppen
            Console.WriteLine("De auto stopt.");
        }

        public void Tanken()
        {
            // Implementatie van Tanken
            Console.WriteLine("De auto wordt getankt.");
        }
    }
}
