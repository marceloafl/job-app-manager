using JobAppManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace JobAppManager.Context
{
    public class JobAppManagerContext : DbContext
    {
        public JobAppManagerContext(DbContextOptions<JobAppManagerContext> options) : base(options) { }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Recruiter> Recruiters { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
