using Microsoft.EntityFrameworkCore;
using Modelo.Core.Entities;

namespace Modelo.API.Persistence
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) :base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ModelComment> ModelComments { get; set; }


        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<User>(e=>
                {
                    e.HasKey(u=> u.Id);
                    
                });

            builder
                .Entity<Person>(e=>
                {
                    e.HasKey(m => m.Id);
                });

            builder
                .Entity<ModelComment>(e=>
                {
                    e.HasKey(m => m.Id);

                   
                });


            base.OnModelCreating(builder);        
        }
        
    }

}
