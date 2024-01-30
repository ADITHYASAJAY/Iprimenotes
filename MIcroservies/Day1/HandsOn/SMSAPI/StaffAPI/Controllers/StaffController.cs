using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffAPI.Models;
using StaffAPI.Repository;
using static StaffAPI.Repository.StaffRepository;

namespace StaffAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository) 
        {
            this._staffRepository = staffRepository;
        }
        [HttpGet,Route("GetAllStaffs")]
        public IActionResult GetAll() 
        {
            try 
            { 
                return Ok(this._staffRepository.GetAll());
            }
            catch (Exception) 
            {
                throw;
            }
        }
        [HttpGet,Route("GetAllStaffByStd/{std}")]
        public IActionResult GetByStd(string std) 
        {
            try 
            {
                return Ok(_staffRepository.GetStaffByStd(std));
            }
            catch (Exception ) 
            {
                throw;
            }
        }

        [HttpGet,Route("GetAllStaffBySubject/{subject}")]
        public IActionResult GetAllSubject(string subject) 
        {
            try 
            {
                return Ok(_staffRepository.GetStaffBySubjects(subject));
            }
            catch (Exception ) 
            {
                throw;
            }
        }

        [HttpGet,Route("GetStaff/{id}")]
        public IActionResult GetStaff( string id) 
        {
            try 
            {
                return Ok(_staffRepository.GetStaff(id));
            }
            catch (Exception ) 
            {
                throw;
            }
        }
        [HttpPost, Route("AddStaff")]
        public IActionResult Staff(Staff staff)
        {
            try
            {
                _staffRepository.AddStaff(staff);
                return Ok(staff);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("EditStaff")]
        public IActionResult Edit(Staff staff)
        {
            try
            {
                _staffRepository.UpdateStaff(staff);
                return Ok(staff);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete, Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _staffRepository.DeleteStaff(id);
                return Ok("Staff Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
