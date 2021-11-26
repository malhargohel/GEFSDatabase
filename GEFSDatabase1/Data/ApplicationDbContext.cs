using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GEFSDatabase1.Models;

namespace GEFSDatabase1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GEFSDatabase1.Models.Category> Category { get; set; }
        public DbSet<GEFSDatabase1.Models.Suppliers> Suppliers { get; set; }
        public DbSet<GEFSDatabase1.Models.Products> Products { get; set; }
    }
}
