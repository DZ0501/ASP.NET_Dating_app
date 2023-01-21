using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Foundation.Areas.Identity.Data;

// Add profile data for application users by adding properties to the FoundationUser class
public class FoundationUser : IdentityUser
{

}

/*
public class FoundationRole: IdentityRole
{
    public string RoleName { get; set;}
}
*/