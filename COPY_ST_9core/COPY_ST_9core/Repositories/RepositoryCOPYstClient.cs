using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using COPY_ST_9core.Models;
using Newtonsoft.Json;

namespace COPY_ST_9core.Repositories
{
    public class RepositoryCOPYstClient : IRepositoryCOPYstClient
    {
        private String apiurl;
        private MediaTypeWithQualityHeaderValue headerjson;

        public RepositoryCOPYstClient() {
            this.apiurl = "https://apicopysgb.azurewebsites.net/";
            this.headerjson = new MediaTypeWithQualityHeaderValue("application/json");
        }

        //METODOS ELIMINAR
        public async  Task EliminarArticulo(int Id_Articulos)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarArticulo/" + Id_Articulos;
                client.BaseAddress = new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);

            }
        }

        public async Task EliminarPedido(int id_pedido)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarPedido/" + id_pedido;
                client.BaseAddress = new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);

            }
        }

        public async Task EliminarUsuario(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/EliminarUsuario/" + id;
                client.BaseAddress = new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                await client.DeleteAsync(peticion);

            }
        }

        //METODOS CONSULTA
        public async Task<Usuarios> ExisteUsuario(string usu, string pass)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetUsuario/"+usu+"/"+pass;
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                //MediaTypeWithQualityHeaderValue headerjson =
                //    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    Usuarios usuario = await
                        response.Content.ReadAsAsync<Usuarios>();
                    return usuario;
                }
                else
                {
                    return null;
                }
            }

        }

        public async Task<List<Usuarios>> GetAdministradores()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetAdmin";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Usuarios> usuarios = await
                        response.Content.ReadAsAsync<List<Usuarios>>();
                    return usuarios;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Articulos>> GetArticulos()
        {
            using (HttpClient client = new HttpClient()) 
            {
                String peticion = "api/Articulos";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Articulos> articulos = await
                        response.Content.ReadAsAsync<List<Articulos>>();
                    return articulos;
                }
                else
                {
                    return null;
                }
            }
        }

    

        //FALTA POR MIRAR
        public async  Task<List<Articulos>> GetArticulosTipo(string tipo)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ArticulosTipo/"+tipo;
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Articulos> articulos = await
                        response.Content.ReadAsAsync<List<Articulos>>();
                    return articulos;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<Articulos>> GetArticulosMarca(string marca)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/ArticulosTipo/" + marca;
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Articulos> articulos = await
                        response.Content.ReadAsAsync<List<Articulos>>();
                    return articulos;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<String>> GetTipo()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetTipo";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<String> articulos = await
                        response.Content.ReadAsAsync<List<String>>();
                    return articulos;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<String>> GetMarca()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetMarca";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<String> articulos = await
                        response.Content.ReadAsAsync<List<String>>();
                    return articulos;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetUsuarios";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Usuarios> usuarios = await
                        response.Content.ReadAsAsync<List<Usuarios>>();
                    return usuarios;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<List<Pedidos>> MostrarPedidos()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/GetPedidos";
                client.BaseAddress =
                    new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                MediaTypeWithQualityHeaderValue headerjson =
                    new MediaTypeWithQualityHeaderValue("application/json");
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response =
                    await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Pedidos> pedidos = await
                        response.Content.ReadAsAsync<List<Pedidos>>();
                    return pedidos;
                }
                else
                {
                    return null;
                }
            }
        }
        public Task<Usuarios> usuario(int id)
        {
            throw new NotImplementedException();
        }
        //METODOS INSERTAR
        public  async Task InsertarAdmin(string nombre, string password, string mail, int telf)
        {
            using (HttpClient client = new HttpClient())

            {
                String peticion = "api/InsertarAdministrador";
            client.BaseAddress =
               new Uri(this.apiurl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(headerjson);

            Usuarios usuario = new Usuarios();
            usuario.Nombre = nombre;
            usuario.Password = password;
            usuario.Mail = mail;
            usuario.Telf = telf;
            String json = JsonConvert.SerializeObject(usuario);
            StringContent content =
                new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage response =
                await client.PostAsync(peticion, content);
            if (response.IsSuccessStatusCode)
            {

            }

        }
    }

        public async Task InsertarArticulos(string nombre, int cantidad_stock, int precio, string tipo, string imagen)
        {
            using (HttpClient client = new HttpClient())

            {

                String peticion = "api/InsertarArticulo";
                client.BaseAddress =
                   new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Articulos articulo = new Articulos();
                articulo.Nombre = nombre;
                articulo.Cantidad = cantidad_stock;
                articulo.Precio = precio;
                articulo.Tipo = tipo;
                articulo.Imagen = imagen;
                String json = JsonConvert.SerializeObject(articulo);
                StringContent content =
                    new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }

            }
        }

        public Task InsertarPedido(string pRODUCTO, int cANTIDAD_PEDIDA, int iD, int iD_ARTICULOS)
        {
            throw new NotImplementedException();
        }
        public async Task InsertarUsuarios(string nombre, string password, string mail, int telf)
        {
            using (HttpClient client = new HttpClient())

            {

                String peticion = "api/InsertarUsuario";
                client.BaseAddress =
                   new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Usuarios usuario = new Usuarios();
                usuario.Nombre = nombre;
                usuario.Password = password;
                usuario.Mail = mail;
                usuario.Telf = telf;
                String json = JsonConvert.SerializeObject(usuario);
                StringContent content =
                    new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(peticion, content);
                if (response.IsSuccessStatusCode)
                {

                }

            }
        }


        //METODOS MODIFICAR
        public async Task ModificarArticulo(int id_articulo, string nombre, int cantidad_stock, int precio, string tipo, string imagen)
        {
            using (HttpClient client = new HttpClient())
             {

                string peticion = "api/ModificarArticulo/"+ id_articulo;
                client.BaseAddress =
                   new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Articulos articulo = new Articulos();
                articulo.Nombre = nombre;
                articulo.Cantidad = cantidad_stock;
                articulo.Precio = precio;
                articulo.Tipo = tipo;
                articulo.Imagen = imagen;
               String json = JsonConvert.SerializeObject(articulo);
                StringContent content =
                    new StringContent(json, System.Text.Encoding.UTF8, "application/json");
              
                    await client.PutAsync(peticion, content);
               

            }
        }

        public async Task ModificarPedido(int id_pedido, string producto, int cantidad_pedida, string fecha, int id, int id_articulos)
        {
            using (HttpClient client = new HttpClient())
            {

                String peticion = "api/ModificarArticulo/" + id_pedido;
                client.BaseAddress =
                   new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Pedidos pedido = new Pedidos();
                pedido.Producto = producto;
                pedido.Cantidad_Pedida = cantidad_pedida;
                pedido.Fecha = fecha;
                pedido.Id = id;
                pedido.Id_Articulos = id_articulos;
                

                String json = JsonConvert.SerializeObject(pedido);
                StringContent content =
                    new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);


            }
        }

        public async Task ModificarUsuario(int id, string nombre, string password, string funcion)
        {
            using (HttpClient client = new HttpClient())
            {

                String peticion = "api/ModificarUsuario/" + id;
                client.BaseAddress =
                   new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Usuarios usuario = new Usuarios();
                usuario.Nombre = nombre;
                usuario.Password = password;
                usuario.Funcion = funcion;
                String json = JsonConvert.SerializeObject(usuario);
                StringContent content =
                    new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                await client.PutAsync(peticion, content);


            }
        }

      

       

      
    }
}