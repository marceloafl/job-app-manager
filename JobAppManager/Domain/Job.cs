using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace JobAppManager.Domain
{
    public class Job
    {
        public Job()
        {
                Comments = new Collection<Comment>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? PublicationUrl { get; set; }
        public string? LocationCity { get; set; }
        public LocationType LocationType { get; set; }
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int RecruiterId { get; set; }
        public Recruiter? Recruiter { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
    public enum LocationType
    {
        Remote,
        Hybrid,
        OnSite
    }
}
