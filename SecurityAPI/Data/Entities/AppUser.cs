using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SecurityAPI.Data.Entities
{
    public class AppUser : IdentityUser {

        public string FullName { get; set; }
        public DateTime DataCreated { get; set; }
        public DateTime DataModified { get; set; }

    }
    
}
