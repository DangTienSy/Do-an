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
    using System.Collections.Generic;
    
    public partial class tblLoaiXe
    {
        public tblLoaiXe()
        {
            this.tblXeKhaches = new HashSet<tblXeKhach>();
            this.tblXeTrungChuyens = new HashSet<tblXeTrungChuyen>();
        }
    
        public int MaLoaiXe { get; set; }
        public string TenLoaiXe { get; set; }
    
        public virtual ICollection<tblXeKhach> tblXeKhaches { get; set; }
        public virtual ICollection<tblXeTrungChuyen> tblXeTrungChuyens { get; set; }
    }
}
