using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiStands.Models;

namespace ApiStands.Data
{
    public class DBStandsContext : DbContext
    {
        public DBStandsContext (DbContextOptions<DBStandsContext> options)
            : base(options)
        {
        }

        public DbSet<ApiStands.Models.Stand> Stand { get; set; } = default!;
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stand>().HasData(
                new Stand {
                    Id = 1,
                    Name = "Lovers",
                    Tipo_Habilidade = "Longo-Alcance",
                    Forma = "Humanoide Natural",
                    Portador = "Steely Dan",
                    Parte = 3,
                    Habilidade = "Sincronização da dor, Clones de lixo orgânico, Cultivação de brotos",
                    Foto = "https://static.jojowiki.com/images/thumb/c/c4/latest/20191015213758/Lovers_Infobox_Manga.png/400px-Lovers_Infobox_Manga.png",
                    Status = "Morto"
                },

                new Stand
                {
                    Id = 2,
                    Name = "The Hand",
                    Tipo_Habilidade = "Humanóide artificial",
                    Forma = "Curto-Alcance",
                    Portador = "Okuyasu Nijimura",
                    Parte = 4,
                    Habilidade = "Eliminação",
                    Foto = "https://static.jojowiki.com/images/thumb/2/20/latest/20191015213258/The_Hand_Infobox_Manga.png/400px-The_Hand_Infobox_Manga.png",
                    Status = "Vivo"
                }
                );
        }
    }
}
