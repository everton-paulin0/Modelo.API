﻿using Microsoft.EntityFrameworkCore;
using Modelo.Core.Entities;

namespace Modelo.API.Persistence
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext(DbContextOptions<ModelDbContext> options) :base(options)
        {
            
        }

        public DbSet<Model> Models { get; set; }
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
                .Entity<Model>(e=>
                {
                    e.HasKey(m=> m.Id);

                    e.HasOne(m => m.Users);
                    

                });

            builder
                .Entity<ModelComment>(e=>
                {
                    e.HasKey(m => m.Id);

                    e.HasOne(m=> m.Model)
                    .WithMany(m=> m.Comment)
                    .HasForeignKey(m=> m.IdModel)
                    .OnDelete(DeleteBehavior.Restrict);

                });


            base.OnModelCreating(builder);
        }
    }
}
