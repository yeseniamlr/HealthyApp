using HealthyApp.ViewModel;
using System;
using HealthyApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class HomePageController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        [HttpGet]

        public ActionResult Usuarios()
        {
            if (Session["UserName"] != null)
            {
                //Se crea el ViewModel comun

                UsuarioCommon Model = new UsuarioCommon();
                Model.Usuario = new Usuario();
                Model.usuarios = new UsuariosResult();

                //Se crea lista
                List<UsuarioResult> usuarios = new List<UsuarioResult>();

                //Se buscan los usuarios
                var query = (from u in dbContext.Perfils
                             orderby u.Nombre ascending
                             select new
                             {
                                 ID = u.ID,
                                 Nombre = u.Nombre + " " + u.Apellido,
                                 Edad = u.Edad
                             }
                            ).ToList();

                //se crean los objetos
                foreach (var u in query)

                {
                    //Se crea un usuario
                    UsuarioResult usuario = new UsuarioResult();

                    //Se asignan los valores actuales
                    usuario.ID = u.ID;
                    usuario.Nombre = u.Nombre;
                    usuario.Edad = u.Edad;

                    //Se agrega a la lista
                    usuarios.Add(usuario);
                }

                Model.usuarios.usuarios = usuarios;

                return View(Model);
            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");
            }
        }

        [HttpPost]

        public ActionResult Usuarios(UsuarioCommon model)
        {
            if (Session["UserName"] != null)
            {
                if (ModelState.IsValid)
                {
                    Perfil usuario = new Perfil();


                    usuario.Nombre = model.Usuario.Nombre;
                    usuario.Apellido = model.Usuario.Apellido;
                    usuario.Edad = model.Usuario.Edad;
                    usuario.Genero = model.Usuario.Genero;
                    usuario.Foto_paciente = model.Usuario.Foto_paciente;

                    //Se agrega a la base de datos

                    dbContext.Perfils.Add(usuario);
                    dbContext.SaveChanges();

                    return RedirectToAction("Usuarios", "HomePage");
                }
                else
                {
                    model.usuarios = new UsuariosResult();

                    //Se crea lista
                    List<UsuarioResult> usuarios = new List<UsuarioResult>();

                    //Se buscan los usuarios
                    var query = (from u in dbContext.Perfils
                                 orderby u.Nombre ascending
                                 select new
                                 {
                                     ID = u.ID,
                                     Nombre = u.Nombre + " " + u.Apellido,
                                     Edad = u.Edad
                                 }
                                ).ToList();

                    //se crean los objetos
                    foreach (var u in query)

                    {
                        //Se crea un usuario
                        UsuarioResult usuario = new UsuarioResult();

                        //Se asignan los valores actuales
                        usuario.ID = u.ID;
                        usuario.Nombre = u.Nombre;
                        usuario.Edad = u.Edad;

                        //Se agrega a la lista
                        usuarios.Add(usuario);
                    }

                    model.usuarios.usuarios = usuarios;

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
