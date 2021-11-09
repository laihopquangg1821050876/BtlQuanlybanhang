using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("Dondathang")]
    public class Dondathang
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Ngaytao { get; set; }
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public int SĐT {get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int Soluong { get; set; }
        public string Thanhtien { get; set; }
        [Column(TypeName = "date")]
        public DateTime Ngaynhanhang { get; set; }

    }
}