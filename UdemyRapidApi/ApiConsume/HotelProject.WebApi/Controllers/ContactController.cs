using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.ContactDto;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            return Ok(await _contactService.TGetListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(ContactAddDto contactAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            await _contactService.TInsertAsync(_mapper.Map<Contact>(contactAddDto));
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactService.TDeleteAsync(await _contactService.TGetByIdAsync(id));
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(ContactUpdateDto ContactUpdate)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _contactService.TUpdateAsync(_mapper.Map<Contact>(ContactUpdate));
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {

            return Ok(await _contactService.TGetByIdAsync(id));
        }
    }
}
