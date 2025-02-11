using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChefsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ChefsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ChefsList()
        {
            var value = _context.Chefs.ToList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateChefs(Chef chef)
        {
            var value = _context.Chefs.Add(chef);
            _context.SaveChanges();
            return Ok("Chef ekleme işlemi başarılı");
        }

        [HttpGet("GetChefs")]
        public IActionResult GetChefs(int id)
        {
            var value = _context.Chefs.Find(id);
            return Ok(value);
        }

        [HttpDelete]
        public IActionResult DeleteChefs(int id)
        {
            var value = _context.Chefs.Find(id);
            _context.Chefs.Remove(value);
            _context.SaveChanges();
            return Ok("Şef silme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult UpdateChefs(Chef chef)
        {
            _context.Chefs.Update(chef);
            _context.SaveChanges();
            return Ok("Chef güncelleme işlemi başarılı");
        }
    }
}
