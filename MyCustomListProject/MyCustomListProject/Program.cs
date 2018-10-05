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
            CustomList<int> listone = new CustomList<int>();

            listone.Add(1);
            listone.Add(2);
            listone.Add(3);
            listone.Add(4);
            listone.Add(5);
            listone.Add(6);

            listone.Remove(3);
        }
    }
}
