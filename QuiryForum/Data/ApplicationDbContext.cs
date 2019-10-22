using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuiryForum.Models;

namespace QuiryForum.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

      //  public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<AccountFollowers> Followers { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<AccountFollowers>()
               .HasKey(b => new { b.UserID, b.FollowerID });

            modelBuilder.Entity<AccountFollowers>()
                .HasOne(p => p.User)
                .WithMany(m => m.Followers)
                .HasForeignKey(p => p.UserID);


            modelBuilder.Entity<AccountFollowers>()
                .HasOne(p => p.Follower)
                .WithMany(m => m.Following)
                .HasForeignKey(p => p.FollowerID);
        }
    }
}
