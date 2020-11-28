﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiz.Models;

namespace Quiz.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Quiz.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Quiz.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolId");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Quiz.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId");

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<string>("Name");

                    b.Property<int?>("SectionId");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SectionId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Quiz.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrectAnswer");

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<string>("Name");

                    b.Property<int?>("TestId");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Quiz.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnswerId");

                    b.Property<int?>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Quiz.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Quiz.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId");

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Quiz.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOnDateTime");

                    b.Property<int?>("LessonId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedOnDateTime");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("Quiz.Models.Answer", b =>
                {
                    b.HasOne("Quiz.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Quiz.Models.Class", b =>
                {
                    b.HasOne("Quiz.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId");
                });

            modelBuilder.Entity("Quiz.Models.Lesson", b =>
                {
                    b.HasOne("Quiz.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Quiz.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("Quiz.Models.Question", b =>
                {
                    b.HasOne("Quiz.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId");
                });

            modelBuilder.Entity("Quiz.Models.Result", b =>
                {
                    b.HasOne("Quiz.Models.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId");

                    b.HasOne("Quiz.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Quiz.Models.Section", b =>
                {
                    b.HasOne("Quiz.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("Quiz.Models.Test", b =>
                {
                    b.HasOne("Quiz.Models.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId");
                });
#pragma warning restore 612, 618
        }
    }
}
