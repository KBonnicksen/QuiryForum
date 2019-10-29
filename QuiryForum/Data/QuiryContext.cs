using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuiryForum.Models;

namespace QuiryForum.Data
{
    public class QuiryContext : IdentityDbContext<ApplicationUser>
    {
        public QuiryContext(DbContextOptions<QuiryContext> options)
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

            modelBuilder.Entity<Category>().HasData(
                new { CategoryID = 1, CategoryName = "Travel" },
                new { CategoryID = 2, CategoryName = "Sports" },
                new { CategoryID = 3, CategoryName = "Health" },
                new { CategoryID = 4, CategoryName = "Pets" },
                new { CategoryID = 5, CategoryName = "Home & Garden" },
                new { CategoryID = 6, CategoryName = "Dining Out" },
                new { CategoryID = 7, CategoryName = "Cooking" },
                new { CategoryID = 8, CategoryName = "Computers & Electronics" },
                new { CategoryID = 9, CategoryName = "Family & Relationships" }
                );

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
