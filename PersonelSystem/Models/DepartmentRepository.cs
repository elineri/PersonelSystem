using Microsoft.EntityFrameworkCore;
using PersonelSystem.Data;

namespace PersonelSystem.Models
{
    public class DepartmentRepository : ISystem<Department>
    {
        private readonly SystemDbContext _context;

        public DepartmentRepository(SystemDbContext context)
        {
            _context = context;
        }
        public async Task<Department> Add(Department newEntity)
        {
            var result = await _context.Departments.AddAsync(newEntity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Department> Delete(int id)
        {
            var result = await _context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == id);
            if (result == null)
            {
                return null;
            }

            _context.Departments.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetSingle(int id)
        {
            return await _context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == id);
        }

        public async Task<Department> Update(Department Entity)
        {
            var result = await _context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == id);
            if (result == null)
            {
                return null;
            }
            result.DepartmentId = Entity.DepartmentId;
            result.DepartmentName = Entity.DepartmentName;

            await _context.SaveChangesAsync();
            return result;
        }
    }
}
