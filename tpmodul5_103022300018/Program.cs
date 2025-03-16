using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_103022300018
{
    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Muhammad Fadli Achsan Kurniawan");

            string nim = "103022300018";
            DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
            dataNIM.PrintData();
        }
    }
}
