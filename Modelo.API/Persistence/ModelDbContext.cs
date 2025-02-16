﻿using Microsoft.EntityFrameworkCore;
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

                    e.HasMany(u=> u.OwnedPeople)
                    .WithOne(u=> u.User)
                    .HasForeignKey(u=> u.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
                    
                });

            builder
                .Entity<Person>(e=>
                {
                    e.HasKey(m => m.Id);

                    e.HasOne(m => m.User)
                    .WithMany(u => u.OwnedPeople)
                    .HasForeignKey(m => m.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
                });

            builder
                .Entity<ModelComment>(e=>
                {
                    e.HasKey(m => m.Id);

                    e.HasOne(m => m.Person)
                    .WithMany(m => m.Comments)
                    .HasForeignKey(m => m.PersonId)
                    .OnDelete(DeleteBehavior.Restrict);

                   
                });


            base.OnModelCreating(builder);        
        }
        
    }

}
