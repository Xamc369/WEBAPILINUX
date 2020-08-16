using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBAPI.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductosItems",
                columns: table => new
                {
                    IdProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodProducto = table.Column<string>(nullable: false),
                    NomProducto = table.Column<string>(nullable: true),
                    PreComProducto = table.Column<decimal>(nullable: false),
                    PreVenProducto = table.Column<decimal>(nullable: false),
                    ImgProducto = table.Column<string>(nullable: true),
                    DesProducto = table.Column<string>(nullable: true),
                    StkMaxProducto = table.Column<int>(nullable: false),
                    StkMinProducto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosItems", x => x.IdProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosItems");
        }
    }
}
