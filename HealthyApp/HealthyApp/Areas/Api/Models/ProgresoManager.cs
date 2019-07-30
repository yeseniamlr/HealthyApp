using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class ProgresoManager
    {
        public static ProgresoReturn Progreso(int id)
        {

            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            var query = (from p in dbContext.progresos
                         join pr in dbContext.Perfils on p.PerfilID equals pr.ID
                         join l in dbContext.Logins on pr.LoginID equals l.ID
                         where l.ID == id
                         orderby p.Fecha descending
                         select p
                       ).ToList();

            bool flag = true;
            ProgresoReturn progreso = new ProgresoReturn();
            foreach (var p in query)
            {
                if (flag)
                {
                    flag = false;


                    progreso.IMC = p.IMC;
                    progreso.Peso = p.Peso;
                    progreso.Estatura = p.Estatura;
                    progreso.Medida_Cadera = p.Medida_Cadera;
                    progreso.Medida_Cintura = p.Medida_Cintura;
                    progreso.Edad_Metabolica = p.Edad_Metabolica;


                }
            }
            return progreso;
        }

        public static List<Decimal> Grafica(int id)
        {
            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            var query = (from p in dbContext.progresos
                         join pr in dbContext.Perfils on p.PerfilID equals pr.ID
                         join l in dbContext.Logins on pr.LoginID equals l.ID
                         where l.ID == id
                         orderby p.Fecha ascending
                         select p
                       ).ToList();

            List<Decimal> grafica = new List<decimal>();

            foreach (var p in query)
            {
                grafica.Add(p.IMC);

            }

            return grafica;
        }
    }
}