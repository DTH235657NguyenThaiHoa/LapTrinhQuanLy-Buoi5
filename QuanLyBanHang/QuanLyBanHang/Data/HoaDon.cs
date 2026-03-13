using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyBanHang.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public class KhachHang
        {
            public int ID { get; set; }
            public string HoVaTen { get; set; }
        }
        public class NhanVien
        {
            public int ID { get; set; }
            public string HoVaTen { get; set; }
        }
    }
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm
        public int KhachHangID { get; set; }
        public string HoVaTenKhachHang { get; set; } // Thêm
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; } // Thêm
        public double? TongTienHoaDon { get; set; } // Thêm
    }
}
