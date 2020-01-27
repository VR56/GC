using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class MyResources : IDisposable
    {
        TextReader tr = null;

        public MyResources(string path)
        {
            Console.WriteLine("Aquiring Managed Resources");
            tr = new StreamReader(path);

            Console.WriteLine("Aquiring Unmanaged Resources");
            

        }

        void ReleaseManagedResources()
        {
            Console.WriteLine("Releasing Managed Resources");
            if (tr != null)
            {
                tr.Dispose();
            }
        }

        void ReleaseUnmangedResources()
        {
            Console.WriteLine("Releasing Unmanaged Resources");
        }

        public void ShowData()
        {

            if (tr != null)
            {
                Console.WriteLine(tr.ReadToEnd() + " /some unmanaged data ");
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called from outside");

            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Console.WriteLine("Actual Dispose called with a " + disposing.ToString());
            if (disposing == true)
            {
                ReleaseManagedResources();
            }
            else
            {
            }

            ReleaseUnmangedResources();

        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~MyResources()
        {
            Console.WriteLine("Finalizer called");
            Dispose(false);
        }
    }
}
