using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace JobAppManager.Domain
{
    public class Company
    {
        public Company()
        {
            Jobs = new Collection<Job>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZIPCode { get; set; }
        public string? Website { get; set; }
        public string? Phone { get; set; }
        public ICollection<Job>? Jobs { get; set; }
    }
}
