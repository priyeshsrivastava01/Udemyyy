﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.Models;

namespace project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("project.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Development",
                            CourseId = 0,
                            Description = "Development Courses"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Business",
                            CourseId = 0,
                            Description = "Courses related to Business"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "IT and Software",
                            CourseId = 0
                        });
                });

            modelBuilder.Entity("project.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("OrderDetailsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderDetailsId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("project.Models.Orderdetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CourseId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("project.Models.UserInfo", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("project.Models.courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCourseOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.HasIndex("CategoryId");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "Hypertext Markup Language is the standard markup language for documents designed to be displayed in a web browser. It can be assisted by technologies such as Cascading Style Sheets and scripting languages such as JavaScript",
                            Name = "HTML",
                            Price = 500m,
                            ShortDescription = "Fundamentals Of Html"
                        },
                        new
                        {
                            CourseId = 2,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "Cascading Style Sheets is a style sheet language used for describing the presentation of a document written in a markup language like HTML. CSS is a cornerstone technology of the World Wide Web.",
                            Name = "CSS",
                            Price = 700m,
                            ShortDescription = "Fundamentals Of CSS"
                        },
                        new
                        {
                            CourseId = 3,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "JavaScript, often abbreviated as JS, is an interpreted programming language that conforms to the ECMAScript specification. JavaScript is high-level, often just-in-time compiled, and multi-paradigm.",
                            Name = "JAVASCRIPT",
                            Price = 800m,
                            ShortDescription = "Fundamentals Of jAVASCRIPT"
                        },
                        new
                        {
                            CourseId = 4,
                            CategoryId = 2,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "Excel, Accounting, Financial Statement Analysis, Business Analysis, Financial Math, PowerPoint: Everything is Included!",
                            Name = "Complete Financial Analyst Course",
                            Price = 500m,
                            ShortDescription = "Complete Financial Analyst Course"
                        },
                        new
                        {
                            CourseId = 5,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "Learn Tableau 10 for Data Science step-by-step. Real-Life Data Analytics Exercises & Quizzes Included. Learn by doing!",
                            Name = "Tableau 10",
                            Price = 600m,
                            ShortDescription = "Hands-On Tableau Training For Data Science!"
                        },
                        new
                        {
                            CourseId = 6,
                            CategoryId = 2,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "The #1 Course to Land a Job in Investment Banking. IPOs, Bonds, M&A, Trading, LBOs, Valuation: Everything is included!",
                            Name = " Complete Investment Banking Course",
                            Price = 700m,
                            ShortDescription = " Complete Investment Banking Course"
                        },
                        new
                        {
                            CourseId = 7,
                            CategoryId = 3,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "Want to pass the AWS Solutions Architect - Associate Exam? Want to become Amazon Web Services Certified? Do this course!",
                            Name = "AWS Certified Solutions Architect",
                            Price = 500m,
                            ShortDescription = "AWS Certified Solutions Architect"
                        },
                        new
                        {
                            CourseId = 8,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "",
                            Name = " Ethical Hacking",
                            Price = 700m,
                            ShortDescription = ""
                        },
                        new
                        {
                            CourseId = 9,
                            CategoryId = 1,
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ",
                            IsCourseOfTheWeek = false,
                            LongDescription = "",
                            Name = "CSS",
                            Price = 700m,
                            ShortDescription = "Fundamentals Of CSS"
                        });
                });

            modelBuilder.Entity("project.Models.Order", b =>
                {
                    b.HasOne("project.Models.Orderdetails", "Orderdetails")
                        .WithMany("order")
                        .HasForeignKey("OrderDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project.Models.Orderdetails", b =>
                {
                    b.HasOne("project.Models.courses", "course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project.Models.courses", b =>
                {
                    b.HasOne("project.Models.Category", "Category")
                        .WithMany("Course")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
