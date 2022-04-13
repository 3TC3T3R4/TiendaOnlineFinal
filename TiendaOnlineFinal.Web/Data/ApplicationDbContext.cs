using Microsoft.EntityFrameworkCore;
using TiendaOnlineFinal.Web.Models;

namespace TiendaOnlineFinal.Web.Data
{
    public class ApplicationDbContext:DbContext {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Country> Contries{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>()
            .HasIndex(t => t.Name)
            .IsUnique();
        
        
        }





    }



    }
