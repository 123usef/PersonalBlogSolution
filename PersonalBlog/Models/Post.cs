using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalBlog.Models
{
    /*
        for setting constraints 
        1-by Convention (Id)
        2-Data Annotation [Key]
        3- Fulent Api
     
     */
    public class Post
    {
        
        public int Id { get; set; }
        public string Title { get; set; }

        public string Content { get; set; }
        
        public  string imageUrl { get; set; }
        public int LikeCount { get; set; } = 0;
        public int DisLikeCount { get; set; } = 0;

        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(category))]
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
