using System.ComponentModel.DataAnnotations;

namespace PersonelSystem.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
    }
}
