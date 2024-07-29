using JobAppManager.Context;
using JobAppManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobAppManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly JobAppManagerContext _context;
        public CompaniesController(JobAppManagerContext context)
        {
            _context = context;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchCompany([FromQuery] string searchValue)
        {
            if(searchValue == null)
            {
                return BadRequest(string.Empty);
            }

            var companies = await _context.Companies.Where(c => c.Name.Contains(searchValue)).ToListAsync();
            return Ok(companies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(CreateCompany), new { id = company.Id }, company);
        }
    }
}
