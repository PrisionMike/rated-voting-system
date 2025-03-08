using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vote_counter.Migrations
{
    /// <inheritdoc />
    public partial class BasicSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CandidatesId",
                table: "Candidates",
                newName: "CandidateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CandidateId",
                table: "Candidates",
                newName: "CandidatesId");
        }
    }
}
