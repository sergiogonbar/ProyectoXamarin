using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HerramientaInsertarArticulos.Models;
using HerramientaInsertarArticulos.Repositories;
using Microsoft.AspNetCore.Http;

namespace HerramientaInsertarArticulos.Controllers
{
    public class HomeController : Controller
    {
        public ToolBlobStorage tool;

        public RepositoryArticulo repo;

        public HomeController(ToolBlobStorage tool, RepositoryArticulo repo)
        {
            this.tool = tool;
            this.repo = repo;
        }

        public IActionResult Index() { return View(); }

        [HttpPost]
        public async Task<IActionResult> Index(String name, int stock, String type, IFormFile file, int price, string marca, string descripcion)
        {
            await this.tool.SubirBlob(file);
            String uriImagen = await this.tool.GetUriBlob(file.FileName);
            await this.repo.InsertarArticulos(name, stock, price, type,marca, uriImagen, descripcion);
            return View();
        }

    }
}
