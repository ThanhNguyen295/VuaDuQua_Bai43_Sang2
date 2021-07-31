using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VuaDuQua_Bai43_Sang2.Models
{
    public class ChuyenNganh
    {
        [Key]
        public string MaChuyenNganh { get; set; }
        public string TenChuyenNhanh { get; set; }
        public ICollection<SinhVien> SinhViens { get; set; }
        public ICollection<MonHoc> MonHocs { get; set; }
    }
}