using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
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
        public async Task<IActionResult> BookingList()
        {
            return Ok(await _bookingService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddBooking(BookingAddDto bookingAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _bookingService.TInsertAsync(_mapper.Map<Booking>(bookingAdd));
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _bookingService.TDeleteAsync(await _bookingService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public async Task<IActionResult> UpdateBooking(BookingUpdateDto bookingUpdate)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _bookingService.TUpdateAsync(_mapper.Map<Booking>(bookingUpdate));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {

            return Ok(await _bookingService.TGetByIdAsync(id));
        }

        [HttpPut("BookingStatusChangeAprovedAsync")]
        public async Task<IActionResult> BookingStatusChangeAprovedAsync(Booking booking)
        {
            await _bookingService.TBookingStatusChangeAprovedAsync(booking);
            return Ok();
        }
        [HttpGet("BookingStatusChangeAprovedByIdAsync")]
    
        public async Task<IActionResult> BookingStatusChangeAprovedByIdAsync(int id)
        {
          await  _bookingService.TBookingStatusChangeAprovedByIdAsync(id);
            return Ok();
        }

    }
}
