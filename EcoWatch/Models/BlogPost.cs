using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoWatch.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
         
        public IdentityUser User { get; set; }= new IdentityUser(); 
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        
     }
}
