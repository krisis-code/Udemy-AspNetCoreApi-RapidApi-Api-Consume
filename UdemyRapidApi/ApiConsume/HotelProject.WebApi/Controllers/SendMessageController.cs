using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.SendMessageDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;
        private readonly IMapper _mapper;

        public SendMessageController(ISendMessageService sendMessageService, IMapper mapper)
        {
            _sendMessageService = sendMessageService;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> SendMessageList()
        {
            return Ok(await _sendMessageService.TGetListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(AddSendMessageDto addSendMessageDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            await _sendMessageService.TInsertAsync(_mapper.Map<SendMessage>(addSendMessageDto));
            return Ok();
        
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _sendMessageService.TDeleteAsync(await _sendMessageService.TGetByIdAsync(id));
            return Ok("Mesaj başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessage(UpdateSendMessageDto updateSendMessageDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

             await _sendMessageService.TUpdateAsync(_mapper.Map<SendMessage>(updateSendMessageDto));
                return Ok();
        }
    }
}
