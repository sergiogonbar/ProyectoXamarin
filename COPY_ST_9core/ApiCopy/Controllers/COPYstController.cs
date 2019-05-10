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
    public class COPYstController : ApiController
    {
        RepositoryCOPYst repo;

        public COPYstController()
        {
            this.repo = new RepositoryCOPYst();
        }

        //PARA MOSTRAR 3 SOBRE LAS 3 TABLAS
        [HttpGet]
        [Route("api/Articulos")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<Articulos> GetArticulos()
        {
            return this.repo.GetArticulos();
        }
      
        //http://localhost:58647/api/GetAdmin
        [HttpGet]
        [Route("api/GetAdmin")]
        public List<Usuarios> GetAdministradores()
        {
            return this.repo.GetAdministradores();
        }
        [HttpGet]
        [Route("api/GetUsuarios")]
        public List<Usuarios> GetUsuarios()
        {
            return this.repo.GetUsuarios();
        }
        [HttpGet]
        [Route("api/GetPedidos")]
        public List<Pedidos> GetPedidos()
        {
            return this.repo.MostrarPedidos();
        }

        [HttpGet]
        [Route("api/GetUsuario/{usuario}/{password}")]
        public Usuarios usuario(String usuario,String password)
        {
            return this.repo.ExisteUsuario(usuario, password);
        }

        [HttpGet]
        [Route("api/GetTipo")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<String> GetTipo()
        {
            return this.repo.GetTipo();
        }
        [HttpGet]
        [Route("api/GetMarca")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<String> GetMarca()
        {
            return this.repo.GetMarca();
        }

        [HttpGet]
        [Route("api/ArticulosTipo/{tipo}")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<Articulos> GetArticulosTipo(String tipo)
        {
            return this.repo.GetArticulosTipo(tipo);
        }
        [HttpGet]
        [Route("api/ArticulosMarca/{marca}")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<Articulos> GetArticulosMarca(String marca)
        {
            return this.repo.GetArticulosMarca(marca);
        }
        // CRUD 3 TABLAS

        //INSERTAR

        [HttpPost]
        [Route("api/InsertarUsuario")]
        public void usuarios(Usuarios usuario)
        {
            this.repo.InsertarUsuarios(usuario.Nombre, usuario.Password, usuario.Mail,usuario.Telf);
        }
        [HttpPost]
        [Route("api/InsertarAdministrador")]
        public void administrador(Usuarios usuario)
        {
            this.repo.InsertarAdmin(usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
        }
        [HttpPost]
        [Route("api/InsertarArticulo")]
        public void articulos (Articulos articulos)
        {
            this.repo.InsertarArticulos(articulos.Nombre,articulos.Cantidad,articulos.Precio,articulos.Tipo,articulos.Marca,articulos.Imagen);
        }




        [HttpPost]
        [Route("api/InsertarPedido")]
        public void pedidos(Pedidos pedidos)
        {
            this.repo.InsertarPedido(pedidos.Producto, pedidos.Cantidad_Pedida, pedidos.Id,pedidos.Id_Articulos,pedidos.Fecha);
        }

        //BUSCAR
   


        //MODIFICAR
        [HttpPut]
        [Route("api/ModificarUsuario/{id}")]
        public void ModificarUsuario( Usuarios usuario)
        {
            this.repo.ModificarUsuario(usuario.Id,usuario.Nombre, usuario.Password, usuario.Funcion, usuario.Telf, usuario.Mail);
        }
        [HttpPut]
        [Route("api/ModificarArticulo/{Id_Articulos}")]
        public void ModificarArticulo(Articulos articulo)
        {
            this.repo.ModificarArticulo(articulo.Id_Articulos,articulo.Nombre,articulo.Cantidad,articulo.Precio,articulo.Tipo,articulo.Imagen,articulo.Marca);
        }
       
        [HttpPut]
        [Route("api/ModificarPedido/{id_pedido}")]
        public void ModificarPedido(Pedidos pedido )
        {
           
            this.repo.ModificarPedido(pedido.Id_Pedido,pedido.Producto,pedido.Cantidad_Pedida,pedido.Fecha,pedido.Id,pedido.Id_Articulos);
        }

        [HttpDelete]
        [Route("api/EliminarUsuario/{id}")]
        public void EliminarUsuario(int id)
        {
            this.repo.EliminarUsuario(id);
        }
        [HttpDelete]
        [Route("api/EliminarArticulo/{id_articulo}")]
        public void EliminarArticulo(int id_articulo)
        {
            this.repo.EliminarArticulo(id_articulo);
        }
        [HttpDelete]
        [Route("api/EliminarPedido/{id_pedido}")]
        public void EliminarPedido(int id_pedido)
        {
            this.repo.EliminarArticulo(id_pedido);
        }

        //[HttpPut]
        //[Route("api/IncrementarSalario/{incremento}/{especialidad}")]
        //public void IncrementarSalario(int incremento, String especialidad)
        //{
        //    this.repo.IncrementarSalario(incremento, especialidad);
        //}
        //[HttpDelete]
        //[Route("api/EliminarDatos/{dato1}/{dato2}")]  en el cliente, en le repositorio se pone en la uri= "api/EliminarDatos/"+dato1+dato2


        //public List<Articulos> GetArticulosTipo()
        //{

        //}
    }
}
