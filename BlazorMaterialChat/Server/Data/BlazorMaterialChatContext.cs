using System;
using BlazorMaterialChat.Shared.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlazorMaterialChat.Server.Models
{
    public class BlazorMaterialChatContext : IdentityDbContext<ApplicationUser>
    {
        public BlazorMaterialChatContext(DbContextOptions<BlazorMaterialChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=BlazorMaterialChat");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Username).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        */
    }
}
