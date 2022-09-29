using Microsoft.AspNetCore.Mvc;
using PersonelSystem.Models;

namespace PersonelSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepository _departmentRepository;

        public DepartmentController(DepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // Get All Departments
        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                return Ok(await _departmentRepository.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database");
            }
        }

        // Get Department By Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> Details(int departmentId)
        {
            try
            {
                var result = await _departmentRepository.GetSingle(departmentId);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database");
            }
        }

        // Add Department
        [HttpPost]
        public async Task<ActionResult<Department>> AddNewDepartment(Department newDepartment)
        {
            try
            {
                if (newDepartment == null)
                {
                    return BadRequest();
                }
                var createdDepartment = await _departmentRepository.Add(newDepartment);
                return CreatedAtAction(nameof(Details), new { id = newDepartment.DepartmentId }, createdDepartment);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add data to database");
            }
        }

        // Update Department
        [HttpPut("{id}")]
        public async Task<ActionResult<Department>> UpdateDepartment(int id, Department department)
        {
            try
            {
                if (id != department.DepartmentId)
                {
                    return BadRequest("Id does not match");
                }
                var depToUpdate = _departmentRepository.GetSingle(id);
                if (depToUpdate == null)
                {
                    return NotFound($"Department with id {id} was not found");
                }
                return await _departmentRepository.Update(department);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update database");
            }
        }

        // Delete Department
        [HttpDelete("department{id}")]
        public async Task<ActionResult<Department>> DeleteDepartment(int id)
        {
            try
            {
                var depToDelete = _departmentRepository.GetSingle(id);
                if (depToDelete == null)
                {
                    return NotFound($"Department with id {id} was not found");
                }
                return await _departmentRepository.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to delete from database");
            }
        }
    }
}
