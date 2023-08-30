using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> ds = new List<SinhVien>();
            SinhVien sv1 = new SinhVien();
            sv1.MaSV = 11111;
            sv1.HoTenSV = "Huỳnh Hữu Đức";
            sv1.DiemLT = 8.9;
            sv1.DiemTH = 8.5;
            ds.Add(sv1);
            SinhVien sv2 = new SinhVien();
            sv2.MaSV = 22222;
            sv2.HoTenSV = "Huỳnh Hữu Tính";
            sv2.DiemLT = 7.3;
            sv2.DiemTH = 8.8;
            ds.Add(sv2);
            SinhVien sv3 = new SinhVien();
            Console.WriteLine("Nhập mã số sinh viên: ");
            sv3.MaSV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập họ tên sinh viên: ");
            sv3.HoTenSV = Convert.ToString(Console.ReadLine());
            Console.Write("Nhập điểm lý thuyết của sinh viên: ");
            sv3.DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập điểm thực hành của sinh viên: ");
            sv3.DiemTH = Convert.ToDouble(Console.ReadLine());
            ds.Add(sv3);

            Console.WriteLine("{0, -5} {1, -30} {2, 5} {3, 5} {4, 5}", "Mã SV", "Họ Tên Sinh Viên", "LT", "TH", "TB");
            if (ds != null && ds.Count > 0)
            {
                foreach (SinhVien sv in ds)
                {
                    Console.WriteLine("{0, -5} {1, -30} {2, 5} {3, 5} {4, 5}",
                                      sv.MaSV, sv.HoTenSV, sv.DiemLT, sv.DiemTH, sv.DiemTB());
                }
            }
            Console.ReadLine();
        }
     
    }
}
