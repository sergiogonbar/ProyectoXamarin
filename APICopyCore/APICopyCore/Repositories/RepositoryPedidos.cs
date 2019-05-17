using APICopyCore.Data;
using APICopyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Repositories
{
    public class RepositoryPedidos
    {
        COPYstContext context;

        public RepositoryPedidos(COPYstContext context)
        {
            this.context = context;
        }
        public void EliminarPedido(int id_pedido)
        {
            var registro = (from datos in context.Pedidos
                            where datos.Id_Pedido == id_pedido
                            select datos).Single();

            context.Pedidos.Remove(registro);
            context.SaveChanges();
        }
        public void InsertarPedido(int Id_Pedido, string producto, int cantidad_pedida, int id, int id_articulos, DateTime fecha)
        {
            Pedidos pedido = new Pedidos();

            pedido.Id_Pedido = Id_Pedido;
            pedido.Producto = producto;
            pedido.Cantidad_Pedida = cantidad_pedida;
            pedido.Id = id;
            pedido.Id_Articulos = id_articulos;
            pedido.Fecha = DateTime.Now;

            Articulos articulo = new Articulos();
            articulo.Cantidad -= cantidad_pedida;

            this.context.Pedidos.Add(pedido);
            this.context.SaveChanges();

        }

        public int PedidoMaximo()
        {
            var consulta = (from datos in context.Pedidos
                            select datos).Max(x => x.Id_Pedido);
            int maximo = consulta + 1;
            return maximo;
        }


        public void ModificarPedido(int id_pedido, string producto, int cantidad_pedida, DateTime fecha, int id, int id_articulos)
        {
            var consulta = from datos in context.Pedidos
                           where datos.Id_Pedido == id_pedido
                           select datos;
            Pedidos pedido = consulta.FirstOrDefault();
            pedido.Producto = producto;
            pedido.Cantidad_Pedida = cantidad_pedida;
            pedido.Fecha = DateTime.Now;
            pedido.Id = id;
            pedido.Id_Articulos = id_articulos;


            this.context.SaveChanges();
        }


        public List<Pedidos> MostrarPedidos()
        {
            var consulta = from datos in context.Pedidos
                           select datos;
            return consulta.ToList();
        }
        public Pedidos BuscarPedido(int id_pedido)
        {
            return this.context.Pedidos.SingleOrDefault(x => x.Id_Pedido == id_pedido);
        }
    }
}
