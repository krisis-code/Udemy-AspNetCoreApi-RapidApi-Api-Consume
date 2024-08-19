using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public  async Task<IActionResult> StaffList()
        {
            return Ok(await _staffService.TGetListAsync());
        }
        [HttpPost]
        public  async Task<IActionResult> AddStaff(Staff staff)
        {
            
            await _staffService.TInsertAsync(staff);
            return Ok();
          
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteStaff(int id)
        {

            await _staffService.TDeleteAsync(await _staffService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStaff(Staff staff)
        {
            await _staffService.TUpdateAsync(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff(int id)
        {
            
            return Ok(await _staffService.TGetByIdAsync(id));
        }
    }
}
