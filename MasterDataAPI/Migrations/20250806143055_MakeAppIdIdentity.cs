using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterDataAPI.Migrations
{
    /// <inheritdoc />
    public partial class MakeAppIdIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appEnvironment",
                columns: table => new
                {
                    EnvironmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnvironmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResourceGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appEnvironment", x => x.EnvironmentId);
                });

            migrationBuilder.CreateTable(
                name: "appMaster",
                columns: table => new
                {
                    AppId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AppName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LOBCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appMaster", x => x.AppId);
                });

            migrationBuilder.CreateTable(
                name: "lOBMaster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOBCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LOBName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lOBMaster", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appEnvironment");

            migrationBuilder.DropTable(
                name: "appMaster");

            migrationBuilder.DropTable(
                name: "lOBMaster");
        }
    }
}
