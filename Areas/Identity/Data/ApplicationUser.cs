using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Github.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser<int>
{
    public string Fname { get; set; }
    public string Lname { get; set; }
    public string Address { get; set; }
    public DateTime Dob { get; set; }
}

