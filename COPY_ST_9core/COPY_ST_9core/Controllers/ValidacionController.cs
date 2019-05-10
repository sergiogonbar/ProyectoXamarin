using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using COPY_ST_9core.Models;
using COPY_ST_9core.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace COPY_ST_9core.Controllers
{
    public class ValidacionController : Controller
    {
        IRepositoryCOPYstClient repo;

        public ValidacionController(IRepositoryCOPYstClient repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET: Login
        public IActionResult Login()
        {
            return View();
        }

        //POST: Login
        [HttpPost]
        public async Task<ActionResult> Login(String usuario, String password)
        {

            Usuarios Usuarios = await this.repo.ExisteUsuario(usuario, password);

            //Usuarios Usuarios = this.repo.ExisteUsuario(usuario, password);
            if (Usuarios == null)
            {
                ViewData["MENSAJE"] = "Usuario/Password incorrectos";
            }
            else
            {

                //trim recorta los espacios en blanco de los extrmeos en este caso de admin
                if (Usuarios.Funcion.Trim() == "ADMIN")
                {

                    ClaimsIdentity identidad =
                    new ClaimsIdentity(
                      CookieAuthenticationDefaults.AuthenticationScheme
                      , ClaimTypes.Name, ClaimTypes.Role);
                    //AÑADIMOS MAS DATOS A LA IDENTIDAD
                    identidad.AddClaim(new Claim(ClaimTypes.Name, Usuarios.Nombre));
                    identidad.AddClaim(new Claim(ClaimTypes.UserData, Usuarios.Password));
                    identidad.AddClaim(new Claim(ClaimTypes.Role, Usuarios.Funcion));
                    identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier, Usuarios.Id.ToString()));

                    //identidad.AddClaim(new Claim(ClaimTypes.StateOrProvince
                    //    , empleado.Departamento.ToString()));
                    ClaimsPrincipal principal =
                        new ClaimsPrincipal(identidad);
                    //PONEMOS AL USUARIO PRINCIPAL EN SESSION
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme
                        , principal, new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(10)
                        });
                    //UNA VEZ QUE TENEMOS AL USUARIO, LO LLEVAMOS A INDEX
                    return RedirectToAction("Index", "Administrador");


                }
                else {

                    ClaimsIdentity identidad =
                    new ClaimsIdentity(
                      CookieAuthenticationDefaults.AuthenticationScheme
                      , ClaimTypes.Name, ClaimTypes.Role);
                    //AÑADIMOS MAS DATOS A LA IDENTIDAD
                    identidad.AddClaim(new Claim(ClaimTypes.Name, Usuarios.Nombre));
                    identidad.AddClaim(new Claim(ClaimTypes.UserData, Usuarios.Password));
                    identidad.AddClaim(new Claim(ClaimTypes.Role, Usuarios.Funcion));
                    identidad.AddClaim(new Claim(ClaimTypes.NameIdentifier, Usuarios.Id.ToString()));
                    //identidad.AddClaim(new Claim(ClaimTypes.StateOrProvince
                    //    , empleado.Departamento.ToString()));
                    ClaimsPrincipal principal =
                        new ClaimsPrincipal(identidad);
                    //PONEMOS AL USUARIO PRINCIPAL EN SESSION
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme
                        , principal, new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.Now.AddMinutes(10)
                        });
                    //UNA VEZ QUE TENEMOS AL USUARIO, LO LLEVAMOS A INDEX
                    return RedirectToAction("Index", "Usuarios");
                }
               

            }

            return View();

        }

        public async Task<IActionResult> CerrarSesion()
        {
            await HttpContext.SignOutAsync
                (CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}