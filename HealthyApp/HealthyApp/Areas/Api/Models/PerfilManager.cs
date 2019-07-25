using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class PerfilManager
    {

        public static PerfilReturn Inicio(int id)

        {
            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            var query = (from p in dbContext.Perfils
                         where p.LoginID == id
                         select new {
                             foto = p.Foto_paciente,
                             nombre = p.Nombre + " " + p.Apellido,
                             edad = p.Edad,
                             genero = p.Genero })
                             .SingleOrDefault();

            PerfilReturn perfil = new PerfilReturn();
            perfil.foto = query.foto;
            perfil.nombre = query.nombre;
            perfil.edad = query.edad;
            perfil.genero = query.genero;

            return perfil; 


        }
    }
}