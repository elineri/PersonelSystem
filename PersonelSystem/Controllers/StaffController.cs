using Microsoft.AspNetCore.Mvc;
using PersonelSystem.Models;

namespace PersonelSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : Controller
    {
        private readonly ISystem<Staff> _staffRepository;

        public StaffController(ISystem<Staff> staffRepository)
        {
            _staffRepository = staffRepository;
        }

        // Get All Staff
        [HttpGet]
        public async Task<IActionResult> GetAllStaff()
        {
            try
            {
                return Ok(await _staffRepository.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database");
            }
        }

        // Get Staff By Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Staff>> GetStaffById(int id)
        {
            try
            {
                var result = await _staffRepository.GetSingle(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from database");
            }
        }

        // Add Staff
        [HttpPost]
        public async Task<ActionResult<Staff>> AddNewStaff([FromBody]Staff newStaff)
        {
            try
            {
                if (newStaff == null)
                {
                    return BadRequest();
                }
                var createdStaff = await _staffRepository.Add(newStaff);
                return CreatedAtAction(nameof(GetStaffById), new { id = createdStaff.StaffId }, createdStaff);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add data to database");
            }
        }

        // Update Staff
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Staff>> UpdateStaff([FromRoute]int id, Staff staff)
        {
            try
            {
                if (id != staff.StaffId)
                {
                    return BadRequest("Id does not match");
                }
                var staffToUpdate = _staffRepository.GetSingle(id);
                if (staffToUpdate == null)
                {
                    return NotFound($"Staff with id {id} was not found");
                }
                return Ok(await _staffRepository.Update(staff));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update database");
            }
        }

        // Delete Staff
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Staff>> DeleteStaff([FromRoute]int id)
        {
            try
            {
                var staffToDelete = await _staffRepository.GetSingle(id);
                if (staffToDelete == null)
                {
                    return NotFound($"Staff with id {id} was not found");
                }
                await _staffRepository.Delete(id);
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to delete from database");
            }
        }
    }
}
