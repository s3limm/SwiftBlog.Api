using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Dtos.CategoryDto
{
    public class CategoryListDto:BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }

        //Relational Properties
        public List<Blog> Blogs { get; set; }
    }
}
