using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inverter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    MaximumPower = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inverter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PvPanel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Power = table.Column<double>(nullable: false),
                    PanelLength = table.Column<float>(nullable: false),
                    PanelWidth = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PvPanel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PvSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    NumberOfPvPanels = table.Column<int>(nullable: false),
                    MountingAngle = table.Column<float>(nullable: false),
                    MountingDirection = table.Column<string>(nullable: false),
                    PvPanelId = table.Column<int>(nullable: false),
                    InverterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PvSystem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PvSystem_Inverter_InverterId",
                        column: x => x.InverterId,
                        principalTable: "Inverter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PvSystem_PvPanel_PvPanelId",
                        column: x => x.PvPanelId,
                        principalTable: "PvPanel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PvSystem_InverterId",
                table: "PvSystem",
                column: "InverterId");

            migrationBuilder.CreateIndex(
                name: "IX_PvSystem_PvPanelId",
                table: "PvSystem",
                column: "PvPanelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PvSystem");

            migrationBuilder.DropTable(
                name: "Inverter");

            migrationBuilder.DropTable(
                name: "PvPanel");
        }
    }
}
