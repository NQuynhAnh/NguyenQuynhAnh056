using System.ComponentModel.DataAnnotations;

namespace NguyenQuynhAnh056.Models
{
    public class CompanyNQA056
    {
        [Key]
        [MaxLength(20)]
        [Display (Name ="Mã công ty")]
        public string CompanyId { get; set; }
        [MaxLength(50)]
        [Display (Name ="Tên công ty")]
        public string CompanyName { get; set;}
    }
}