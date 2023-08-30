using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TamGiac> ds = new List<TamGiac>();
            TamGiac tg1 = new TamGiac();
            tg1.Ma = 3;
            tg1.Mb = 4;
            tg1.Mc = 10;
            ds.Add(tg1);
            TamGiac tg2 = new TamGiac();
            tg2.Ma = 3;
            tg2.Mb = 10;
            tg2.Mc = 6;
            ds.Add(tg2);
            TamGiac tg3 = new TamGiac();
            tg3.Ma = 2;
            tg3.Mb = 3;
            tg3.Mc = 4;
            ds.Add(tg3);
            TamGiac tg4 = new TamGiac();
            tg4.Ma = 2;
            tg4.Mb = 2;
            tg4.Mc = 3;
            ds.Add(tg4);
            TamGiac tg5 = new TamGiac();
            tg5.Ma = 2;
            tg5.Mb = 2;
            tg5.Mc = 2;
            ds.Add(tg5);

            Console.WriteLine("{0,5} {1,5} {2,5} {3,-30} {4,5} {5,5}", "Ma", "Mb", "Mc", "Kiểm tam giác", "CV", "DT");
            if (ds != null && ds.Count > 0)
            {
                foreach (TamGiac tg in ds)
                {

                    Console.WriteLine("{0,5} {1,5} {2,5} {3,-30} {4,5} {5,5}",
                                      tg.Ma, tg.Mb, tg.Mc, tg.KiemTra(), tg.CV(), Math.Round(tg.DT(),2));
                }
            }
            Console.ReadLine();
        }
    }
}
