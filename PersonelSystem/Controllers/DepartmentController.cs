using Microsoft.AspNetCore.Mvc;
using PersonelSystem.Models;

namespace PersonelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly ISystem<Department> _departmentRepository;

        public DepartmentController(ISystem<Department> departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        // Get All Departments
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
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
        public async Task<ActionResult<Department>> GetDepartmentById(int id)
        {
            try
            {
                var department = await _departmentRepository.GetSingle(id);
                if (department == null)
                {
                    return NotFound();
                }
                return Ok(department);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database");
            }
        }

        // Add Department
        [HttpPost]
        public async Task<ActionResult<Department>> AddNewDepartment([FromBody]Department newDepartment)
        {
            try
            {
                if (newDepartment == null)
                {
                    return BadRequest();
                }
                var createdDepartment = await _departmentRepository.Add(newDepartment);
                return CreatedAtAction(nameof(GetDepartmentById), new { id = createdDepartment.DepartmentId }, createdDepartment);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add data to database");
            }
        }

        // Update Department
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Department>> UpdateDepartment([FromRoute]int id, Department department)
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
                return Ok(await _departmentRepository.Update(department));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update database");
            }
        }

        // Delete Department
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Department>> DeleteDepartment([FromRoute]int id)
        {
            try
            {
                var depToDelete = await _departmentRepository.GetSingle(id);
                if (depToDelete == null)
                {
                    return NotFound($"Department with id {id} was not found");
                }
                await _departmentRepository.Delete(id);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to delete from database");
            }
        }
    }
}
