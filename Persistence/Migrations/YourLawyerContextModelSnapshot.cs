﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.DataContext;

namespace Persistence.Migrations
{
    [DbContext(typeof(YourLawyerContext))]
    partial class YourLawyerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11");

            modelBuilder.Entity("Domain.Models.AreaOfLaw", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AreaOfLawName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AreaOfLaws");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec39ff46-415f-4307-b611-82c50ad811ab"),
                            AreaOfLawName = "Banking and Finance Law"
                        },
                        new
                        {
                            Id = new Guid("1475b4dd-db74-4df5-b6a0-936480050e60"),
                            AreaOfLawName = "Civil Litigation"
                        },
                        new
                        {
                            Id = new Guid("e2eaf09b-348b-4b81-a39f-da296f0ba1d0"),
                            AreaOfLawName = "Dispute Resolution"
                        },
                        new
                        {
                            Id = new Guid("6a49f3a1-cf42-48de-84b2-cbd68e9095c7"),
                            AreaOfLawName = "Commercial Law"
                        },
                        new
                        {
                            Id = new Guid("03710086-ab1e-48c7-893b-347ca496abf8"),
                            AreaOfLawName = "Construction Law"
                        },
                        new
                        {
                            Id = new Guid("f7b50d33-51c1-4225-b9b2-6276dfe2424f"),
                            AreaOfLawName = "Corporate Law"
                        },
                        new
                        {
                            Id = new Guid("60ade23c-05fb-4596-95db-958e90d3b6f3"),
                            AreaOfLawName = "Criminal Law"
                        },
                        new
                        {
                            Id = new Guid("165e47eb-5209-4e5a-9069-8953a24ae65f"),
                            AreaOfLawName = "Family Law"
                        });
                });

            modelBuilder.Entity("Domain.Models.Division", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a70fa025-db49-4f14-8559-a32a3f471314"),
                            Name = "Dhaka"
                        },
                        new
                        {
                            Id = new Guid("805fa95e-89ae-4571-b1f9-5561ff3f61c3"),
                            Name = "Chittagong"
                        },
                        new
                        {
                            Id = new Guid("c5c3f58b-41c5-4916-bee6-e433b1a0bea1"),
                            Name = "Rajshahi"
                        },
                        new
                        {
                            Id = new Guid("7c3d6e53-dfa5-4f3e-8914-10505a5d18ad"),
                            Name = "Khulna"
                        },
                        new
                        {
                            Id = new Guid("0a1f1f93-83bb-41a2-88d3-0aa3e0f9ef83"),
                            Name = "Sylhet"
                        },
                        new
                        {
                            Id = new Guid("163bf884-58be-47f9-9df9-2cec05585fd5"),
                            Name = "Mymensingh"
                        },
                        new
                        {
                            Id = new Guid("2234854c-282c-4f68-aac5-d1a59146b6a8"),
                            Name = "Barisal"
                        },
                        new
                        {
                            Id = new Guid("b39d7440-cf97-4536-96e7-d21c9551549e"),
                            Name = "Rangpur "
                        });
                });

            modelBuilder.Entity("Domain.Models.Lawyer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DivisionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LawyerRank")
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileImageLocation")
                        .HasColumnType("TEXT");

                    b.Property<int>("WorkingExperience")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Lawyers");
                });

            modelBuilder.Entity("Domain.Models.LawyerAndAreaOfLaw", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AreaOfLawId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LawyerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AreaOfLawId");

                    b.HasIndex("LawyerId");

                    b.ToTable("LawyerAndAreaOfLaws");
                });

            modelBuilder.Entity("Domain.Models.LawyerEducationalBG", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Degree")
                        .HasColumnType("TEXT");

                    b.Property<string>("Institute")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("LawyerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassingYear")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LawyerId");

                    b.ToTable("LawyerEducationalBGs");
                });

            modelBuilder.Entity("Domain.Models.Messages.QueryFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("QueryFile");
                });

            modelBuilder.Entity("Domain.Models.Messages.QueryText", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SenderId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("QueryText");
                });

            modelBuilder.Entity("Domain.Models.User.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Models.Lawyer", b =>
                {
                    b.HasOne("Domain.Models.Division", "Division")
                        .WithMany("Lawyers")
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.LawyerAndAreaOfLaw", b =>
                {
                    b.HasOne("Domain.Models.AreaOfLaw", "AreaOfLaw")
                        .WithMany("LawyersUnderThisAreaOfLaw")
                        .HasForeignKey("AreaOfLawId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.Lawyer", "Lawyer")
                        .WithMany("LawyersAreaOfLaws")
                        .HasForeignKey("LawyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.LawyerEducationalBG", b =>
                {
                    b.HasOne("Domain.Models.Lawyer", "Lawyer")
                        .WithMany("LawyerEducationalBGs")
                        .HasForeignKey("LawyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Messages.QueryFile", b =>
                {
                    b.HasOne("Domain.Models.User.AppUser", "Receiver")
                        .WithMany("ReceivedQueryFiles")
                        .HasForeignKey("ReceiverId");

                    b.HasOne("Domain.Models.User.AppUser", "Sender")
                        .WithMany("SentQueryFiles")
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("Domain.Models.Messages.QueryText", b =>
                {
                    b.HasOne("Domain.Models.User.AppUser", "Receiver")
                        .WithMany("ReceivedQueryTexts")
                        .HasForeignKey("ReceiverId");

                    b.HasOne("Domain.Models.User.AppUser", "Sender")
                        .WithMany("SentQueryTexts")
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Models.User.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
