using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PersonelSystem.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required]
        public string GenderName { get; set; }
        [AllowNull]
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
