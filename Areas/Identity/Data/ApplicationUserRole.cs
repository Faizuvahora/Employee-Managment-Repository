using Microsoft.AspNetCore.Identity;

namespace Github.Areas.Identity.Data
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public bool IsActive { get; set; }

        public int ModifiedById { get; set; }

        public int CreateByyId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
