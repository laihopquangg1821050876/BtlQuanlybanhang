using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLon.Models
{
    [Table("Phieunhap")]
    public class Phieunhap
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Ngaynhap { get; set; }
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string MaSP {get; set; }
        public string TenSP {get; set; }
        
        public string Soluong { get; set; }
        public string Thanhtien { get; set; }


    }
}