using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiStands.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo_Habilidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Portador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parte = table.Column<int>(type: "int", nullable: false),
                    Habilidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stands", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stands");
        }
    }
}
