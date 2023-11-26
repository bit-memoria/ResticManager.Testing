using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResticManager.Testing.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    SnapshotCount = table.Column<int>(type: "INTEGER", nullable: false),
                    KeyCount = table.Column<int>(type: "INTEGER", nullable: false),
                    DeduplicationRatio = table.Column<double>(type: "REAL", nullable: false),
                    TotalFileCount = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalBlobCount = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalOriginSize = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalUncompressedSize = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalCompressedSize = table.Column<long>(type: "INTEGER", nullable: false),
                    CompressionRatio = table.Column<double>(type: "REAL", nullable: false),
                    CompressionSpaceSaving = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResticSnapshots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Guid = table.Column<string>(type: "TEXT", nullable: false),
                    ShortGuid = table.Column<string>(type: "TEXT", nullable: false),
                    TotalFileCount = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalBlobCount = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalOriginSize = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalUncompressedSize = table.Column<long>(type: "INTEGER", nullable: false),
                    TotalCompressedSize = table.Column<long>(type: "INTEGER", nullable: false),
                    CompressionRatio = table.Column<double>(type: "REAL", nullable: false),
                    CompressionSpaceSaving = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResticSnapshots", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "ResticSnapshots");
        }
    }
}
