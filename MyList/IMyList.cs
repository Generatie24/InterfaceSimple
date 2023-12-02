using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo
{
    public interface IMyList
    {
        void Add(int item);
        bool Remove(int item);
        int GetItemAt(int index);
        void ToonAlles();
        int Count { get; }
    }
}
