using JobAppManager.Context;
using JobAppManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobAppManager.Controllers
{
    public class RecruitersController : Controller
    {
        private readonly JobAppManagerContext _context;
        public RecruitersController(JobAppManagerContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}", Name = "GetRecruiterById")]
        public async Task<IActionResult> GetRecruiterById(int id)
        {
            var recruiter = await _context.Recruiters.FirstOrDefaultAsync(rec => rec.Id == id);
            if (recruiter == null)
            {
                return NotFound();
            }
            return Ok(recruiter);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecruiter(Recruiter recruiter)
        {
            _context.Recruiters.Add(recruiter);
            await _context.SaveChangesAsync();
            return Created();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateRecruiter(int id, Recruiter recruiter)
        {
            if (id != recruiter.Id)
            {
                return BadRequest();
            }

            _context.Entry(recruiter).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(recruiter);

        }
    }
}
