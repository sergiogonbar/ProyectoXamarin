using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICopyCore.Models;
using APICopyCore.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICopyCore.Controllers
{

    [ApiController]
    public class PedidosController : ControllerBase
    {
        RepositoryPedidos repo;

        public PedidosController(RepositoryPedidos repo)
        {
            this.repo = repo;
        }

        [Authorize]
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

        [Authorize]
        [HttpPost]
        [Route("api/InsertarPedido")]
        public void pedidos(Pedidos pedidos)
        {
            this.repo.InsertarPedido(pedidos.Id_Pedido, pedidos.Producto, pedidos.Cantidad_Pedida, pedidos.Id, pedidos.Id_Articulos, pedidos.Fecha);
        }

        [Authorize]
        [HttpPut]
        [Route("api/ModificarPedido/{id_pedido}")]
        public void ModificarPedido(Pedidos pedido)
        {

            this.repo.ModificarPedido(pedido.Id_Pedido, pedido.Producto, pedido.Cantidad_Pedida, pedido.Fecha, pedido.Id, pedido.Id_Articulos);
        }

        [Authorize]
        [HttpGet]
        [Route("api/GetMaxPedido")]
        public int GetMaxPedido()
        {
            return this.repo.PedidoMaximo();
        }

        [Authorize]
        [HttpDelete]
        [Route("api/EliminarPedido/{id_pedido}")]
        public void EliminarPedido(int id_pedido)
        {
            this.repo.EliminarPedido(id_pedido);
        }

        [Authorize]
        [HttpGet]
        [Route("Api/BuscarPedido/{id}")]
        public List<Pedidos> BuscarPedido(int id)
        {
            return this.repo.BuscarPedidoUsuario(id);
        }
    }
}