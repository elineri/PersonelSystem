using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}
