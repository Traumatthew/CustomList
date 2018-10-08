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
            CustomList<int> listOne = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listOne.Add(4);
            listOne.Add(5);
            listOne.Add(6);

            listOne.Remove(3);
        }
    }
}
