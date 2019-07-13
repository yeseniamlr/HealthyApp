using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class MenuController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();


        [HttpGet]

        public ActionResult Menu(int id)
        {
            if (Session["UserName"] != null)
            {
                Semana semana = new Semana();
                semana.lunes = new Lunes();
                semana.martes = new Martes();
                semana.miercoles = new Miercoles();
                semana.jueves = new Jueves();
                semana.viernes = new Viernes();
                semana.sabado = new Sabado();
                semana.domingo = new Domingo();
                var menusemanal = (from ms in dbContext.mi_Menus
                                   where ms.LoginID == id
                                   select ms).SingleOrDefault();

                semana.MenuSemanalID = menusemanal.ID;
                int idsemanal = menusemanal.ID;

                for (int i = 1; i < 8; i++)
                {
                    var Desayuno = (from md in dbContext.MenuDes
                                    join c in dbContext.comidas on md.ComidaID equals c.ID
                                    where md.MenuSemanalID == idsemanal && md.DiaID == i && md.TiempoID == 1
                                    select new { desc = c.Descripcion }).ToList();

                    List<string> desayuno = new List<string>();
                    foreach (var des in Desayuno)
                    {
                        desayuno.Add(des.desc);
                    }

                    var Snack = (from md in dbContext.MenuDes
                                 join c in dbContext.comidas on md.ComidaID equals c.ID
                                 where md.MenuSemanalID == idsemanal && md.DiaID == i && md.TiempoID == 2
                                 select new { desc = c.Descripcion }).ToList();

                    List<string> snack = new List<string>();
                    foreach (var sna in Snack)
                    {
                        snack.Add(sna.desc);
                    }


                    var Comida = (from md in dbContext.MenuDes
                                  join c in dbContext.comidas on md.ComidaID equals c.ID
                                  where md.MenuSemanalID == idsemanal && md.DiaID == i && md.TiempoID == 3
                                  select new { desc = c.Descripcion }).ToList();

                    List<string> comida = new List<string>();
                    foreach (var com in Comida)
                    {
                        comida.Add(com.desc);
                    }

                    var Snack2 = (from md in dbContext.MenuDes
                                  join c in dbContext.comidas on md.ComidaID equals c.ID
                                  where md.MenuSemanalID == idsemanal && md.DiaID == i && md.TiempoID == 4
                                  select new { desc = c.Descripcion }).ToList();

                    List<string> snack2 = new List<string>();
                    foreach (var sna2 in Snack2)
                    {
                        snack2.Add(sna2.desc);
                    }

                    var Cena = (from md in dbContext.MenuDes
                                join c in dbContext.comidas on md.ComidaID equals c.ID
                                where md.MenuSemanalID == idsemanal && md.DiaID == i && md.TiempoID == 5
                                select new { desc = c.Descripcion }).ToList();

                    List<string> cena = new List<string>();
                    foreach (var cen in Cena)
                    {
                        cena.Add(cen.desc);
                    }



                    switch (i)
                    {
                        case 1:
                            semana.domingo.Desayuno = desayuno;
                            semana.domingo.Snack = snack;
                            semana.domingo.Comida = comida;
                            semana.domingo.Snack2 = snack2;
                            semana.domingo.Cena = cena;
                            break;

                        case 2:
                            semana.lunes.Desayuno = desayuno;
                            semana.lunes.Snack = snack;
                            semana.lunes.Comida = comida;
                            semana.lunes.Snack2 = snack2;
                            semana.lunes.Cena = cena;
                            break;

                        case 3:
                            semana.martes.Desayuno = desayuno;
                            semana.martes.Snack = snack;
                            semana.martes.Comida = comida;
                            semana.martes.Snack2 = snack2;
                            semana.martes.Cena = cena;
                            break;

                        case 4:
                            semana.miercoles.Desayuno = desayuno;
                            semana.miercoles.Snack = snack;
                            semana.miercoles.Comida = comida;
                            semana.miercoles.Snack2 = snack2;
                            semana.miercoles.Cena = cena;
                            break;

                        case 5:
                            semana.jueves.Desayuno = desayuno;
                            semana.jueves.Snack = snack;
                            semana.jueves.Comida = comida;
                            semana.jueves.Snack2 = snack2;
                            semana.jueves.Cena = cena;
                            break;

                        case 6:
                            semana.viernes.Desayuno = desayuno;
                            semana.viernes.Snack = snack;
                            semana.viernes.Comida = comida;
                            semana.viernes.Snack2 = snack2;
                            semana.viernes.Cena = cena;
                            break;

                        case 7:
                            semana.sabado.Desayuno = desayuno;
                            semana.sabado.Snack = snack;
                            semana.sabado.Comida = comida;
                            semana.sabado.Snack2 = snack2;
                            semana.sabado.Cena = cena;
                            break;

                    }
                }
                return View(semana);

            }
            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }
        
    }
}
