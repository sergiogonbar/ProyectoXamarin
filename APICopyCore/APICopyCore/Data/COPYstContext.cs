using APICopyCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Data
{
    public class COPYstContext: DbContext
    {
        public COPYstContext(DbContextOptions options) : base(options) { }

        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }
}
