using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class TV : IMachine
    {
        public bool Start()
        {
            Console.WriteLine("TV switched on");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("TV switched Off");
            return true;
        }
    }
}
