using Microsoft.EntityFrameworkCore;
using PersonelSystem.Data;

namespace PersonelSystem.Models
{
    public class StaffRepository : ISystem<Staff>
    {
        private readonly SystemDbContext _context;

        public StaffRepository(SystemDbContext context)
        {
            _context = context;
        }

        public async Task<Staff> Add(Staff newEntity)
        {
            var result = await _context.Staff.AddAsync(newEntity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Staff> Delete(int id)
        {
            var result = await _context.Staff.FirstOrDefaultAsync(s => s.StaffId == id);

            if (result == null)
            {
                return null;
            }

            _context.Staff.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Staff>> GetAll()
        {
            return await _context.Staff.ToListAsync();
        }

        public async Task<Staff> GetSingle(int id)
        {
            return await _context.Staff.FirstOrDefaultAsync(s => s.StaffId == id);
        }

        public async Task<Staff> Update(Staff Entity)
        {
            var result = await _context.Staff.FirstOrDefaultAsync(s => s.StaffId == Entity.StaffId);
            if (result == null)
            {
                return null;
            }
            result.FirstName = Entity.FirstName;
            result.LastName = Entity.LastName;
            result.Email = Entity.Email;
            result.PhoneNumber = Entity.PhoneNumber;
            result.GenderId = Entity.GenderId;
            result.StreetAdress = Entity.StreetAdress;
            result.City = Entity.City;
            result.ZipCode = Entity.ZipCode;
            result.Salary = Entity.Salary;
            result.DepartmentId = Entity.DepartmentId;

            await _context.SaveChangesAsync();
            return result;
        }
    }
}
