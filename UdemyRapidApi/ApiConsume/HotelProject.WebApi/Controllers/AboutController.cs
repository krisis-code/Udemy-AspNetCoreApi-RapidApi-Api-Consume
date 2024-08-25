using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.AboutDto;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            return Ok(await _aboutService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddAbout(AboutAddDto aboutAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _aboutService.TInsertAsync(_mapper.Map<About>(aboutAddDto));
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.TDeleteAsync(await _aboutService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(AboutUpdateDto aboutUpdate)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _aboutService.TUpdateAsync(_mapper.Map<About>(aboutUpdate));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {

            return Ok(await _aboutService.TGetByIdAsync(id));
        }
    }
}
