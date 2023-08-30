using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class SinhVien
    {
        private int maSV;

        public int MaSV
        {
          get { return maSV; }
          set { maSV = value; }
        }
        private string hoTenSV;

        public string HoTenSV
        {
            get { return hoTenSV; }
            set { hoTenSV = value; }
        }
        private double diemLT, diemTH;

        public double DiemLT
        {
            get { return diemLT; }
            set { diemLT = value; }
        }

        public double DiemTH
        {
            get { return diemTH; }
            set { diemTH = value; }
        }

        public double DiemTB()
        {
            return (DiemLT + DiemTH) / 2;
        }

        //public int maSV { get; set; }
        //public string hoTenSV { get; set; }
        //public double diemLT { get; set; }
        //public double diemTH { get; set; }


    }
}
