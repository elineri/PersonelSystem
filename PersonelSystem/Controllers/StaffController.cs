using Microsoft.AspNetCore.Mvc;
using PersonelSystem.Models;

namespace PersonelSystem.Controllers
{
    public class StaffController : Controller
    {
        private readonly StaffRepository _staffRepository;

        public StaffController(StaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        // Get All Staff
        [HttpGet]
        public async Task<IActionResult> List()
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

        // Get StaffById
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Staff>> Details(int staffId)
        {
            try
            {
                var result = await _staffRepository.GetSingle(staffId);
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

        // Add Staff
        [HttpPost]
        public async Task<ActionResult<Staff>> AddNewStaff(Staff newStaff)
        {
            try
            {
                if (newStaff == null)
                {
                    return BadRequest();
                }
                var createdStaff = await _staffRepository.Add(newStaff);
                return CreatedAtAction(nameof(Details), new { id = newStaff.StaffId }, createdStaff);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Update Staff
        [HttpPut("{id}")]
        public async Task<ActionResult<Staff>> UpdateStaff(int id, Staff staff)
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
                return await _staffRepository.Update(staff);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to update database");
            }
        }

        // Delete Staff
        [HttpDelete("staff{id}")]
        public async Task<ActionResult<Staff>> DeleteStaff(int id)
        {
            try
            {
                var staffToDelete = _staffRepository.GetSingle(id);
                if (staffToDelete == null)
                {
                    return NotFound($"Staff with id {id} was not found");
                }
                return await _staffRepository.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to delete from database");
            }
        }
    }
}
