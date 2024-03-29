﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuiryForum.Data;

namespace QuiryForum.Migrations
{
    [DbContext(typeof(QuiryContext))]
    [Migration("20191202060540_dateformats")]
    partial class dateformats
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QuiryForum.Models.AccountFollowers", b =>
                {
                    b.Property<string>("UserID");

                    b.Property<string>("FollowerID");

                    b.HasKey("UserID", "FollowerID");

                    b.HasIndex("FollowerID");

                    b.ToTable("AccountFollowers");
                });

            modelBuilder.Entity("QuiryForum.Models.Answer", b =>
                {
                    b.Property<int>("AnswerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("Dislikes");

                    b.Property<int>("Likes");

                    b.Property<string>("PostedBy");

                    b.Property<DateTime>("PostingDate");

                    b.Property<int>("QuestionID");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("AnswerID");

                    b.HasIndex("QuestionID");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("QuiryForum.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3bbf725f-2a2b-4ff9-8981-834a9b22930c",
                            DateOfBirth = new DateTime(1999, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "troiboi@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Troi",
                            IsPrivate = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "TroiBoi"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f4e33d4e-1c87-4211-9c3b-393db22e7062",
                            DateOfBirth = new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kanye@kanye.com",
                            EmailConfirmed = true,
                            FirstName = "Kanye",
                            IsPrivate = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "KanyeWest"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f1458ba4-4f26-413f-816f-f99e2e9ea0f3",
                            DateOfBirth = new DateTime(2015, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lazyboys@catsRule.com",
                            EmailConfirmed = true,
                            FirstName = "Taco",
                            IsPrivate = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "TacoRafa"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e1fe7c92-eac5-4255-94a1-772403ec1059",
                            DateOfBirth = new DateTime(1989, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "illy@bass.com",
                            EmailConfirmed = true,
                            FirstName = "Lenny",
                            IsPrivate = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Illenium"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1374f3e4-2d98-4f51-b34a-c773de7f7e4d",
                            DateOfBirth = new DateTime(1969, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "NightNight@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Mare",
                            IsPrivate = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Nightmare"
                        });
                });

            modelBuilder.Entity("QuiryForum.Models.ApplicationUserRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("QuiryForum.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Color");

                    b.Property<string>("Icon");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Travel",
                            Color = "#FF5733",
                            Icon = "fas fa-globe-americas"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Sports",
                            Color = "#00cc99",
                            Icon = "fas fa-volleyball-ball"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Health",
                            Color = "#cc0000",
                            Icon = "fas fa-briefcase-medical"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Pets",
                            Color = "#ac7339",
                            Icon = "fas fa-paw"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Entertainment",
                            Color = "#FFBD33",
                            Icon = "fas fa-star"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Food",
                            Color = "#9635F6",
                            Icon = "fas fa-utensils"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Environment",
                            Color = "#75FF33",
                            Icon = "fas fa-leaf"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Electronics",
                            Color = "#595B50",
                            Icon = "fas fa-robot"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Family & Relationships",
                            Color = "#900C3F",
                            Icon = "fas fa-heart"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Business",
                            Color = "#020202",
                            Icon = "fas fa-user-tie"
                        });
                });

            modelBuilder.Entity("QuiryForum.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("CategoryName");

                    b.Property<string>("Content");

                    b.Property<string>("PostedBy");

                    b.Property<DateTime>("PostingDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("QuestionID");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            CategoryID = 1,
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "When U go to restaurants will they start charging u service charge & plus tip ?",
                            UserId = "1"
                        },
                        new
                        {
                            QuestionID = 2,
                            CategoryID = 3,
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why does McDonald's taste so bad?",
                            UserId = "2"
                        },
                        new
                        {
                            QuestionID = 3,
                            CategoryID = 4,
                            Content = "She gave me the wrong change",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why couldn't she give me different change? was she dumb?",
                            UserId = "3"
                        },
                        new
                        {
                            QuestionID = 4,
                            CategoryID = 3,
                            Content = "They look the same",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "What is the difference between subway and quiznos?",
                            UserId = "4"
                        },
                        new
                        {
                            QuestionID = 5,
                            CategoryID = 8,
                            Content = "Since it discriminates on the basis of race.",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Isn’t affirmative action a violation of the civil rights act?",
                            UserId = "5"
                        },
                        new
                        {
                            QuestionID = 6,
                            CategoryID = 9,
                            Content = "Seriously, if you want to get a job that pays above minimum wage, get some job training like medical assisting or dental assisting.",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why do people want to raise the minimum wage?",
                            UserId = "1"
                        },
                        new
                        {
                            QuestionID = 7,
                            CategoryID = 1,
                            Content = "I need answers.",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Why havent we landed on the sun?",
                            UserId = "2"
                        },
                        new
                        {
                            QuestionID = 8,
                            CategoryID = 2,
                            Content = "What you find tastiest - fish, salmon, shrimps, shellfish, chicken, turkey, pork, bacon, sausage, beef???",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "What is the tastiest meat according to you?",
                            UserId = "3"
                        },
                        new
                        {
                            QuestionID = 9,
                            CategoryID = 6,
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "If you vote Democrat, are you telling the world you are pro-communist?",
                            UserId = "4"
                        },
                        new
                        {
                            QuestionID = 10,
                            CategoryID = 7,
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "My kid's school want to take them on a field trip to a windmill farm, but what about windmill cancer?",
                            UserId = "5"
                        },
                        new
                        {
                            QuestionID = 11,
                            CategoryID = 9,
                            Content = "What is the most endangered island in the world?",
                            PostingDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "What is the most endangered island in the world?",
                            UserId = "5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUserRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("QuiryForum.Models.AccountFollowers", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUser", "Follower")
                        .WithMany("Following")
                        .HasForeignKey("FollowerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuiryForum.Models.ApplicationUser", "User")
                        .WithMany("Followers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuiryForum.Models.Answer", b =>
                {
                    b.HasOne("QuiryForum.Models.Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("QuiryForum.Models.Question", b =>
                {
                    b.HasOne("QuiryForum.Models.ApplicationUser")
                        .WithMany("Questions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
