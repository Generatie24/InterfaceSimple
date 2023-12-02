using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    public interface IProduct
    {
        decimal Prijs { get; set; }
        decimal BerekenBelasting();
    }
}
