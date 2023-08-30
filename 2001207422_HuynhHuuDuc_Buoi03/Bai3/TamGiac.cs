using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class TamGiac
    {
        private int ma, mb, mc;

        public int Mc
        {
            get { return mc; }
            set { mc = value; }
        }

        public int Mb
        {
            get { return mb; }
            set { mb = value; }
        }

        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }

        public double CV()
        {
            return Ma + Mb + Mc;
        }

        public double DT()
        {
            double nuaCV = (CV()/2);
            return Math.Sqrt(nuaCV * (nuaCV - Ma) * (nuaCV - Mb) * (nuaCV - Mc));
        }

        public TamGiac() { }

        public TamGiac(int a, int b, int c) {
            this.Ma = a;
            this.Mb = b;
            this.Mc = c;
        }

        public string KiemTra()
        {
            if (Ma + Mb < Mc || Ma + Mc < Mb || Mb + Mc < Ma)
            {
                //la tam giac
                return "day khong phai la tam giac ";
            }
            else if (Ma == Mb && Mb == Mc)
            {
                //tam giac deu
                return"day la tam giac deu";
            }
            else if (Ma == Mb || Ma == Mc || Mb == Mc) // 2 canh bat ky bang nhau
            {
                // tam giac can
                return "day la tam giac can";
            }
            else
            {
                // khong phai tam giac
                return "la  TAM GIAC ";
            }
        }

    }
}
