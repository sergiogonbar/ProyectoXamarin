using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COPY_ST_9core.Models;
using COPY_ST_9core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace COPY_ST_9core.Controllers
{
    public class AdministradorController : Controller
    {
        IRepositoryCOPYstClient repo;

        public AdministradorController(IRepositoryCOPYstClient repo)
        {
            this.repo = repo;

        }

        public IActionResult Index()
        {
           return View();
        }

        public async Task<IActionResult> MostrarUsuario()
        {
            List<Usuarios> usuarios =
               await this.repo.GetUsuarios();

            return View(usuarios);
           
        }
        public async Task<ActionResult> MostrarAdmin()
        {
            List<Usuarios> admins =
              await this.repo.GetAdministradores();

            return View(admins);
        }
        public async Task<ActionResult> MostrarPedidos()
        {
            List<Pedidos> pedidos =
              await this.repo.MostrarPedidos();
            return View(pedidos);
        }

        public async Task<ActionResult> Delete(int id)
        {
           await repo.EliminarUsuario(id);
            ViewBag.Mensaje = "Usuario eliminado";
            return RedirectToAction("MostrarAdmin");
        }
        public ActionResult ModificarAdmin(int id)
        {

            //Session["ID"] = id;


            return View();
        }


        //[HttpPost]
        //public async Task<ActionResult> ModificarAdmin(String nombre, String password, String funcion)
        //{
        //    //int id = (int)Session["ID"];
        //    await repo.ModificarUsuario(/*id*/ nombre, password, funcion);
        //    ViewBag.Mensaje = "Administrador Modificado";
        //    return View();

        //}

        public ActionResult ModificarUsuario(int id)
        {
            
            //Session["ID"] = id;


            return View();
        }


        //[HttpPost]
        ////public async Task <ActionResult> ModificarUsuario(String nombre, String password, String funcion)
        ////{
        ////    //int id = (int)Session["ID"];
        ////   await repo.ModificarUsuario(/*id,*/ nombre, password, funcion);
        ////    ViewBag.Mensaje = "Usuario Modificado";
        ////    return View();

        //}


        public ActionResult RegistroAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task <ActionResult> RegistroAdmin(Usuarios usuario)
        {
           await this.repo.InsertarAdmin(/*usuario.ID*/ usuario.Nombre, usuario.Password, usuario.Mail,usuario.Telf);
            ViewBag.Mensaje = "Administrador Registrado";
            return View();
        }


        public ActionResult RegistroUsuarios()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroUsuarios(Usuarios usuario)
        {
            repo.InsertarUsuarios(/*usuario.ID*/ usuario.Nombre, usuario.Password, usuario.Mail, usuario.Telf);
            ViewBag.Mensaje = "Usuario Registrado";
            return View();
        }


        //SECCCION ARTICULOS DEL CONTROLADOR

        public async Task <ActionResult> MostrarArticulos()
        {
            List<Articulos> articulo =
              await this.repo.GetArticulos();

            return View(articulo);
        }

        public ActionResult InsertarArticulos()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> InsertarArticulos(Articulos articulo)
        {


           await repo.InsertarArticulos(articulo.Nombre, articulo.Cantidad, articulo.Precio,
                articulo.Tipo,articulo.Imagen);

            ViewBag.Mensaje = "Articulo Registrado";
            return View();
        }

        public  async Task<ActionResult> DeleteArticulo(int id)
        {
             await repo.EliminarArticulo(id);
            ViewBag.Mensaje = "Articulo eliminado";
            return RedirectToAction("MostrarArticulos");
        }

        //public ActionResult ModificarArticulo(int id)
        //{

        //    //Session["ID"] = id;


        //    return View();
        //}


        //[HttpPost]
        //public ActionResult ModificarArticulo(String nombre, int? cantidad_stock, int? precio, String tipo, String imagen)
        //{
        //    int id = (int)Session["ID"];
        //    repo2.ModificarArticulo(id, nombre, cantidad_stock, precio, tipo, imagen);
        //    ViewBag.Mensaje = "Articulo Modificado";
        //    return View();


        //}
    }
}