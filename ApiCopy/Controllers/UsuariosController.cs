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
    public class UsuariosController : ApiController
    {
        RepositoryUsuarios repo;

        public UsuariosController()
        {
            this.repo = new RepositoryUsuarios();
        }
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
        [Route("api/GetUsuario/{usuario}/{password}")]
        public Usuarios usuario(String usuario, String password)
        {
            return this.repo.ExisteUsuario(usuario, password);
        }

        [HttpPost]
        [Route("api/InsertarUsuario")]
        public void usuarios(Usuarios usuario)
        {
            this.repo.InsertarUsuarios(usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
        }
        [HttpPost]
        [Route("api/InsertarAdministrador")]
        public void administrador(Usuarios usuario)
        {
            this.repo.InsertarAdmin(usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
        }
        [HttpPut]
        [Route("api/ModificarUsuario/{id}")]
        public void ModificarUsuario(Usuarios usuario)
        {
            this.repo.ModificarUsuario(usuario.Id, usuario.Nombre, usuario.Password, usuario.Funcion, usuario.Telf, usuario.Mail);
        }
        [HttpDelete]
        [Route("api/EliminarUsuario/{id}")]
        public void EliminarUsuario(int id)
        {
            this.repo.EliminarUsuario(id);
        }
    }
}
