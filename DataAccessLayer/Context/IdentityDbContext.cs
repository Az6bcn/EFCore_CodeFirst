using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.IdentityCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    
    public class IdentityDbContext: IdentityDbContext<ApplicationUser>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {
                
        }
        /*  DbModelBuilderto Cutomise the ASP.NET Identity model and override defaults if needed 
            e.g: rename ASP.NET Identity Tables, Columns etc 
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Prevent Error: The entity type 'IdentityUserLogin<string>' requires a primary key to be defined.*/
            base.OnModelCreating(modelBuilder); 
        }

    }
}
