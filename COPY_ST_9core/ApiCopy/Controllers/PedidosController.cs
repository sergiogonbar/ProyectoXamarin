using ApiCopy.Models;
using ApiCopy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCopy.Controllers
{
    public class PedidosController : ApiController
    {
        RepositoryPedidos repo;

        public PedidosController()
        {
            this.repo = new RepositoryPedidos();
        }
        [HttpGet]
        [Route("api/GetPedidos")]
        public List<Pedidos> GetPedidos()
        {
            return this.repo.MostrarPedidos();
        }



        //[HttpGet]
        //[Route("api/GetTipo")]
        //////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        //public List<String> GetTipo()
        //{
        //    return this.repo.GetTipo();
        //}
        //[HttpGet]
        //[Route("api/GetMarca")]
        //////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        //public List<String> GetMarca()
        //{
        //    return this.repo.GetMarca();
        //}


        [HttpPost]
        [Route("api/InsertarPedido")]
        public void pedidos(Pedidos pedidos)
        {
            this.repo.InsertarPedido(pedidos.Id_Pedido, pedidos.Producto, pedidos.Cantidad_Pedida, pedidos.Id, pedidos.Id_Articulos, pedidos.Fecha);
        }

        [HttpPut]
        [Route("api/ModificarPedido/{id_pedido}")]
        public void ModificarPedido(Pedidos pedido)
        {

            this.repo.ModificarPedido(pedido.Id_Pedido, pedido.Producto, pedido.Cantidad_Pedida, pedido.Fecha, pedido.Id, pedido.Id_Articulos);
        }

        [HttpGet]
        [Route("api/GetMaxPedido")]
        public int GetMaxPedido()
        {
            return this.repo.PedidoMaximo();
        }


        [HttpDelete]
        [Route("api/EliminarPedido/{id_pedido}")]
        public void EliminarPedido(int id_pedido)
        {
            this.repo.EliminarPedido(id_pedido);
        }

    }
}
