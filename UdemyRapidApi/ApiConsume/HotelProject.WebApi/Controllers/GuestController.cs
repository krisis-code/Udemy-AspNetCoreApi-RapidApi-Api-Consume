using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.GuestDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : Controller
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GuestList()
        {
            return Ok(await _guestService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddGuest(GuestAddDto guestAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _guestService.TInsertAsync(_mapper.Map<Guest>(guestAddDto));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuest(int id)
        {
            await _guestService.TDeleteAsync(await _guestService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGuest(GuestUpdateDto guestUpdateDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _guestService.TUpdateAsync(_mapper.Map<Guest>(guestUpdateDto));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGuest(int id)
        {

            return Ok(await _guestService.TGetByIdAsync(id));
        }
    }
}
