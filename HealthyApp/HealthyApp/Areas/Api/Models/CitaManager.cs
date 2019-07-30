using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class CitaManager
    {
        public static CitaReturn VerificarCita(int loginID)
        {
            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();
            var query = (from c in dbContext.citas
                         where c.LoginID == loginID
                         orderby c.Año, c.Mes, c.Dia
                         select c).ToList();

            bool flag = true;



            foreach (var cita in query)
            {
                if (cita.Año >= DateTime.Now.Year)
                {
                    if (cita.Mes >= DateTime.Now.Month)
                    {
                        if (cita.Mes == DateTime.Now.Month)
                        {
                            if (cita.Dia >= DateTime.Now.Day)
                            {
                                if (flag)
                                {
                                    flag = false;
                                    CitaReturn citaReturn = new CitaReturn();
                                    citaReturn.Año = cita.Año;
                                    citaReturn.Mes = cita.Mes;
                                    citaReturn.Dia = cita.Dia;
                                    citaReturn.Horario = cita.Horario;
                                    return citaReturn;
                                }
                            }
                        }
                        else
                        {
                            if (flag)
                            {
                                flag = false;
                                CitaReturn citaReturn2 = new CitaReturn();
                                citaReturn2.Año = cita.Año;
                                citaReturn2.Mes = cita.Mes;
                                citaReturn2.Dia = cita.Dia;
                                citaReturn2.Horario = cita.Horario;
                                return citaReturn2;
                            }

                        }
                    }
                }
            }
            CitaReturn citaReturn3 = new CitaReturn();
            citaReturn3.Año = 0;
            citaReturn3.Mes = 0;
            citaReturn3.Dia = 0;
            citaReturn3.Horario = " ";
            return citaReturn3;
        }
    }
}