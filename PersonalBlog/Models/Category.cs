namespace PersonalBlog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<Post> posts { get; set; } 
            = new HashSet<Post>();
    }
}
