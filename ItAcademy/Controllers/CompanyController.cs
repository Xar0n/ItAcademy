using DAL.Data;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly AcademyContext _context;
        public CompanyController(AcademyContext context) { 
            _context = context;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
        {
            var companies = await _context.Companies.ToListAsync();
            return companies;
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
