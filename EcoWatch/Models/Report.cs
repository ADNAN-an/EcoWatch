namespace EcoWatch.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public string Type { get; set; }
        public byte[] Image { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
