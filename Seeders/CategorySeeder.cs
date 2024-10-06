using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techstore.Models;

namespace techstore.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Computadoras y Portátiles", Description = "Equipos de escritorio, laptops, monitores, etc." },
                new Category { Id = 2, Name = "Teléfonos y Tablets", Description = "Smartphones, tablets, accesorios para móviles." },
                new Category { Id = 3, Name = "Accesorios para Computadoras", Description = "Teclados, ratones, webcams, auriculares, y más." },
                new Category { Id = 4, Name = "Componentes de Hardware", Description = "Tarjetas gráficas, discos duros, fuentes de poder, procesadores." },
                new Category { Id = 5, Name = "Almacenamiento y Memoria", Description = "Discos duros externos, SSDs, memorias USB, tarjetas de memoria." },
                new Category { Id = 6, Name = "Redes y Conectividad", Description = "Routers, switches, cables, adaptadores Wi-Fi." },
                new Category { Id = 7, Name = "Electrónica de Consumo", Description = "Cámaras, drones, consolas de videojuegos." },
                new Category { Id = 8, Name = "Software y Licencias", Description = "Sistemas operativos, antivirus, licencias de software." }
            );
        }
    }
}