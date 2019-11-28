using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static List<SinhVien> nhapdanhsach()
        {
            List<SinhVien> Danhsach = new List<SinhVien>();
            int n;
            Console.WriteLine("Nhap so luong SV:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ===NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                SinhVien sv = new SinhVien();
                sv.NhapTT();
                Danhsach.Add(sv);
            }
            return Danhsach;
        }
        private static void xuatDSSV(List<SinhVien> Danhsach)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach (SinhVien sv in Danhsach)
            {
                sv.xuatTT();
            }
        }
        static void Main(string[] args)
        {
            /*
            //sinhVien[] DSSV;---1A
            //DSSV = new sinhVien[n]; //tao mang n phan tu-----1A
            List<sinhVien> Danhsach = new List<sinhVien>();
            int n;
            Console.WriteLine("Nhap so luong SV:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n ===NHAP DS SINH VIEN====");
            //1A
            /*for (int i = 0; i < n; i++)//lap n lan nhap thong tin sv
            {
                DSSV[i] = new sinhVien();
                Console.Write("Nhap MaSV {0} :", i + 1);
                DSSV[i].MaSo = Console.ReadLine();
                Console.Write("Ho ten SV:");
                DSSV[i].Ten = Console.ReadLine();
                Console.Write("Nhap Khoa:");
                DSSV[i].Khoa = Console.ReadLine();
                Console.Write("Nhap DiemTB:");
                DSSV[i].DiemTb = float.Parse(Console.ReadLine());


            }
            //1b

            for (int i = 0; i < n; i++)
            {
                sinhVien sv = new sinhVien();
                sv.NhapTT();
                Danhsach.Add(sv);
            }

            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            //1a
            /*foreach (sinhVien sv in DSSV)
            {
                Console.Write("MSSV: " + sv.MaSo);
                Console.WriteLine("Ten sv:" + sv.Ten);
                Console.WriteLine("Khoa:" + sv.Khoa);
                Console.WriteLine("Diem trung bih:" + sv.DiemTb);
            }
            //1b
            foreach (sinhVien sv in Danhsach)
            {
                sv.xuatTT();
            }*/
            List<SinhVien> danhsach = nhapdanhsach();
            xuatDSSV(danhsach);
            Console.ReadKey();
            List<SinhVien> Khoacntt = danhsach.Where(p => p.Khoa == "CNTT").ToList();
            if (Khoacntt.Count > 0)
            {
                Console.WriteLine("--- Cac sinh vien hoc khoa CNTT----");
                xuatDSSV(Khoacntt);
            }
            else
                Console.WriteLine("======Danh sach khong co sinh vien khoa CNTT");
            Console.ReadKey();
        }

    }
}