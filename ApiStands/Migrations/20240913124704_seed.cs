using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiStands.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "Id", "Forma", "Foto", "Habilidade", "Name", "Parte", "Portador", "Status", "Tipo_Habilidade" },
                values: new object[] { 1, "Humanoide Natural", "https://static.jojowiki.com/images/thumb/c/c4/latest/20191015213758/Lovers_Infobox_Manga.png/400px-Lovers_Infobox_Manga.png", "Sincronização da dor, Clones de lixo orgânico, Cultivação de brotos", "Lovers", 3, "Steely Dan", "Morto", "Longo-Alcance" });

            migrationBuilder.InsertData(
                table: "Stands",
                columns: new[] { "Id", "Forma", "Foto", "Habilidade", "Name", "Parte", "Portador", "Status", "Tipo_Habilidade" },
                values: new object[] { 2, "Curto-Alcance", "https://static.jojowiki.com/images/thumb/2/20/latest/20191015213258/The_Hand_Infobox_Manga.png/400px-The_Hand_Infobox_Manga.png", "Eliminação", "The Hand", 4, "Okuyasu Nijimura", "Vivo", "Humanóide artificial" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stands",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
