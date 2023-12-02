using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyListDemo

{
        public class MyList : IMyList
        {
            private int[] items;
            private int count;

            public MyList(int initieleCapaciteit)
            {
                items = new int[initieleCapaciteit];
                count = 0;
            }

            public int Count
            {
                get { return count; }
            }

            public void Add(int item)
            {
                if (count == items.Length)
                {
                    IncreaseCapacity();
                }
                items[count] = item;
                count++;
            }

            public bool Remove(int item)
            {
                for (int i = 0; i < count; i++)
                {
                    if (items[i] == item)
                    {
                        ShiftItems(i);
                        count--;
                        return true;
                    }
                }
                return false;
            }

            public int GetItemAt(int index)
            {
                if (index < 0 || index >= count)
                {
                Console.WriteLine("Index buiten bereik");
                }
                return items[index];
            }

            public void ToonAlles()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }

            private void IncreaseCapacity()
            {
                Array.Resize(ref items, items.Length * 2);
            }

            private void ShiftItems(int index)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
            }

        }
    }

