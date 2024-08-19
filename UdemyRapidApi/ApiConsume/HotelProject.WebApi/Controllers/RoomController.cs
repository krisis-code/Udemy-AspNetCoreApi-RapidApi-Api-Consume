using HotelProject.BusinessLayer.Abstract;
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

        public RoomController(IRoomService roomService)
        {
                _roomService = roomService;
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            return Ok(await _roomService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddRoom(Room room)
        {
            await _roomService.TInsertAsync(room);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.TDeleteAsync( await _roomService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task < IActionResult> UpdateRoom(Room room)
        {
            await _roomService.TUpdateAsync(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom(int id)
        {
            
            return Ok(await _roomService.TGetByIdAsync(id));
        }
    }
}
