﻿using System;
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
    public class UsuariosController : ControllerBase
    {
        RepositoryUsuarios repo;

        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
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

        [Authorize]
        [HttpPost]
        [Route("api/InsertarUsuario")]
        public void usuarios(Usuarios usuario)
        {
            this.repo.InsertarUsuarios(usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
        }

        [Authorize]
        [HttpPost]
        [Route("api/InsertarAdministrador")]
        public void administrador(Usuarios usuario)
        {
            this.repo.InsertarAdmin(usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
        }

        [Authorize]
        [HttpPut]
        [Route("api/ModificarUsuario/{id}")]
        public void ModificarUsuario(Usuarios usuario)
        {
            this.repo.ModificarUsuario(usuario.Id, usuario.Nombre, usuario.Password, usuario.Funcion, usuario.Telf, usuario.Mail);
        }

        [Authorize]
        [HttpDelete]
        [Route("api/EliminarUsuario/{id}")]
        public void EliminarUsuario(int id)
        {
            this.repo.EliminarUsuario(id);
        }
    }
}