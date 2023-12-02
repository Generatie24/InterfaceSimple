using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Car : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("Car stated");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Car stopped");
            return true;
        }
    }
}
