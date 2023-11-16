using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Dtos.AppUserDto
{
    public class AppUserListDto : BaseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }

        //Relational Properties
        public AppRole? AppRole { get; set; }
        public List<Blog> Blogs { get; set; }
    }

}
