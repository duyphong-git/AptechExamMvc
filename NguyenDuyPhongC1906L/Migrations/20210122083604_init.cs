using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenDuyPhongC1906L.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNew = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserEdit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEdit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTypeModelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNew = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserEdit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEdit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_QuestionType_QuestionTypeModelId",
                        column: x => x.QuestionTypeModelId,
                        principalTable: "QuestionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionTypeModelId",
                table: "Question",
                column: "QuestionTypeModelId");

            migrationBuilder.InsertData("QuestionType", new string[] {"Name"}, new string[] {"Text"});
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Text Area" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Number" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Date" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Time" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Text" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Checkbox" });
            migrationBuilder.InsertData("QuestionType", new string[] { "Name" }, new string[] { "Radio button" });

            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is the ASP.NET Core?", "1" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What are the features provided by ASP.NET Core?", "2" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What are the advantages of ASP.NET Core over ASP.NET?", "1" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is Metapackages?", "1" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "Can ASP.NET Core application work with full .NET 4.x Framework?", "2" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is the startup class in ASP.NET core?", "3" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is the use of ConfigureServices method of startup class?", "1" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is the use of the Configure method of startup class?", "2" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is routing in ASP.NET Core?", "2" });
            migrationBuilder.InsertData("Question", new string[] { "Name", "QuestionTypeModelId" },
                    new string[] { "What is middleware?", "2" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "QuestionType");
        }
    }
}
