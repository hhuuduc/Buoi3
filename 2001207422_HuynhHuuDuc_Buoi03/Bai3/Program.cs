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
            TamGiac tg = new TamGiac();
            tg.Ma = 2;
            tg.Mb = 2;
            tg.Mc = 2;
            Console.WriteLine("CV:{0} DT:{1}", tg.CV(), tg.DT());
            tg.KiemTra();
            Console.ReadLine();
        }
    }
}
