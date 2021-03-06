﻿using APICopyCore.Data;
using APICopyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICopyCore.Repositories
{
    public class RepositoryUsuarios
    {
        COPYstContext context;

        public RepositoryUsuarios(COPYstContext context)
        {
            this.context = context;
        }
        
        public void EliminarUsuario(int id)
        {
            var registro = (from datos in context.Usuarios
                            where datos.Id == id
                            select datos).Single();

            context.Usuarios.Remove(registro);
            context.SaveChanges();
        }

        public Usuarios ExisteUsuario(string usuario, string password)
        {
            var consulta = from datos in context.Usuarios
                           where datos.Nombre == usuario
                           && datos.Password == password
                           select datos;
            return consulta.FirstOrDefault();
        }

        public List<Usuarios> GetAdministradores()
        {
            var consulta = from datos in context.Usuarios
                           where datos.Funcion == "ADMIN"
                           select datos;
            return consulta.ToList();
        }
        public List<Usuarios> GetUsuarios()
        {
            var consulta = from datos in context.Usuarios
                           where datos.Funcion == "USER"
                           select datos;
            return consulta.ToList();
        }
        public void InsertarAdmin(string nombre, string password, string mail, int telf)
        {
            Usuarios user = new Usuarios();
            var consulta = (from datos in context.Usuarios select datos.Id);
            user.Id = consulta.Max() + 1;

            user.Nombre = nombre;
            user.Password = password;
            user.Funcion = "ADMIN";
            user.Mail = mail;
            user.Telf = telf;
            this.context.Usuarios.Add(user);
            this.context.SaveChanges();
        }
        public void InsertarUsuarios(string nombre, string password, string mail, int telf)
        {
            Usuarios user = new Usuarios();
            var consulta = (from datos in context.Usuarios select datos.Id);
            user.Id = consulta.Max() + 1;
            user.Nombre = nombre;
            user.Password = password;
            user.Funcion = "USER";
            user.Mail = mail;
            user.Telf = telf;
            this.context.Usuarios.Add(user);
            this.context.SaveChanges();
        }
        public void ModificarUsuario(int id, string nombre, string password, string funcion, int telf, string mail)
        {
            var consulta = from datos in context.Usuarios
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
        public Usuarios usuario(int id)
        {
            var consulta = (from datos in context.Usuarios
                            where datos.Id == id
                            select datos);
            return consulta.FirstOrDefault();
        }
        public Usuarios BuscarUsuario(int id)
        {
            return this.context.Usuarios.SingleOrDefault(x => x.Id == id);
        }
    }
}
