using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> one = new CustomList<int>();

            one.Add(1);
            one.Add(2);
            one.Add(3);
            one.Add(4);
            one.Add(5);
            one.Add(6);

            one.Remove(3);
        }
    }
}
