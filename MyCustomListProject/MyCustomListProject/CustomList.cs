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
        
        public int Count { get { return count; } }
        private int count = 0;
        private int capacity = 4;

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }

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
                items[count] = value;
            }
            
        }

        public void Remove(T value)
        {
            T[] temp = new T[capacity];
            int itemsRemoved = 0;
            for (int i = 0; i < count; i++)
            {
                if (!items[i].Equals(value))
                {
                    temp[i - itemsRemoved] = items[i];
                }
                else
                {
                    itemsRemoved = 1;
                }
            }
            
            count--;
            items = temp;
           
        }

        //public void SetCount(T value)
        //{
        //    count = 0;
        //    foreach (item in T)
        //    {
        //        count++;
        //    }
        //}
        
    }
   
}
