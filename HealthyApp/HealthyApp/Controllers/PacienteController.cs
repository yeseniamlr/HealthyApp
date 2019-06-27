using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class PacienteController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        [HttpGet]


        public ActionResult Paciente(int ID)
        {
            if (Session["UserName"] != null)
            {
                ProgresoCommon progresoCommon = new ProgresoCommon();

                progresoCommon.IDPaciente = ID;


                var query = (from p in dbContext.Perfils
                             where p.ID == ID
                             select new
                             {
                                 nombre = p.Nombre,
                                 apellido = p.Apellido,
                                 edad = p.Edad,
                                 genero = p.Genero,
                                 foto = p.Foto_paciente
                             }).SingleOrDefault();

                progresoCommon.Nombre = query.nombre;
                progresoCommon.Apellido = query.apellido;
                progresoCommon.Edad = query.edad;
                progresoCommon.Genero = query.genero;
                progresoCommon.Foto_paciente = query.foto;

                progresoCommon.progresoCreate = new ProgresoCreate();

                progresoCommon.progresoResult = new ProgresoResult();
                List<ViewModel.Progreso> progresos = new List<ViewModel.Progreso>();

                var query1 = (from p in dbContext.progresos
                              where p.PerfilID == ID
                              select new
                              {
                                  imc = p.IMC,
                                  medida_cintura = p.Medida_Cintura,
                                  peso = p.Peso,
                                  medida_cadera = p.Medida_Cadera,
                                  estatura = p.Estatura,
                                  edad_metabolica = p.Edad_Metabolica,
                                  fecha = p.Fecha
                              }).ToList();

                foreach (var progreso in query1)
                {
                    ViewModel.Progreso progreso1 = new ViewModel.Progreso();

                    progreso1.IMC = progreso.imc;
                    progreso1.Medida_Cintura = progreso.medida_cintura;
                    progreso1.Peso = progreso.peso;
                    progreso1.Medida_Cadera = progreso.medida_cadera;
                    progreso1.Estatura = progreso.estatura;
                    progreso1.Edad_Metabolica = progreso.edad_metabolica;
                    progreso1.Fecha = progreso.fecha;

                    progresos.Add(progreso1);


                }
                progresoCommon.progresoResult.progresos = progresos;

                return View(progresoCommon);
            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }


        }
        [HttpPost]
        public ActionResult Paciente(ProgresoCommon modelo)
        {
            if (Session["UserName"] != null)
            {
                if (ModelState.IsValid)
                {
                    Models.Progreso progreso1 = new Models.Progreso();
                    try
                    {
                        progreso1.PerfilID = modelo.IDPaciente;
                        progreso1.IMC = Math.Round( modelo.progresoCreate.Peso / (modelo.progresoCreate.Estatura * modelo.progresoCreate.Estatura),2);
                        progreso1.Medida_Cintura = modelo.progresoCreate.Medida_Cintura;
                        progreso1.Peso = modelo.progresoCreate.Peso;
                        progreso1.Medida_Cadera = modelo.progresoCreate.Medida_Cadera;
                        progreso1.Estatura = modelo.progresoCreate.Estatura;
                        progreso1.Edad_Metabolica = modelo.progresoCreate.Edad_Metabolica;
                        progreso1.Fecha = DateTime.Now.ToShortDateString();

                        dbContext.progresos.Add(progreso1);
                        dbContext.SaveChanges();
                    }
                    catch (DbEntityValidationException exception)
                    {
                        string mensaje = exception.Message;
                    }
                    return RedirectToAction("Paciente", "Paciente", new {id=modelo.IDPaciente });


                }
                else {

                    return RedirectToAction("Paciente", "Paciente", new { id = modelo.IDPaciente });

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
