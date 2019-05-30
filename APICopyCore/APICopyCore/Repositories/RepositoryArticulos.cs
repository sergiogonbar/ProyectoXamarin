using APICopyCore.Data;
using APICopyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Repositories
{
    public class RepositoryArticulos
    {
        COPYstContext context;

        public RepositoryArticulos(COPYstContext context)
        {
            this.context = context;
        }

        public List<Articulos> GetArticulos()
        {
            return this.context.Articulos.ToList();
        }

        public List<Articulos> GetArticulosTipo(string tipo)
        {
            var consulta = from datos in context.Articulos
                           where datos.Tipo == tipo
                           select datos;

            return consulta.ToList();
        }
        public List<Articulos> GetArticulosMarca(string marca)
        {
            var consulta = from datos in context.Articulos
                           where datos.Marca == marca
                           select datos;

            return consulta.ToList();
        }
        public List<string> GetTipo()
        {
            var consulta = (from datos in context.Articulos
                            select datos.Tipo).Distinct();
            return consulta.ToList();
        }

        public void EliminarArticulo(int id)
        {
            var registro = (from datos in context.Articulos
                            where datos.Id_Articulos == id
                            select datos).Single();

            context.Articulos.Remove(registro);
            context.SaveChanges(); throw new NotImplementedException();
        }
        public List<string> GetMarca()
        {
            var consulta = (from datos in context.Articulos
                            select datos.Marca).Distinct();
            return consulta.ToList();
        }
        public void InsertarArticulos(string nombre, int cantidad_stock, int precio, string tipo, string marca, string imagen ,String descripcion )
        {
            Articulos articulo = new Articulos();
            var idmayor = (from datos in context.Articulos select datos.Id_Articulos);
            articulo.Id_Articulos = idmayor.Max() + 1;
            articulo.Nombre = nombre;
            articulo.Cantidad = cantidad_stock;
            articulo.Precio = precio;
            articulo.Tipo = tipo;
            articulo.Marca = marca;
            articulo.Imagen = imagen;
            articulo.Descripcion = descripcion;

            this.context.Articulos.Add(articulo);
            this.context.SaveChanges();
        }
        public void ModificarArticulo(int id, string nombre, int cantidad_stock, int precio, string tipo, string imagen, string marca)
        {
            var consulta = from datos in context.Articulos
                           where datos.Id_Articulos == id
                           select datos;
            Articulos articulo = consulta.FirstOrDefault();
            articulo.Nombre = nombre;
            articulo.Cantidad = cantidad_stock;
            articulo.Precio = precio;
            articulo.Tipo = tipo;
            articulo.Imagen = imagen;
            articulo.Marca = marca;

            this.context.SaveChanges();
        }
        public Articulos BuscarArticulos(int id_articulos)
        {
            return this.context.Articulos.SingleOrDefault(x => x.Id_Articulos == id_articulos);
        }
    }
}
