using System.ComponentModel.DataAnnotations;

namespace CourseEduWeb.Models
{
    public class KhoaHoc
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string TenKhoaHoc { get; set; }
        public ICollection<MonHoc> MonHoc { get; set; }
    }
}
