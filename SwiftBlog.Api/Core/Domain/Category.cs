namespace SwiftBlog.Api.Core.Domain
{
    public class Category:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }

        //Relational Properties
        public List<Blog> Blogs{ get; set; }
    }
}
