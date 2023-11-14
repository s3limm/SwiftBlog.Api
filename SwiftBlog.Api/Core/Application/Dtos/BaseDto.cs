using SwiftBlog.Api.Core.Application.Enums;

namespace SwiftBlog.Api.Core.Application.Dtos
{
    public class BaseDto
    {
        public BaseDto()
        {
            Status = StatusType.Inserted;
            CreatedDate = DateTime.Now;
        }

        public StatusType Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
