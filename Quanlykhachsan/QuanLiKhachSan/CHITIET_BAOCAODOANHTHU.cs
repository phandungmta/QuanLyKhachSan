//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKhachSan
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIET_BAOCAODOANHTHU
    {
        public int MaBCCTDoanhThu { get; set; }
        public string MaLoaiPhong { get; set; }
        public int MaBCDoanhThu { get; set; }
        public Nullable<decimal> DoanhThuThang { get; set; }
        public string TiLe { get; set; }
    
        public virtual BAOCAO_DOANHTHUTHEOLOAIPHONG BAOCAO_DOANHTHUTHEOLOAIPHONG { get; set; }
    }
}
