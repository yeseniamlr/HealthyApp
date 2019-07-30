using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class LoginManager
    {
        public static int isLoged(string usuario, string contraseña)
        {
            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            int idUsuario = 0;
            var query = (from l in dbContext.Logins
                         where l.Usuario == usuario && l.Password == contraseña
                         select new { id = l.ID }).SingleOrDefault();

            if (query != null)
            {
                idUsuario = query.id;
                return idUsuario;
            }
            else
            {
                return idUsuario;
            }

        }
    }
}