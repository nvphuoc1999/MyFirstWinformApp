using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SinhVien
    {
        public int MaSo { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }
        public SinhVien()
        {
            MaSo = 1;
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
        public SinhVien(int id, string ten, string kh, float dtb)
        {
            MaSo = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }
        public int StudentID //Property dai dien cho thuoc tinh SID
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
    }
}
