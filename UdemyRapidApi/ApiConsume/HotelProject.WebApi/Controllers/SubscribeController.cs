using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService; 
        public SubscribeController(ISubscribeService subscribeService) 
        { 
            _subscribeService = subscribeService; 
        }

        [HttpGet]
        public async Task<IActionResult> SubscribList()
        {
            return Ok(await _subscribeService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddSubscrib(Subscribe subscribe)
        {

            await _subscribeService.TInsertAsync(subscribe);
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSubscrib(int id)
        {

            await _subscribeService.TDeleteAsync(await _subscribeService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubscrib(Subscribe subscribe)
        {
            await _subscribeService.TUpdateAsync(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubscrib(int id)
        {

            return Ok(await _subscribeService.TGetByIdAsync(id));
        }
    }
}
