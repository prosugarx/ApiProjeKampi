using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Dtos.ContactDtos;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult ContextList()
        {
            var value = _context.Contacts.ToList();
            return Ok(value);
        }
        [HttpPost]//burada manuel mappingyapıtk
        public IActionResult CreateContact(CreateContactDtos createContactDtos)
        {
            Contact contact = new Contact();
            contact.Email = createContactDtos.Email;
            contact.Address = createContactDtos.Address;
            contact.Phone = createContactDtos.Phone;
            contact.OpenHours = createContactDtos.OpenHours;
            contact.MapLocation = createContactDtos.MapLocation;
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("Ekleme işlemi başaılı");
        }
    }
}
