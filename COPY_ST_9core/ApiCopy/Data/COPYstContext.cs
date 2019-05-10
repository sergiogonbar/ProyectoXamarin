using ApiCopy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiCopy.Data
{
    public class COPYstContext:DbContext
    {
        public COPYstContext() : base("name=cadenaAzure")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<COPYstContext>(null);
        }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Articulos> articulos { get; set; }
        public DbSet<Pedidos> pedidos { get; set; }

    }
}