using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class NutriologoController : Controller

    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        [HttpGet]

        public ActionResult Informacionoalgoasi()
        {


            if (Session["UserName"] != null)
            {

                int login = Convert.ToInt16(Session["LoginID"]);
                var query = (from l in dbContext.Logins
                             join mn in dbContext.mi_Nutriologos on l.ID equals mn.LoginID
                             where l.ID == login
                             select new
                             {
                                 usuario = l.Usuario,
                                 password = l.Password,
                                 foto = mn.Foto,
                                 nombre = mn.Nombre,
                                 apellido = mn.Apellido,
                                 cedula = mn.Cedula,
                                 telefono = mn.Telefono,
                                 descripcion = mn.Descripcion,
                                 calle = mn.Calle,
                                 numeroext = mn.Numero_Exterior,
                                 numeroint = mn.Numero_Interior,
                                 municipio = mn.Municipio,
                                 estado = mn.Estado,
                                 codigopostal = mn.Codigo_Postal }).SingleOrDefault();

                MiNutriolgo minutriologo = new MiNutriolgo();

                minutriologo.Usuario = query.usuario;
                minutriologo.Password = query.password;
                minutriologo.Foto = query.foto;
                minutriologo.Nombre = query.nombre;
                minutriologo.Apellido = query.apellido;
                minutriologo.Cedula = query.cedula;
                minutriologo.Telefono = query.telefono;
                minutriologo.Descripcion = query.descripcion;
                minutriologo.Calle = query.calle;
                minutriologo.Numero_Exterior = query.numeroext;
                minutriologo.Numero_Interior = query.numeroint;
                minutriologo.Municipio = query.municipio;
                minutriologo.Estado = query.estado;
                minutriologo.Codigo_Postal = query.codigopostal;

                return View(minutriologo);
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");
            }
        }
        [HttpPost]
        public ActionResult Informacionoalgoasi(MiNutriolgo Model)
        {
            if (Session["UserName"] != null)
            {
                if (ModelState.IsValid)
                {
                    int login = Convert.ToInt16(Session["LoginID"]);

                    var query = (from l in dbContext.Logins
                                 
                                 where l.ID == login
                                 select l
                                 ).SingleOrDefault();

                    query.Usuario = Model.Usuario;
                    query.Password = Model.Password;

                    dbContext.Entry(query).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();

                    var querytos = (from mn in dbContext.mi_Nutriologos
                                    where mn.LoginID == login
                                    select mn).SingleOrDefault();

                    //querytos.Foto = Model.Foto;
                    querytos.Nombre = Model.Nombre;
                    querytos.Apellido = Model.Apellido;
                    querytos.Cedula = Model.Cedula;
                    querytos.Telefono = Model.Telefono;
                    querytos.Descripcion = Model.Descripcion;
                    querytos.Calle = Model.Calle;
                    querytos.Numero_Exterior = Model.Numero_Exterior;
                    querytos.Numero_Interior = Model.Numero_Interior;
                    querytos.Municipio = Model.Municipio;
                    querytos.Estado = Model.Estado;
                    querytos.Codigo_Postal = Model.Codigo_Postal;

                    dbContext.Entry(querytos).State = System.Data.Entity.EntityState.Modified;
                    dbContext.SaveChanges();

                    return RedirectToAction("Informacionoalgoasi", "Nutriologo");
                }
                return View(Model);
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }
    }
}
