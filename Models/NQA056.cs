using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenQuynhAnh056.Models
{
    public class NQA056
    {
        [Key]
        [Display (Name ="Mã")]
        public string NQAId { get; set; }
        [Display (Name ="Tên")]
        public string NQAName { get; set; }
        [Display (Name = "Giới tính")]
        public string NQAGender { get; set; }
    }
}