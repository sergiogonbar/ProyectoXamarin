using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COPY_ST_9core.Models;
using COPY_ST_9core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace COPY_ST_9core.Controllers
{
    public class UsuariosController : Controller
    {
        IRepositoryCOPYstClient repo;

        public UsuariosController(IRepositoryCOPYstClient repo)
        {
            this.repo = repo;

        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> MostrarPedidos()
        {
            List<Pedidos> pedidos =
              await this.repo.MostrarPedidos();
            return View(pedidos);
        }
        public async Task<IActionResult> MostrarUsuario()
        {
            List<Usuarios> usuarios =
               await this.repo.GetUsuarios();

            return View(usuarios);

        }
        public async Task<ActionResult> MostrarArticulos()
        {
            List<Articulos> articulo =
              await this.repo.GetArticulos();

            return View(articulo);
        }

    }
}