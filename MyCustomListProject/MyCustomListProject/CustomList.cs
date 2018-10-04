using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomListProject
{
    public class CustomList<T>
    {
        
        private T[] items = new T[5]; //Array
        private int count = 0;
        public int Count { get { return count; } }
        private int capacity = 4;

        public void Add(T value)
        {
            if (items.Length > capacity)
            {
                T[] temp = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                temp[count] = value;
                count++;
                items = temp;
            }
            else if (items.Length <= capacity)
            {
                items.count = value;
            }
            
        }


        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        private void IncreaseItemSize()
        {
            if (items)
        }

        public bool Remove()
        {

        }
    }
   
}
