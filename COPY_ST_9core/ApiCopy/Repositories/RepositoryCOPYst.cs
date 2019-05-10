using ApiCopy.Data;
using ApiCopy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


#region Tabla Usuarios
//CREATE TABLE USUARIOS(
//    ID int IDENTITY(1,1) PRIMARY KEY,
//    NOMBRE varchar(255) NOT NULL,
//    PASSWORD  varchar(255)NOT NULL,
//    FUNCION varchar(255),
//	MAIL varchar(255)
//);

#endregion

namespace ApiCopy.Repositories
{
    public class RepositoryCOPYst 
    {
        COPYstContext context;

        public RepositoryCOPYst( )
        {
            this.context =new COPYstContext();
        }

        // METODOS PARA ELIMINAR EN LAS 3 TABLAS

        public void EliminarArticulo(int id)
        {
            var registro = (from datos in context.articulos
                            where datos.Id_Articulos == id
                            select datos).Single();

            context.articulos.Remove(registro);
            context.SaveChanges(); throw new NotImplementedException();
        }

        public void EliminarPedido(int id_pedido)
        {
            var registro = (from datos in context.pedidos
                            where datos.Id_Pedido == id_pedido
                            select datos).Single();

            context.pedidos.Remove(registro);
            context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            var registro = (from datos in context.usuarios
                            where datos.Id == id
                            select datos).Single();

            context.usuarios.Remove(registro);
            context.SaveChanges();
        }

        //METODOS DE CONSULTA EN LAS 3 TABLAS

        public Usuarios ExisteUsuario(string usuario, string password)
        {
            var consulta = from datos in context.usuarios
                           where datos.Nombre == usuario
                           && datos.Password == password
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Usuarios> GetAdministradores()
        {
            var consulta = from datos in context.usuarios
                           where datos.Funcion == "ADMIN"
                           select datos;
            return consulta.ToList();
        }

        public List<Articulos> GetArticulos()
        {
            return this.context.articulos.ToList();
        }

        public List<Articulos> GetArticulosTipo(string tipo)
        {
            var consulta = from datos in context.articulos
                           where datos.Tipo == tipo
                           select datos;

            return consulta.ToList();
        }
        public List<Articulos> GetArticulosMarca(string marca)
        {
            var consulta = from datos in context.articulos
                           where datos.Marca == marca
                           select datos;

            return consulta.ToList();
        }
        public List<string> GetTipo()
        {
            var consulta = (from datos in context.articulos
                            select datos.Tipo).Distinct();
            return consulta.ToList();
        }

        public List<string> GetMarca()
        {
            var consulta = (from datos in context.articulos
                            select datos.Marca).Distinct();
            return consulta.ToList();
        }

        public List<Usuarios> GetUsuarios()
        {
            var consulta = from datos in context.usuarios
                           where datos.Funcion == "USER"
                           select datos;
            return consulta.ToList();
        }


        // METODOS INSERTAR

        public void InsertarAdmin(string nombre, string password, string mail,int telf)
        {
            Usuarios user = new Usuarios();
            var consulta = (from datos in context.usuarios select datos.Id);
            user.Id = consulta.Max() + 1;

            user.Nombre = nombre;
            user.Password = password;
            user.Funcion = "ADMIN";
            user.Mail = mail;
            user.Telf = telf;
            this.context.usuarios.Add(user);
            this.context.SaveChanges();
        }

        public void InsertarArticulos(string nombre, int cantidad_stock, int precio, string tipo,string marca, string imagen)
        {
            Articulos articulo = new Articulos();
            var idmayor = (from datos in context.articulos select datos.Id_Articulos);
            articulo.Id_Articulos = idmayor.Max() + 1;
            articulo.Nombre = nombre;
            articulo.Cantidad = cantidad_stock;
            articulo.Precio = precio;
            articulo.Tipo = tipo;
            articulo.Marca = marca;
            articulo.Imagen = imagen;

            this.context.articulos.Add(articulo);
            this.context.SaveChanges();
        }

        public void InsertarPedido(string producto, int cantidad_pedida, int id, int  id_articulos,string fecha)
        {
            //para consultar https://danielggarcia.wordpress.com/2013/11/30/linq-to-sql-iv-modificacion-de-datos/

            Pedidos pedido = new Pedidos();
            Articulos articulo = new Articulos();

            var idmayor = (from datos in context.pedidos select datos.Id_Pedido);

            pedido.Id_Pedido = idmayor.Max() + 1;
        
            //List<ARTICULOS> prod = (from datos in context.ARTICULOS select datos.NOMBRE);
            pedido.Producto = producto;
            pedido.Cantidad_Pedida = cantidad_pedida;
            pedido.Fecha = DateTime.Now.ToShortDateString();
            // pedido.Id= selecionamos el id del usuario comprador y lo guardamos en su sesion yse insertara en su tabla de pedidos
            //pedido.Id_Articulos=selecionamos el id del articulo
            pedido.Cantidad_Pedida = cantidad_pedida;

            //habra que borrar la cantidad pedida
            //seleccionamos el id del articulo
             var consulta = from datos in context.articulos
                           where datos.Id_Articulos == id_articulos
                           select datos;

             articulo = consulta.FirstOrDefault();

            //le restamos la cantidad pedida
            articulo.Cantidad -= cantidad_pedida;
            if (articulo.Cantidad <= 0)
            {


            }
            else {
                //guardamos
                this.context.SaveChanges();
            }

           

            //se añade el pedido  a la tabla
           

            this.context.pedidos.Add(pedido);
            this.context.SaveChanges();
        }

        public void InsertarUsuarios(string nombre, string password, string mail,int telf)
        {
            Usuarios user = new Usuarios();
            var consulta = (from datos in context.usuarios select datos.Id);
            user.Id = consulta.Max() + 1;
            user.Nombre = nombre;
            user.Password = password;
            user.Funcion = "USER";
            user.Mail = mail;
            user.Telf = telf;
            this.context.usuarios.Add(user);
            this.context.SaveChanges();
        }

        public void ModificarArticulo(int id, string nombre, int cantidad_stock, int precio, string tipo, string imagen,string marca)
        {
            var consulta = from datos in context.articulos
                           where datos.Id_Articulos == id
                           select datos;
            Articulos articulo = consulta.FirstOrDefault();
            articulo.Nombre = nombre;
            articulo.Cantidad = cantidad_stock;
            articulo.Precio = precio;
            articulo.Tipo = tipo;
            articulo.Imagen = imagen;
            articulo.Marca = marca;

            this.context.SaveChanges();
        }

        public void ModificarPedido(int id_pedido, string producto, int cantidad_pedida, string fecha, int id, int id_articulos)
        {
            var consulta = from datos in context.pedidos
                           where datos.Id_Pedido ==id_pedido
                           select datos;
            Pedidos pedido = consulta.FirstOrDefault();
            pedido.Producto = producto;
            pedido.Cantidad_Pedida = cantidad_pedida;
            pedido.Fecha = DateTime.Now.ToShortDateString();
            pedido.Id = id;
            pedido.Id_Articulos = id_articulos;
          

            this.context.SaveChanges();
        }

        public void ModificarUsuario(int id, string nombre, string password, string funcion,int telf,string mail)
        {
            var consulta = from datos in context.usuarios
                           where datos.Id == id
                           select datos;
            Usuarios user = consulta.FirstOrDefault();
            user.Nombre = nombre;
            user.Password = password;
            user.Funcion = funcion;
            user.Telf = telf;
            user.Mail = mail;
            this.context.SaveChanges();
        }

        public List<Pedidos> MostrarPedidos()
        {
            var consulta = from datos in context.pedidos
                           select datos;
            return consulta.ToList();
        }

        public Usuarios usuario(int id)
        {
            var consulta = (from datos in context.usuarios
                            where datos.Id == id
                            select datos);
            return consulta.FirstOrDefault();
        }



        //para buscar //Por si los necesito mas adelante
        public Pedidos BuscarPedido(int id_pedido)
        {
            return this.context.pedidos.SingleOrDefault(x => x.Id_Pedido == id_pedido);
        }
        public Usuarios BuscarUsuario(int id)
        {
            return this.context.usuarios.SingleOrDefault(x => x.Id == id);
        }
        public Articulos BuscarArticulos(int id_articulos)
        {
            return this.context.articulos.SingleOrDefault(x => x.Id_Articulos == id_articulos);
        }
    }
}