using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BaiTapLon.Models
{
    public partial class BTLDbContext : DbContext
    {
        public BTLDbContext()
            : base("name=BTLDbContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<BaiTapLon.Models.DonHang> DonHangs { get; set; }

        public System.Data.Entity.DbSet<BaiTapLon.Models.ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Phieunhap> Phieunhap { get; set; }
        public virtual DbSet<Phieuxuat> Phieuxuat { get; set; }
        public virtual DbSet<Dondathang> Dondathangs { get; set; }


        
    }
}
