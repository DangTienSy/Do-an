//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanVeXePhuongTrang.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYXEKHACHEntities : DbContext
    {
        public QUANLYXEKHACHEntities()
            : base("name=QUANLYXEKHACHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBaoCaoDoanhThuChuyenDi> tblBaoCaoDoanhThuChuyenDis { get; set; }
        public virtual DbSet<tblBaoCaoDoanhThuNam> tblBaoCaoDoanhThuNams { get; set; }
        public virtual DbSet<tblBaoCaoDoanhThuThang> tblBaoCaoDoanhThuThangs { get; set; }
        public virtual DbSet<tblBenXe> tblBenXes { get; set; }
        public virtual DbSet<tblChiTietChuyenDi> tblChiTietChuyenDis { get; set; }
        public virtual DbSet<tblChiTietPhieuDatCho> tblChiTietPhieuDatChoes { get; set; }
        public virtual DbSet<tblChiTietTrungChuyen> tblChiTietTrungChuyens { get; set; }
        public virtual DbSet<tblChuyenDi> tblChuyenDis { get; set; }
        public virtual DbSet<tblLoaiNhanVien> tblLoaiNhanViens { get; set; }
        public virtual DbSet<tblLoaiXe> tblLoaiXes { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblPhanQuyen> tblPhanQuyens { get; set; }
        public virtual DbSet<tblPhieuDatCho> tblPhieuDatChoes { get; set; }
        public virtual DbSet<tblTaiKhoan> tblTaiKhoans { get; set; }
        public virtual DbSet<tblTuyenXe> tblTuyenXes { get; set; }
        public virtual DbSet<tblXeKhach> tblXeKhaches { get; set; }
        public virtual DbSet<tblXeTrungChuyen> tblXeTrungChuyens { get; set; }
    }
}
