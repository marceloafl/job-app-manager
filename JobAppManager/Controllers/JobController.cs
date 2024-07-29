using JobAppManager.Context;
using JobAppManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobAppManager.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobAppManagerContext _context;
        public JobsController(JobAppManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _context.Jobs.ToListAsync();
            if (jobs == null)
            {
                return NotFound();
            }
            return Ok(jobs);
        }

        [HttpGet("{id:int}", Name = "GetJobById")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(job => job.Id == id);
            if (job == null)
            {
                return NotFound();
            }
            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJob(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetJobById", new { id = job.Id }, job);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateJob(int id, Job job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _context.Entry(job).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(job);

        }

        [HttpDelete("{id:int}")]
        public async Task <IActionResult> DeleteJob(int id)
        {
            var jobToDelete = await _context.Jobs.FirstOrDefaultAsync(job => job.Id == id);
            if (jobToDelete == null)
            {
                return NotFound();
            }
            _context.Jobs.Remove(jobToDelete);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
