using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien[] DSSV;
            int n;
            Console.WriteLine("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());
            DSSV = new SinhVien[n]; //tao mang n phan tu
            Console.WriteLine("\n ===NHAP DS SINH VIEN====");
            //1A
            /*for (int i = 0; i < n; i++)//lap n lan nhap thong tin sv
            {
                DSSV[i] = new SinhVien();
                Console.Write("Nhap MaSV {0}:", i + 1);
                DSSV[i].StudentID=Console.ReadLine();
                Console.Write("Ho ten SV:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap Khoa:");
                DSSV[i].Faculty = Console.ReadLine();
                Console.Write("Nhap DiemTB:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }
            */
            for(int i=0;i<n;i++)
            {
                DSSV[i] = new SinhVien;

            }
            //xuat DS sinh vien
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (SinhVien sv in DSSV)
                sv.xuatTT();
            Console.ReadLine();
        }
    }
}
