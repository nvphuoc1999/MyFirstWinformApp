using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{//pl
    class SinhVien
    {
        public string MaSo { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }
        public SinhVien()
        {
            MaSo = "1";
            TenSV = "Nguyen Van A";
            Khoa = "CNTT";
            DiemTB = 7;
        }
        public SinhVien(SinhVien stu)
        {
            MaSo = stu.MaSo;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }
        public SinhVien(string id, string ten, string kh, float dtb)
        {
            MaSo = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public string StudentID //Property dai dien cho thuoc tinh SID
        {
            get { return MaSo; } //lay du lieu
            set { MaSo = value; } //Gan du lieu
        }
        public string Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }
        public string Faculty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }
        public double Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }
        public void NhapTT()
        {
            Console.Write("Nhap MSV:");
            MaSo = Console.ReadLine();
            Console.Write("Nhap Ten: ");
            TenSV = Console.ReadLine();
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap DTB: ");
            DiemTB = Convert.ToDouble(Console.ReadLine());
        }
        public void xuatTT()
        {
            Console.WriteLine("MSSV: " + this.MaSo);
            Console.WriteLine("Ten: " + this.TenSV);
            Console.WriteLine("Khoa: " + this.Khoa);
            Console.WriteLine("Nhap DTB: " + this.DiemTB);
        }
    }
}
