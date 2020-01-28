using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VList
{
    class Program
    {
        static void Main(string[] args)
        {
            VList LL = new VList();

            LL.Add(LL, 3,1);
            LL.Add(LL, 4,2);
            LL.Add(LL, 5,3);
            LL.Add(LL, 6,4);
            
            LL.Remove(LL, 2);
            LL.Print(LL);
            Console.WriteLine(LL.Search(LL,5));
            Console.WriteLine(LL.KSearch(LL, 5));
            Console.WriteLine(LL.DSearch(LL, 1));
            Console.ReadLine();
        }
    }
}
