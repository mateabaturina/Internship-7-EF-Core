// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StackInternship.Data.Entities;

namespace StackInternship.Data.Migrations
{
    [DbContext(typeof(StackInternshipDbContext))]
    [Migration("20220107055209_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("ResourceId")
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
                        .OnDelete(DeleteBehavior.NoAction);

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
