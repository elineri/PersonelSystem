using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PersonelSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [AllowNull]
        public virtual ICollection<Staff>? Staffs { get; set; }
    }
}
