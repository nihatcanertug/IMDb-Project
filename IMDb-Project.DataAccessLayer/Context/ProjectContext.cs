using IMDb_Project.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()// We write connection in the Constructer method.
        {
            Database.Connection.ConnectionString = @"Database=IMDbProjectDb;uid=nihatcan;pwd=123;";
        }

        // It integrates the features we create with DbSet as a table in the database.
        public DbSet<Genre> Genres { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
