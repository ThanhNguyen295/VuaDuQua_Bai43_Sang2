using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuaDuQua_Bai43_Sang2.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }
        [ForeignKey("ChuyenNganh")]
        public string MaChuyenNganh { get; set; }
       public ChuyenNganh ChuyenNganh { get; set; }
    }
}