using HerramientaInsertarArticulos.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HerramientaInsertarArticulos.Repositories
{
    public class RepositoryArticulo
    {
        private String apiurl;
        private MediaTypeWithQualityHeaderValue headerjson;

        public RepositoryArticulo()
        {
            this.apiurl = "https://apicopycore.azurewebsites.net/";
            this.headerjson = new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task InsertarArticulos(string nombre, int cantidad_stock, int precio, string tipo, string marca, string imagen, String descripcion)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/InsertarArticulo";
                client.BaseAddress = new Uri(this.apiurl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);

                Articulo articulo = new Articulo();
                articulo.Nombre = nombre;
                articulo.Cantidad = cantidad_stock;
                articulo.Precio = precio;
                articulo.Tipo = tipo;
                articulo.Imagen = imagen;
                articulo.Descripcion = descripcion;
                articulo.Marca = marca;
                String json = JsonConvert.SerializeObject(articulo);
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(peticion, content);
            }
        }



    }
}
