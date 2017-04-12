using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageItLinux.Database
{
    public class ManageItContext : DbContext
    {
        public ManageItContext()
        {
        }

        public ManageItContext(DbContextOptions<ManageItContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //the same connection string exists in Startup class
            var connection = @"Server=(localdb)\MSSQLLocalDB;Database=manage.it_linux;";
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Board> Boards { get; set; }
    }
}
