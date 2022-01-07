﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackInternship.Data.Entities;

namespace StackInternship.Data.Migrations
{
    [DbContext(typeof(StackInternshipDbContext))]
    partial class StackInternshipDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("datetime2");

                    b.Property<int>("DownVote")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpVote")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentId = 1,
                            DateOfPublication = new DateTime(2021, 12, 25, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            Text = "Hvala!",
                            UpVote = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            CommentId = 5,
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 10, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            Text = "Hvala!",
                            UpVote = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnswerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("datetime2");

                    b.Property<int>("DownVote")
                        .HasColumnType("int");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpVote")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("ResourceId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfPublication = new DateTime(2021, 12, 25, 10, 2, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 1,
                            Text = "Hvala, takoder!",
                            UpVote = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfPublication = new DateTime(2021, 12, 25, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 1,
                            Text = "Hvala, takoder:)",
                            UpVote = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfPublication = new DateTime(2021, 12, 25, 10, 5, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 1,
                            Text = "Hvala, takoder!<3",
                            UpVote = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 2,
                            Text = "Sretna novaaa!",
                            UpVote = 1,
                            UserId = 6
                        },
                        new
                        {
                            Id = 5,
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 2, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 2,
                            Text = "Sretna nova svima!",
                            UpVote = 1,
                            UserId = 7
                        },
                        new
                        {
                            Id = 6,
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 30, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 2,
                            Text = "Sretna nova!",
                            UpVote = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 7,
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 4, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            ResourceId = 2,
                            Text = "Sretna vam nova ljudi!",
                            UpVote = 1,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("datetime2");

                    b.Property<int>("DownVote")
                        .HasColumnType("int");

                    b.Property<int>("UpVote")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 4,
                            Content = "Sretan Vam Bozic!",
                            DateOfPublication = new DateTime(2021, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            UpVote = 6,
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            Area = 4,
                            Content = "Sretna Vam Nova Godina!",
                            DateOfPublication = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DownVote = 0,
                            UpVote = 6,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReputationPoints")
                        .HasColumnType("int");

                    b.Property<int>("ReputationalPrivilege")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = 0,
                            Area = 0,
                            Password = "Harry123",
                            ReputationPoints = 5000,
                            ReputationalPrivilege = 0,
                            UserName = "Harry",
                            UserRole = 0
                        },
                        new
                        {
                            Id = 2,
                            AccountStatus = 0,
                            Area = 1,
                            Password = "Luna123",
                            ReputationPoints = 5000,
                            ReputationalPrivilege = 0,
                            UserName = "Luna",
                            UserRole = 0
                        },
                        new
                        {
                            Id = 3,
                            AccountStatus = 0,
                            Area = 0,
                            Password = "Hermione123",
                            ReputationPoints = 100000,
                            ReputationalPrivilege = 0,
                            UserName = "Hermione",
                            UserRole = 0
                        },
                        new
                        {
                            Id = 4,
                            AccountStatus = 0,
                            Area = 3,
                            Password = "Ron123",
                            ReputationPoints = 1000,
                            ReputationalPrivilege = 0,
                            UserName = "Ron",
                            UserRole = 0
                        },
                        new
                        {
                            Id = 5,
                            AccountStatus = 0,
                            Area = 2,
                            Password = "Draco123",
                            ReputationPoints = 5000,
                            ReputationalPrivilege = 0,
                            UserName = "Draco",
                            UserRole = 0
                        },
                        new
                        {
                            Id = 6,
                            AccountStatus = 0,
                            Area = 0,
                            Password = "Fred123",
                            ReputationPoints = 100,
                            ReputationalPrivilege = 1,
                            UserName = "Fred",
                            UserRole = 1
                        },
                        new
                        {
                            Id = 7,
                            AccountStatus = 0,
                            Area = 0,
                            Password = "George123",
                            ReputationPoints = 100,
                            ReputationalPrivilege = 1,
                            UserName = "George",
                            UserRole = 1
                        });
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Answer", b =>
                {
                    b.HasOne("StackInternship.Data.Entities.Models.Comment", "Comment")
                        .WithMany("Answers")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StackInternship.Data.Entities.Models.User", "User")
                        .WithMany("Answers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Comment", b =>
                {
                    b.HasOne("StackInternship.Data.Entities.Models.Answer", null)
                        .WithMany("Comments")
                        .HasForeignKey("AnswerId");

                    b.HasOne("StackInternship.Data.Entities.Models.Resource", "Resource")
                        .WithMany("Comments")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StackInternship.Data.Entities.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Resource");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Resource", b =>
                {
                    b.HasOne("StackInternship.Data.Entities.Models.User", "User")
                        .WithMany("Resources")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Answer", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Comment", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.Resource", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("StackInternship.Data.Entities.Models.User", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Comments");

                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
