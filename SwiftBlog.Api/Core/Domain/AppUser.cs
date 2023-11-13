namespace SwiftBlog.Api.Core.Domain
{
    public class AppUser:BaseEntity
    {
        public int Id { get; set; }
        public string UserName{ get; set; }
        public string Password{ get; set; }
        public int AppRoleId { get; set; }

        //Relational Properties
        public AppRole? AppRole  { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
