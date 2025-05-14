using Application.DTOs.ContactDTOs;
using Application.DTOs.TagDTOs;
using Application.Services.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SICT_ShowCase.Controllers
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
        public async Task<IActionResult> GetAllContacts()
        {
            var tags = await _contactService.GetAllContactAsync();
            var tagDto = _mapper.Map<IEnumerable<ContactDto>>(tags);
            return Ok(tagDto);
        }

        // GET: api/contact/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            var tag = await _contactService.GetContactByIdAsync(id);
            if (tag == null)
                return NotFound();
            return Ok(tag);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(ContactDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var contact = _mapper.Map<Contact>(dto);
            await _contactService.AddContactAsync(contact);
            return Ok();
        }

        // PUT: api/contact/{id}
        [HttpPut]
        public async Task<IActionResult> UpdateContact(ContactDto dto)
        {
            var existing = await _contactService.GetContactByIdAsync(dto.Id);
            if (existing == null)
                return NotFound();

            var contact = _mapper.Map<Contact>(dto);
            await _contactService.UpdateContactAsync(contact);

            return Ok();
        }

        // DELETE: api/contact/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var tag = await _contactService.GetContactByIdAsync(id);
            if (tag == null)
                return NotFound();

            await _contactService.DeleteContactAsync(id);
            return Ok();
        }
    }
}
