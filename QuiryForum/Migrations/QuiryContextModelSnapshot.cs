﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuiryForum.Data;

namespace QuiryForum.Migrations
{
    [DbContext(typeof(QuiryContext))]
    partial class QuiryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<int>("Dislikes");

                    b.Property<int>("Likes");

                    b.Property<int?>("QuestionPostID");

                    b.Property<string>("UserId");

                    b.HasKey("PostID");

                    b.HasIndex("QuestionPostID");

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
                            ConcurrencyStamp = "fe6d9c4b-3065-4fb2-ae06-327563646250",
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
                            ConcurrencyStamp = "2589918b-2244-4332-850d-bf362654a016",
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
                            ConcurrencyStamp = "a095e5fb-a330-40e4-96f9-23b331ced504",
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
                            ConcurrencyStamp = "b18fd992-147d-489d-bfa9-dd17fbf7be20",
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
                            ConcurrencyStamp = "d584b366-1954-4d4a-b725-0907e4d81ce4",
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

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Travel"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Health"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Pets"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Entertainment"
                        },
                        new
                        {
                            CategoryID = 6,
                            CategoryName = "Food"
                        },
                        new
                        {
                            CategoryID = 7,
                            CategoryName = "Environment"
                        },
                        new
                        {
                            CategoryID = 8,
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            CategoryID = 9,
                            CategoryName = "Family & Relationships"
                        },
                        new
                        {
                            CategoryID = 10,
                            CategoryName = "Business"
                        });
                });

            modelBuilder.Entity("QuiryForum.Models.Question", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Content");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("UserId");

                    b.HasKey("PostID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            PostID = 1,
                            CategoryID = 1,
                            Title = "When U go to restaurants will they start charging u service charge & plus tip ?",
                            UserId = "1"
                        },
                        new
                        {
                            PostID = 2,
                            CategoryID = 3,
                            Title = "Why does McDonald's taste so bad?",
                            UserId = "2"
                        },
                        new
                        {
                            PostID = 3,
                            CategoryID = 4,
                            Content = "She gave me the wrong change",
                            Title = "Why couldn't she give me different change? was she dumb?",
                            UserId = "3"
                        },
                        new
                        {
                            PostID = 4,
                            CategoryID = 3,
                            Content = "They look the same",
                            Title = "What is the difference between subway and quiznos?",
                            UserId = "4"
                        },
                        new
                        {
                            PostID = 5,
                            CategoryID = 8,
                            Content = "Since it discriminates on the basis of race.",
                            Title = "Isn’t affirmative action a violation of the civil rights act?",
                            UserId = "5"
                        },
                        new
                        {
                            PostID = 6,
                            CategoryID = 9,
                            Content = "Seriously, if you want to get a job that pays above minimum wage, get some job training like medical assisting or dental assisting.",
                            Title = "Why do people want to raise the minimum wage?",
                            UserId = "1"
                        },
                        new
                        {
                            PostID = 7,
                            CategoryID = 1,
                            Content = "I need answers.",
                            Title = "Why havent we landed on the sun?",
                            UserId = "2"
                        },
                        new
                        {
                            PostID = 8,
                            CategoryID = 2,
                            Content = "What you find tastiest - fish, salmon, shrimps, shellfish, chicken, turkey, pork, bacon, sausage, beef???",
                            Title = "What is the tastiest meat according to you?",
                            UserId = "3"
                        },
                        new
                        {
                            PostID = 9,
                            CategoryID = 6,
                            Title = "If you vote Democrat, are you telling the world you are pro-communist?",
                            UserId = "4"
                        },
                        new
                        {
                            PostID = 10,
                            CategoryID = 7,
                            Title = "My kid's school want to take them on a field trip to a windmill farm, but what about windmill cancer?",
                            UserId = "5"
                        },
                        new
                        {
                            PostID = 11,
                            CategoryID = 9,
                            Content = "What is the most endangered island in the world?",
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
                    b.HasOne("QuiryForum.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionPostID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuiryForum.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("QuiryForum.Models.Question", b =>
                {
                    b.HasOne("QuiryForum.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("QuiryForum.Models.ApplicationUser", "User")
                        .WithMany("UserQuestions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
