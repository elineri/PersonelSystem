using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required]
        public string GenderName { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
