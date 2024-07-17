namespace JobAppManager.Domain
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime DateTime { get; set; }
        public int? JobId { get; set; }
        public Job? Job { get; set; }
    }
}
