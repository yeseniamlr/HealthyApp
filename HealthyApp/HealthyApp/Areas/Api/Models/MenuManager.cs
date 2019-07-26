using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class MenuManager
    {

        public static List<string> Menu(int id, int Dia, int Tiempo)
        {
            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            var query = (from md in dbContext.MenuDes
                         join m in dbContext.mi_Menus on md.MenuSemanalID equals m.ID
                         join l in dbContext.Logins on m.LoginID equals l.ID
                         join c in dbContext.comidas on md.ComidaID equals c.ID
                         where l.ID == id && md.DiaID == Dia && md.TiempoID == Tiempo
                         select new { comida = c.Descripcion }).ToList();

            List<string> comidas = new List<string>();
            foreach (var comida in query)
            {
                comidas.Add(comida.comida);
                
            }

            return comidas;
        }

    }
}