using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
{
    internal class QLNhanVien
    {
        public List<NhanVien> DanhSachNV {  get; set; }
        public QLNhanVien ()
        {
            DanhSachNV = new List<NhanVien>();
        }
        public void ThemNhanVien()
        {
            int tieptuc = -1;
            do
            {
                Console.Write("Nhap ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nhap luong: ");
                double luong = double.Parse(Console.ReadLine());
                NhanVien nhanVien = new NhanVien(id, ten, luong);
                this.DanhSachNV.Add(nhanVien);
                Console.Write("Co them NV nua khong (1-co/0-khong): ");
                tieptuc = int.Parse(Console.ReadLine());
            } while (tieptuc == 1);
        }
        public void XuatDanhSachNhanVien()
        {
            foreach (NhanVien nv in this.DanhSachNV)
            {
                nv.InThongTin();
            }
        }
    }
}
