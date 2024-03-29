﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuiryForum.Models;

namespace QuiryForum.Data
{

    public class QuiryContext : IdentityDbContext<ApplicationUser, ApplicationUserRole, string>
    {
        public QuiryContext(DbContextOptions<QuiryContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        //public DbSet<ApplicationUser> MyUsers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Import seed data 
            SeedCategories(modelBuilder);
            SeedUserAccounts(modelBuilder);
            SeedQuestions(modelBuilder);

            // Generate many-to-many relationships in the AccountFollowers table
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

            modelBuilder.Entity<Question>()
                .Property(p => p.QuestionID)
                .ValueGeneratedOnAdd();

            //Each Question can have many answers
            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne()
                .HasForeignKey(a => a.QuestionID);
            /*
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.UserQuestions)
                .WithOne(a => a.User);*/

            modelBuilder.Entity<ApplicationUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne()
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne()
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne()
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();

                b.HasMany(e => e.Answers)
                    .WithOne()
                    .HasForeignKey(a => a.UserId)
                    .IsRequired();

                // Each User can have many questions
                b.HasMany(e => e.Questions)
                    .WithOne()
                    .HasForeignKey(q => q.UserId)
                    .IsRequired();

                // Each User can have many answers
                
            });
        }

        private void SeedQuestions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                         new Question { QuestionID = 1, UserId = "1", CategoryID = 1, Title = "When U go to restaurants will they start charging u service charge & plus tip ?" },
                         new Question { QuestionID = 2, UserId = "2", CategoryID = 3, Title = "Why does McDonald's taste so bad?" },
                         new Question { QuestionID = 3, UserId = "3", CategoryID = 4, Title = "Why couldn't she give me different change? was she dumb?", Content = "She gave me the wrong change" },
                         new Question { QuestionID = 4, UserId = "4", CategoryID = 3, Title = "What is the difference between subway and quiznos?", Content = "They look the same" },
                         new Question { QuestionID = 5, UserId = "5", CategoryID = 8, Title = "Isn’t affirmative action a violation of the civil rights act?", Content = "Since it discriminates on the basis of race." },
                         new Question { QuestionID = 6, UserId = "1", CategoryID = 9, Title = "Why do people want to raise the minimum wage?", Content = "Seriously, if you want to get a job that pays above minimum wage, get some job training like medical assisting or dental assisting." },
                         new Question { QuestionID = 7, UserId = "2", CategoryID = 1, Title = "Why havent we landed on the sun?", Content = "I need answers." },
                         new Question { QuestionID = 8, UserId = "3", CategoryID = 2, Title = "What is the tastiest meat according to you?", Content = "What you find tastiest - fish, salmon, shrimps, shellfish, chicken, turkey, pork, bacon, sausage, beef???" },
                         new Question { QuestionID = 9, UserId = "4", CategoryID = 6, Title = "If you vote Democrat, are you telling the world you are pro-communist?" },
                         new Question { QuestionID = 10, UserId = "5", CategoryID = 7, Title = "My kid's school want to take them on a field trip to a windmill farm, but what about windmill cancer?" },
                         new Question { QuestionID = 11, UserId = "5", CategoryID = 9, Title = "What is the most endangered island in the world?", Content = "What is the most endangered island in the world?" });
        } 

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                            new { CategoryID = 1, CategoryName = "Travel" , Icon = "fas fa-globe-americas", Color = "#FF5733" },    //orange
                            new { CategoryID = 2, CategoryName = "Sports", Icon = "fas fa-volleyball-ball", Color = "#00cc99" },
                            new { CategoryID = 3, CategoryName = "Health", Icon = "fas fa-briefcase-medical", Color = "#cc0000" }, //red
                            new { CategoryID = 4, CategoryName = "Pets", Icon = "fas fa-paw", Color = "#ac7339" },                 //brown
                            new { CategoryID = 5, CategoryName = "Entertainment", Icon = "fas fa-star", Color = "#FFBD33" },
                            new { CategoryID = 6, CategoryName = "Food", Icon = "fas fa-utensils", Color = "#9635F6" },    //purple
                            new { CategoryID = 7, CategoryName = "Environment", Icon = "fas fa-leaf", Color = "#75FF33" },    //green
                            new { CategoryID = 8, CategoryName = "Electronics", Icon = "fas fa-robot", Color = "#595B50" },   //grey
                            new { CategoryID = 9, CategoryName = "Family & Relationships", Icon = "fas fa-heart", Color = "#900C3F" }, //maroon
                            new { CategoryID = 10, CategoryName = "Business", Icon = "fas fa-user-tie", Color = "#020202" }            //black
                            );
        }

        private static void SeedUserAccounts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
                            new ApplicationUser
                            {
                                Id = "1",
                                EmailConfirmed = true,
                                UserName = "TroiBoi",
                                Email = "troiboi@gmail.com",
                                FirstName = "Troi",
                                DateOfBirth = Convert.ToDateTime("09/09/1999")
                            },
                            new ApplicationUser
                            {
                                Id = "2",
                                EmailConfirmed = true,
                                UserName = "KanyeWest",
                                Email = "kanye@kanye.com",
                                FirstName = "Kanye",
                                DateOfBirth = Convert.ToDateTime("07/07/1977")
                            },
                            new ApplicationUser
                            {
                                Id = "3",
                                EmailConfirmed = true,
                                UserName = "TacoRafa",
                                Email = "lazyboys@catsRule.com",
                                FirstName = "Taco",
                                DateOfBirth = Convert.ToDateTime("02/03/2015")
                            },
                            new ApplicationUser
                            {
                                Id = "4",
                                EmailConfirmed = true,
                                UserName = "Illenium",
                                Email = "illy@bass.com",
                                FirstName = "Lenny",
                                DateOfBirth = Convert.ToDateTime("02/02/1989")
                            },
                            new ApplicationUser
                            {
                                Id = "5",
                                EmailConfirmed = true,
                                UserName = "Nightmare",
                                Email = "NightNight@gmail.com",
                                FirstName = "Mare",
                                DateOfBirth = Convert.ToDateTime("03/03/1969")
                            });
        }
    }
}
