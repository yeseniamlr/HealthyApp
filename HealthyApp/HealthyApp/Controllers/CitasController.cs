using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{

    public class CitasController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        [HttpGet]

        public ActionResult CitasGeneral()
        {

            if (Session["UserName"] != null)
            {
                var query = (from c in dbContext.citas
                             join l in dbContext.Logins on c.LoginID equals l.ID
                             join p in dbContext.Perfils on l.ID equals p.LoginID
                             select new
                             {
                                 Dia = c.Dia,
                                 Mes = c.Mes,
                                 Año = c.Año,
                                 Horario = c.Horario,
                                 Paciente = p.Apellido + " " + p.Nombre
                             }).ToList();

                List<CitaGeneral> citas = new List<CitaGeneral>();
                foreach (var cita in query)
                {
                    CitaGeneral citaGeneral = new CitaGeneral();
                    citaGeneral.Dia = cita.Dia;
                    citaGeneral.Mes = cita.Mes;
                    citaGeneral.Año = cita.Año;
                    citaGeneral.Horario = cita.Horario;
                    citaGeneral.Paciente = cita.Paciente;

                    citas.Add(citaGeneral);
                }

                return View(citas);


            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        public ActionResult CitasPaciente(int loginID)
        {
            if (Session["UserName"] != null)
            {
                CitasPaciente citasPaciente = new CitasPaciente();
                citasPaciente.loginId = loginID;

                var query = (from c in dbContext.citas
                             where c.LoginID == loginID
                             select c).ToList();

                List<Cita> citas = new List<Cita>();

                foreach (var cita in query)
                {
                    Cita objetocita = new Cita();
                    objetocita.ID = cita.ID;
                    objetocita.LoginID = loginID;
                    objetocita.Dia = cita.Dia;
                    objetocita.Mes = cita.Mes;
                    objetocita.Año = cita.Año;
                    objetocita.Horario = cita.Horario;

                    citas.Add(objetocita);
                }

                citasPaciente.citas = citas;
                return View(citasPaciente);
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }
        [HttpGet]
        public ActionResult AgregarCita(int loginID)
        {
            if (Session["UserName"] != null)
            {

                AgregarCita agregarCita = new AgregarCita();
                agregarCita.LoginID = loginID;

                return View(agregarCita);

            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        [HttpPost]

        public ActionResult AgregarCita(AgregarCita model)
        {
            if (Session["UserName"] != null)
            {
                if (ModelState.IsValid)
                {
                    Cita cita = new Cita();
                    cita.LoginID = model.LoginID;
                    cita.Dia = model.Dia;
                    cita.Mes = model.Mes;
                    cita.Año = model.Año;
                    cita.Horario = model.Horario;
                    dbContext.citas.Add(cita);

                    dbContext.SaveChanges();

                    return RedirectToAction("CitasPaciente", "Citas", new { loginID = model.LoginID });
                }

                else
                {
                    return View(model);
                }

            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

    }
}


