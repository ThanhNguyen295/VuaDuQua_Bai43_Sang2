using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuaDuQua_Bai43_Sang2.Models
{
    public class DangKyMonHoc
    {
        [Key]
        public string MaDangKy { get; set; }
        public DateTime NgayDangKy { get; set; }
        [ForeignKey("MonHoc")]
        public string MaMonHoc { get; set; }
        public MonHoc MonHoc { get; set; }
        [ForeignKey("SinhVien")]
        public string MaSinhVien { get; set; }
        public SinhVien SinhVien{ get; set; }
    }
}
