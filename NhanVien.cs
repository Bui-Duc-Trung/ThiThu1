using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu1
{
    internal class NhanVien
    {
        private int ID { get; set; }
        private string Ten { get; set; }
        private double Luong { get; set; }
        
        public virtual void InThongTin()
        {
            Console.WriteLine($"ID NV: {this.ID} - Ten NV: {this.Ten} - Luong NV: {this.Luong}");

        }
        public NhanVien()
        {
            
        }

        public NhanVien(int iD, string ten, double luong)
        {
            ID = iD;
            Ten = ten;
            Luong = luong;
        }
    }
}
