namespace NoticeBoardAPI.Models
{
    public class Notice
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public DateTime PostedAt { get; set; }
    }
}
