using Microsoft.EntityFrameworkCore.Migrations;

namespace Site_Pessoal.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Linguas",
                columns: table => new
                {
                    LinguasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lingua = table.Column<string>(maxLength: 100, nullable: false),
                    Coral = table.Column<string>(maxLength: 2, nullable: false),
                    Leitura = table.Column<string>(maxLength: 2, nullable: false),
                    Poral = table.Column<string>(maxLength: 2, nullable: false),
                    Ioral = table.Column<string>(maxLength: 2, nullable: false),
                    Escrita = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linguas", x => x.LinguasId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Linguas");
        }
    }
}
