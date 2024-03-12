namespace EcoWatch.Models
{
    public class BlogPost
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        
     }
}
