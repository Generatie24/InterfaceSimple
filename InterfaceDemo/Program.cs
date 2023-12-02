using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMachine[] machines = new IMachine[2];
            //machines[0] = new TV();
            //machines[1] = new Car();

            //foreach (IMachine machine in machines)
            //{
            //    machine.Start();
            //    machine.Stop();
            //}

            Car car = new Car();
            TV tv = new TV();
        }

        //static void StartMachine(IMachine machine)
        //{
        //    machine.Start();
        //}

        static void StartMachine(Car car)
        {
            car.Start();
        }
    }
}
