using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList(2);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(2);
            myList.Add(4);

            Console.WriteLine("totaal elementen in de list");
            Console.WriteLine(myList.Count);

            Console.WriteLine("Alle items in de lijst:");
            myList.ToonAlles();
        }
    }
}
