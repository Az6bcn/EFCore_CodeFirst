using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.IdentityCore
{
    /* Inherits from IdentityUser so we can add our own addition
    fields to the already defined user's info in IdebtityUser's class */
    public class ApplicationUser:IdentityUser
    {
        // add my addition user information that are not in Identity user
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
