namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        TenKH = c.String(),
                        DiachiKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.DanhMucHangs",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        DonViTinh = c.String(),
                        SoLuong = c.String(),
                        GiaSP = c.String(),
                    })
                .PrimaryKey(t => t.MaHang);
            
            CreateTable(
                "dbo.Dondathang",
                c => new
                    {
                        Ngaytao = c.DateTime(nullable: false, storeType: "date"),
                        MaKH = c.String(),
                        TenKH = c.String(),
                        SĐT = c.Int(nullable: false),
                        MaSP = c.String(),
                        TenSP = c.String(),
                        Soluong = c.Int(nullable: false),
                        Thanhtien = c.String(),
                        Ngaynhanhang = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Ngaytao);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.Phieunhap",
                c => new
                    {
                        Ngaynhap = c.DateTime(nullable: false, storeType: "date"),
                        MaNV = c.String(),
                        TenNV = c.String(),
                        MaSP = c.String(),
                        TenSP = c.String(),
                        Soluong = c.String(),
                        Thanhtien = c.String(),
                    })
                .PrimaryKey(t => t.Ngaynhap);
            
            CreateTable(
                "dbo.Phieuxuat",
                c => new
                    {
                        Ngayxuat = c.DateTime(nullable: false, storeType: "date"),
                        MaNV = c.String(),
                        TenNV = c.String(),
                        MaSP = c.String(),
                        TenSP = c.String(),
                        Soluong = c.String(),
                        Thanhtien = c.String(),
                    })
                .PrimaryKey(t => t.Ngayxuat);
            
            CreateTable(
                "dbo.Donhang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        MaDH = c.String(),
                        Ngaytao = c.DateTime(nullable: false, storeType: "date"),
                        MaNV = c.String(),
                        TenSP = c.String(),
                        GiaSP = c.String(),
                    })
                .PrimaryKey(t => t.MaKH)
                .ForeignKey("dbo.KhachHangs", t => t.MaKH)
                .Index(t => t.MaKH);
            
            CreateTable(
                "dbo.Chitietdonhang",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        MaHang = c.String(),
                        DonGia = c.String(),
                        SoLuong = c.String(),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.MaKH)
                .ForeignKey("dbo.Donhang", t => t.MaKH)
                .Index(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chitietdonhang", "MaKH", "dbo.Donhang");
            DropForeignKey("dbo.Donhang", "MaKH", "dbo.KhachHangs");
            DropIndex("dbo.Chitietdonhang", new[] { "MaKH" });
            DropIndex("dbo.Donhang", new[] { "MaKH" });
            DropTable("dbo.Chitietdonhang");
            DropTable("dbo.Donhang");
            DropTable("dbo.Phieuxuat");
            DropTable("dbo.Phieunhap");
            DropTable("dbo.NhanViens");
            DropTable("dbo.Dondathang");
            DropTable("dbo.DanhMucHangs");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.Accounts");
        }
    }
}
