using Microsoft.AspNetCore.Identity;

namespace SwiftBlog.Api.Core.Domain
{
    public class Blog: BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int AppUserId { get; set; }

        //Relational Properties
        public AppUser AppUser { get; set; }
        public Category Category { get; set; }
    }
}
