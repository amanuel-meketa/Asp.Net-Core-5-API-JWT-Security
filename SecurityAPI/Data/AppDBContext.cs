using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecurityAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityAPI.Data
{
    public class AppDBContext:IdentityDbContext<AppUser,IdentityRole, string> 
    {
        public AppDBContext(DbContextOptions Options) : base(Options)
        {     
        }


    }
}
