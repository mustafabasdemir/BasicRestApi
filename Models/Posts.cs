using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    //veritabanindaki tablolara karsilik gelir 
    public class Posts
    {
        [Required]
        public int UserId { get; set; }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Body { get; set; }
        
    }
}