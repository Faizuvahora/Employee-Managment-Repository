using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Github.Areas.Identity.Data
{
    public class ApplicationRole : IdentityRole<int>
    {
        public bool IsActive { get; set; }

        public int ModifiedById { get; set; }

        public int CreateByyId { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
