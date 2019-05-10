using COPY_ST_9core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COPY_ST_9core.Repositories
{
   public interface IRepositoryCOPYstClient
    {
        //INTERFACE ARTICULOS
       Task <List<Articulos>> GetArticulos();
         Task InsertarArticulos (String nombre, int cantidad_stock, int precio, String tipo, String imagen);
        Task ModificarArticulo(int Id_Articulos, String nombre, int cantidad_stock, int precio, String tipo, String imagen);
        Task EliminarArticulo(int Id_Articulos);

         Task <List<Articulos>> GetArticulosTipo(String tipo);
       Task<List<String>> GetTipo();
        Task<List<String>> GetMarca();
        Task<List<Articulos>> GetArticulosMarca(String marca);

        //INTERFACE USUARIOS

        Task<List<Usuarios>> GetUsuarios();
        Task<List<Usuarios>> GetAdministradores();
        Task<Usuarios> usuario(int id);
        Task<Usuarios> ExisteUsuario(String usu, String pass);



        Task ModificarUsuario(int id, String nombre, String password, String funcion);
        Task InsertarAdmin(String nombre, String password, String mail,int telf);
        Task InsertarUsuarios(String nombre, String password, String mail,int telf);
        Task EliminarUsuario(int id);

        //INTERFACE PEDIDOS
        Task<List<Pedidos>> MostrarPedidos();

        Task ModificarPedido(int id_pedido, String producto, int cantidad_pedida, String fecha, int id, int id_articulos);
        Task EliminarPedido(int id_pedido);
        Task InsertarPedido(string pRODUCTO, int cANTIDAD_PEDIDA, int iD, int iD_ARTICULOS);
    }
}
