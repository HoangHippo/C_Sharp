using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSDL.Models
{
    class SanPham
    {
        private string _MaSP;
        private string _TenSP;
        private string _MoTa;
        private string _MaLoaiSP;
        private int _SoLuongTon;
        private long _DonGia;

        public SanPham()
        {
        }

        public SanPham(string MaSP, string TenSP, string MoTa, string MaLoaiSP, int soLuongTon, long donGia)
        {
            _MaSP = MaSP;
            _TenSP = TenSP;
            _MoTa = MoTa;
            _MaLoaiSP = MaLoaiSP;
            _SoLuongTon = soLuongTon;
            _DonGia = donGia;
        }

        public SanPham(SqlDataReader rd)
        {
            _MaSP = rd["MaSP"].ToString();
            _TenSP = rd["TenSP"].ToString();
            _MoTa = rd["MoTa"].ToString();
            _MaLoaiSP = rd["MaLoaiSP"].ToString();
            _SoLuongTon = (int)rd["SoLuongTon"];
            _DonGia = (long)rd["DonGia"];
        }

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string MoTa { get => _MoTa; set => _MoTa = value; }
        public string MaLoaiSP { get => _MaLoaiSP; set => _MaLoaiSP = value; }
        public int SoLuongTon { get => _SoLuongTon; set => _SoLuongTon = value; }
        public long DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
