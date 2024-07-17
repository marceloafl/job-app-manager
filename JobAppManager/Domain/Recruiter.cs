using System.Collections.ObjectModel;

namespace JobAppManager.Domain
{
    public class Recruiter
    {
        public Recruiter()
        {
            Recruiters = new Collection<Recruiter>();
        }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? LinkedInProfileUrl { get; set; }
        public ICollection<Recruiter>? Recruiters { get; set; }
    }
}
