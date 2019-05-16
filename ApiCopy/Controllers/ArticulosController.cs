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
    public class ArticulosController : ApiController
    {
        RepositoryArticulos repo;

        public ArticulosController()
        {
            this.repo = new RepositoryArticulos();
        }

        [HttpGet]
        [Route("api/Articulos")]
        ////ruta  http://localhost:58647/api/COPYst //por defecto si no pusiera route
        public List<Articulos> GetArticulos()
        {
            return this.repo.GetArticulos();
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
        [HttpPost]
        [Route("api/InsertarArticulo")]
        public void articulos(Articulos articulos)
        {
            this.repo.InsertarArticulos(articulos.Nombre, articulos.Cantidad, articulos.Precio, articulos.Tipo, articulos.Marca, articulos.Imagen);
        }

        [HttpPut]
        [Route("api/ModificarArticulo/{Id_Articulos}")]
        public void ModificarArticulo(Articulos articulo)
        {
            this.repo.ModificarArticulo(articulo.Id_Articulos, articulo.Nombre, articulo.Cantidad, articulo.Precio, articulo.Tipo, articulo.Imagen, articulo.Marca);
        }
        [HttpDelete]
        [Route("api/EliminarArticulo/{id_articulo}")]
        public void EliminarArticulo(int id_articulo)
        {
            this.repo.EliminarArticulo(id_articulo);
        }

    }
}
