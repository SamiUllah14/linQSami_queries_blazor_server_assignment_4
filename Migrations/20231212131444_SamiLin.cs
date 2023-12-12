﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace linQSami_queries_blazor_server_assignment_4.Migrations
{
    /// <inheritdoc />
    public partial class SamiLin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deptid = table.Column<int>(type: "int", nullable: false),
                    Standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Fid);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Sid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Standing = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Cid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Fid = table.Column<int>(type: "int", nullable: false),
                    FacultyFid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Cid);
                    table.ForeignKey(
                        name: "FK_Classes_Faculties_FacultyFid",
                        column: x => x.FacultyFid,
                        principalTable: "Faculties",
                        principalColumn: "Fid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<int>(type: "int", nullable: false),
                    ClassCid = table.Column<int>(type: "int", nullable: false),
                    Sid = table.Column<int>(type: "int", nullable: false),
                    StudentSid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enrollments_Classes_ClassCid",
                        column: x => x.ClassCid,
                        principalTable: "Classes",
                        principalColumn: "Cid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentSid",
                        column: x => x.StudentSid,
                        principalTable: "Students",
                        principalColumn: "Sid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_FacultyFid",
                table: "Classes",
                column: "FacultyFid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ClassCid",
                table: "Enrollments",
                column: "ClassCid");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentSid",
                table: "Enrollments",
                column: "StudentSid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
