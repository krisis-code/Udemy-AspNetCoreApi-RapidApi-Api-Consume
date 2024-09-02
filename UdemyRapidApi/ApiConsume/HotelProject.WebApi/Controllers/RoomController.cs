using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
                _roomService = roomService;
                _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            return Ok(await _roomService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(RoomAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _roomService.TInsertAsync(_mapper.Map<Room>(roomAddDto));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.TDeleteAsync(await _roomService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task < IActionResult> UpdateRoom(UpdateRoomDto updateRoomDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _roomService.TUpdateAsync(_mapper.Map<Room>(updateRoomDto));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            
            return Ok(await _roomService.TGetByIdAsync(id));
        }
    }
}
