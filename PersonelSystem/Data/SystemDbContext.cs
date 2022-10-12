using Microsoft.EntityFrameworkCore;
using PersonelSystem.Models;

namespace PersonelSystem.Data
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Gender
            modelBuilder.Entity<Gender>().HasData(new Gender
            {
                GenderId = 1,
                GenderName = "Female"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender
            {
                GenderId = 2,
                GenderName = "Male"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender
            {
                GenderId = 3,
                GenderName = "Other"
            });

            // Department
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 2,
                DepartmentName = "Economy"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 3,
                DepartmentName = "Sales"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 4,
                DepartmentName = "It"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 5,
                DepartmentName = "Management"
            });
            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentId = 6,
                DepartmentName = "Administration"
            });

            // Staff
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 1,
                FirstName = "Elin",
                LastName = "Ericstam",
                Email = "eline@mail.com",
                PhoneNumber = "070-12312312",
                GenderId = 1,
                StreetAdress = "Gatan 2",
                City = "Varberg",
                ZipCode = "43237",
                Salary = 30000m,
                DepartmentId = 4,
                
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 2,
                FirstName = "Oskar",
                LastName = "Johansson",
                Email = "oskarj@mail.com",
                PhoneNumber = "070-12312343",
                GenderId = 2,
                StreetAdress = "Gatan 5",
                City = "Göteborg",
                ZipCode = "43243",
                Salary = 32000m,
                DepartmentId = 2
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 3,
                FirstName = "Michael",
                LastName = "Scott",
                Email = "michaels@mail.com",
                PhoneNumber = "070-43212312",
                GenderId = 2,
                StreetAdress = "Vägen 12",
                City = "Kungsbacka",
                ZipCode = "42345",
                Salary = 30000m,
                DepartmentId = 5
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 4,
                FirstName = "Pam",
                LastName = "Beesly",
                Email = "pamb@mail.com",
                PhoneNumber = "070-12357312",
                GenderId = 1,
                StreetAdress = "Vägen 32",
                City = "Göteborg",
                ZipCode = "43242",
                Salary = 33000m,
                DepartmentId = 6
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 5,
                FirstName = "Jim",
                LastName = "Halpert",
                Email = "jimh@mail.com",
                PhoneNumber = "070-12357398",
                GenderId = 2,
                StreetAdress = "Vägen 54",
                City = "Göteborg",
                ZipCode = "43242",
                Salary = 31000m,
                DepartmentId = 3
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 6,
                FirstName = "Angela",
                LastName = "Martin",
                Email = "angelam@mail.com",
                PhoneNumber = "070-12357312",
                GenderId = 1,
                StreetAdress = "Gatan 5",
                City = "Varberg",
                ZipCode = "43236",
                Salary = 30000m,
                DepartmentId = 2
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 7,
                FirstName = "Toby",
                LastName = "Flenderson",
                Email = "tobyf@mail.com",
                PhoneNumber = "070-56757312",
                GenderId = 2,
                StreetAdress = "Gatan 76",
                City = "Varberg",
                ZipCode = "43238",
                Salary = 34000m,
                DepartmentId = 1
            });
            modelBuilder.Entity<Staff>().HasData(new Staff
            {
                StaffId = 8,
                FirstName = "Dwight",
                LastName = "Schrute",
                Email = "dwights@mail.com",
                PhoneNumber = "073-56123312",
                GenderId = 2,
                StreetAdress = "Gatan 7",
                City = "Varberg",
                ZipCode = "43236",
                Salary = 33000m,
                DepartmentId = 3
            });
        }
    }
}
