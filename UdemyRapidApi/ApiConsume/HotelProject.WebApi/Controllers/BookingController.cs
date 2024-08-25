using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.AboutDto;
using HotelProject.DtoLayer.Dtos.BookingDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            return Ok(await _bookingService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddAbout(BookingAddDto bookingAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _bookingService.TInsertAsync(_mapper.Map<Booking>(bookingAdd));
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _bookingService.TDeleteAsync(await _bookingService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(BookingUpdateDto bookingUpdate)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _bookingService.TUpdateAsync(_mapper.Map<Booking>(bookingUpdate));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {

            return Ok(await _bookingService.TGetByIdAsync(id));
        }
    }
}
