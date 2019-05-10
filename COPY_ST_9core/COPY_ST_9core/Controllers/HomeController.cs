using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COPY_ST_9core.Models;
using COPY_ST_9core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace COPY_ST_9core.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryCOPYstClient repo;

        public HomeController(IRepositoryCOPYstClient repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Articulostipo()
        {
            List<String> tipo =await this.repo.GetTipo();
            ViewBag.Tipo = tipo;
            return View();
            //return View(this.repo.GetArticulos());
        }
        [HttpPost]
        public async Task<ActionResult>Articulos(string tipo)
        {
            List<String> Tipo = await repo.GetTipo();
            List<Articulos> articulo =await repo.GetArticulosTipo(tipo);
            ViewBag.Tipo = Tipo;
            return View(articulo);

            //return View(this.repo.GetArticulos());
        }



        public async Task<IActionResult> CatalogoCompleto()
        {
            List<Articulos> articulos =
                await this.repo.GetArticulos();

            return View(articulos);
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registro(Usuarios usuario)
        {
            await this.repo.InsertarUsuarios(usuario.Nombre,
                usuario.Password, usuario.Mail, usuario.Telf);

            return View();
        }
    }
}