using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            return Ok(await _serviceService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddService(Service Service)
        {
            await _serviceService.TInsertAsync(Service);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteService(int id)
        {
            await _serviceService.TDeleteAsync(await _serviceService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(Service Service)
        {
            await _serviceService.TUpdateAsync(Service);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {

            return Ok(await _serviceService.TGetByIdAsync(id));
        }
    }
}
