using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobAppManager.Migrations
{
    /// <inheritdoc />
    public partial class RecruiterTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recruiters_Recruiters_RecruiterId",
                table: "Recruiters");

            migrationBuilder.DropIndex(
                name: "IX_Recruiters_RecruiterId",
                table: "Recruiters");

            migrationBuilder.DropColumn(
                name: "RecruiterId",
                table: "Recruiters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecruiterId",
                table: "Recruiters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recruiters_RecruiterId",
                table: "Recruiters",
                column: "RecruiterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recruiters_Recruiters_RecruiterId",
                table: "Recruiters",
                column: "RecruiterId",
                principalTable: "Recruiters",
                principalColumn: "Id");
        }
    }
}
