using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            return Ok(await _testimonialService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(Testimonial Testimonial)
        {
            await _testimonialService.TInsertAsync(Testimonial);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.TDeleteAsync(await _testimonialService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(Testimonial Testimonial)
        {
            await _testimonialService.TUpdateAsync(Testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {

            return Ok(await _testimonialService.TGetByIdAsync(id));
        }
    }
}
