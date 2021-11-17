using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSDL.Models
{
    class LoaiSP
    {
        private string _MaLoaiSP;
        private string _TenLoaiSP;

        public LoaiSP()
        {
        }

        public LoaiSP(string MaLoaiSP, string TenLoaiSP)
        {
            _MaLoaiSP = MaLoaiSP;
            _TenLoaiSP = TenLoaiSP;
        }

        public LoaiSP(SqlDataReader rd)
        {
            _MaLoaiSP = rd["MaLoaiSP"].ToString();
            _TenLoaiSP = rd["TenLoaiSP"].ToString();
        }

        public string MaLoaiSP { get => _MaLoaiSP; set => _MaLoaiSP = value; }
        public string TenLoaiSP { get => _TenLoaiSP; set => _TenLoaiSP = value; }
    }
}
