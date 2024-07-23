using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace JobAppManager.Domain
{
    public class Recruiter
    {
        public Recruiter()
        {
            Recruiters = new Collection<Recruiter>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? LinkedInProfileUrl { get; set; }
        public ICollection<Recruiter>? Recruiters { get; set; }
    }
}
