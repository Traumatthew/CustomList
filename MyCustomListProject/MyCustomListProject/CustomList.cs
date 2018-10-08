using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomListProject
{
    public class CustomList<T> : IEnumerable<T>
    {

        private T[] items = new T[5]; //Array
        public int Count { get { return count; } }
        private int count = 0;
        private int capacity = 4;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }

        }


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

        public override string ToString()
        {
            CustomList<T> customList = new CustomList<T>();
            for(int i = 0; i < Count; i++)
            {
              

            }
        }

        
        public static CustomList<T> operator +(CustomList<T> customList, CustomList<T> customList2)
        {

        }

        
    }

}
