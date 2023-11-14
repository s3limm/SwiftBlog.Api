using SwiftBlog.Api.Core.Application.Enums;

namespace SwiftBlog.Api.Core.Domain
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Status = StatusType.Inserted;
            CreatedDate = DateTime.Now;
        }

        public StatusType Status { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
