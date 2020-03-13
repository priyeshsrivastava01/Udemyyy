using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    IsCourseOfTheWeek = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false),
                    OrderDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_OrderDetails_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "OrderDetails",
                        principalColumn: "OrderDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 1, "Development", 0, "Development Courses" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 2, "Business", 0, "Courses related to Business" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CourseId", "Description" },
                values: new object[] { 3, "IT and Software", 0, null });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "CourseId", "CategoryId", "ImageUrl", "IsCourseOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "Hypertext Markup Language is the standard markup language for documents designed to be displayed in a web browser. It can be assisted by technologies such as Cascading Style Sheets and scripting languages such as JavaScript", "HTML", 500m, "Fundamentals Of Html" },
                    { 2, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "Cascading Style Sheets is a style sheet language used for describing the presentation of a document written in a markup language like HTML. CSS is a cornerstone technology of the World Wide Web.", "CSS", 700m, "Fundamentals Of CSS" },
                    { 3, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "JavaScript, often abbreviated as JS, is an interpreted programming language that conforms to the ECMAScript specification. JavaScript is high-level, often just-in-time compiled, and multi-paradigm.", "JAVASCRIPT", 800m, "Fundamentals Of jAVASCRIPT" },
                    { 5, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "Learn Tableau 10 for Data Science step-by-step. Real-Life Data Analytics Exercises & Quizzes Included. Learn by doing!", "Tableau 10", 600m, "Hands-On Tableau Training For Data Science!" },
                    { 8, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "", " Ethical Hacking", 700m, "" },
                    { 9, 1, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "", "CSS", 700m, "Fundamentals Of CSS" },
                    { 4, 2, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "Excel, Accounting, Financial Statement Analysis, Business Analysis, Financial Math, PowerPoint: Everything is Included!", "Complete Financial Analyst Course", 500m, "Complete Financial Analyst Course" },
                    { 6, 2, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "The #1 Course to Land a Job in Investment Banking. IPOs, Bonds, M&A, Trading, LBOs, Valuation: Everything is included!", " Complete Investment Banking Course", 700m, " Complete Investment Banking Course" },
                    { 7, 3, "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcdn2.f-cdn.com%2Fcontestentries%2F1162950%2F24458736%2F59eb2e742db12_thumb900.jpg&imgrefurl=https%3A%2F%2Fwww.freelancer.com.jm%2Fcontest%2FCreate-a-Course-Thumbnail-1162950-byentry-17033112.html&tbnid=L-4SZz2fEV8QSM&vet=12ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ..i&docid=pnGU3F0-FV17zM&w=503&h=309&q=html%20course%20thumbnail&ved=2ahUKEwjY4YfLyd_nAhX1XHwKHfKJCZ8QMygBegUIARDPAQ", false, "Want to pass the AWS Solutions Architect - Associate Exam? Want to become Amazon Web Services Certified? Do this course!", "AWS Certified Solutions Architect", 500m, "AWS Certified Solutions Architect" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_CategoryId",
                table: "courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CourseId",
                table: "OrderDetails",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderDetailsId",
                table: "Orders",
                column: "OrderDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
