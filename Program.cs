using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            MyResources r = null;

            try
            {
                r = new MyResources(@"C:\Users\Vishal_Tulugu\Desktop\Test.txt");
                r.ShowData();
                Console.ReadLine();
            }
            finally
            {
                r.Dispose();
                Console.ReadLine(); ;
            }
        }
    }
}
