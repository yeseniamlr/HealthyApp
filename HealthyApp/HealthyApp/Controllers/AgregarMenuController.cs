using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthyApp.Controllers
{
    public class AgregarMenuController : Controller
    {
        HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

        //DESAYUNO
        [HttpGet]

        public ActionResult Desayuno(int id, int dia)
        {
            if (Session["UserName"] != null)
            {
                List<AgregarMenu> agregarMenus = new List<AgregarMenu>();

                
                var comidas = (from c in dbContext.comidas
                               select c).ToList();

                foreach (var comida in comidas)
                {
                    AgregarMenu menu = new AgregarMenu();
                    menu.ID = comida.ID;
                    menu.Descripcion = comida.Descripcion;
                    menu.tiempoID = 1;
                    menu.menuID = id;
                    menu.diaID = dia;
                    agregarMenus.Add(menu);


                }

                return View(agregarMenus.ToList());
                
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }

        }

        [HttpPost]
        public ActionResult Desayuno(List<AgregarMenu> agregarMenus)
        {
            if (Session["UserName"] != null)
            {
                int idlocal=0;
                int dialocal=0;
                int flag = 0;

                foreach (var comida in agregarMenus)
                {
                    if (flag == 0) {
                        var query = (from md in dbContext.MenuDes
                                     where md.MenuSemanalID == comida.menuID && md.DiaID == comida.diaID && md.TiempoID == comida.tiempoID
                                     select md).ToList();


                        if (query.Count > 0)
                        {
                            foreach (var q in query)
                            {
                                dbContext.MenuDes.Remove(q);
                                dbContext.SaveChanges();
                            }
                        }

                        flag = 1;
                    }
                    
                    idlocal = comida.menuID;
                    dialocal = comida.diaID;

                    if (comida.isSelected == true)
                    {
                        MenuDes menuDes = new MenuDes();
                        menuDes.MenuSemanalID = comida.menuID;
                        menuDes.DiaID = comida.diaID;
                        menuDes.TiempoID = comida.tiempoID;
                        menuDes.ComidaID = comida.ID;

                        dbContext.MenuDes.Add(menuDes);
                        dbContext.SaveChanges();


                    }

                }
                return RedirectToAction("Snack", "AgregarMenu", new { id = idlocal, dia = dialocal });  
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        //SNACK

        [HttpGet]

        public ActionResult Snack(int id, int dia)
        {
            if (Session["UserName"] != null)
            {
                List<AgregarMenu> agregarMenus = new List<AgregarMenu>();

                
                var comidas = (from c in dbContext.comidas
                               select c).ToList();

                foreach (var comida in comidas)
                {
                    AgregarMenu menu = new AgregarMenu();
                    menu.ID = comida.ID;
                    menu.Descripcion = comida.Descripcion;
                    menu.tiempoID = 2;
                    menu.menuID = id;
                    menu.diaID = dia;
                    agregarMenus.Add(menu);


                }

                return View(agregarMenus.ToList());

            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }

        }

        [HttpPost]
        public ActionResult Snack(List<AgregarMenu> agregarMenus)
        {
            if (Session["UserName"] != null)
            {
                int idlocal = 0;
                int dialocal = 0;
                int flag = 0;
                foreach (var comida in agregarMenus)
                {

                    if (flag == 0)
                    {
                        var query = (from md in dbContext.MenuDes
                                     where md.MenuSemanalID == comida.menuID && md.DiaID == comida.diaID && md.TiempoID == comida.tiempoID
                                     select md).ToList();


                        if (query.Count > 0)
                        {
                            foreach (var q in query)
                            {
                                dbContext.MenuDes.Remove(q);
                                dbContext.SaveChanges();
                            }
                        }

                        flag = 1;
                    }
                    idlocal = comida.menuID;
                    dialocal = comida.diaID;

                    if (comida.isSelected == true)
                    {
                        MenuDes menuDes = new MenuDes();
                        menuDes.MenuSemanalID = comida.menuID;
                        menuDes.DiaID = comida.diaID;
                        menuDes.TiempoID = comida.tiempoID;
                        menuDes.ComidaID = comida.ID;

                        dbContext.MenuDes.Add(menuDes);
                        dbContext.SaveChanges();


                    }

                }
                return RedirectToAction("Comida", "AgregarMenu", new { id = idlocal, dia = dialocal });
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        //COMIDA

        [HttpGet]

        public ActionResult Comida(int id, int dia)
        {
            if (Session["UserName"] != null)
            {
                List<AgregarMenu> agregarMenus = new List<AgregarMenu>();

               

                var comidas = (from c in dbContext.comidas
                               select c).ToList();

                foreach (var comida in comidas)
                {
                    AgregarMenu menu = new AgregarMenu();
                    menu.ID = comida.ID;
                    menu.Descripcion = comida.Descripcion;
                    menu.tiempoID = 3;
                    menu.menuID = id;
                    menu.diaID = dia;
                    agregarMenus.Add(menu);


                }

                return View(agregarMenus.ToList());

            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }

        }

        [HttpPost]
        public ActionResult Comida(List<AgregarMenu> agregarMenus)
        {
            if (Session["UserName"] != null)
            {
                int idlocal = 0;
                int dialocal = 0;
                int flag = 0;

                foreach (var comida in agregarMenus)
                {

                    if (flag == 0)
                    {
                        var query = (from md in dbContext.MenuDes
                                     where md.MenuSemanalID == comida.menuID && md.DiaID == comida.diaID && md.TiempoID == comida.tiempoID
                                     select md).ToList();


                        if (query.Count > 0)
                        {
                            foreach (var q in query)
                            {
                                dbContext.MenuDes.Remove(q);
                                dbContext.SaveChanges();
                            }
                        }

                        flag = 1;
                    }
                    idlocal = comida.menuID;
                    dialocal = comida.diaID;

                    if (comida.isSelected == true)
                    {
                        MenuDes menuDes = new MenuDes();
                        menuDes.MenuSemanalID = comida.menuID;
                        menuDes.DiaID = comida.diaID;
                        menuDes.TiempoID = comida.tiempoID;
                        menuDes.ComidaID = comida.ID;

                        dbContext.MenuDes.Add(menuDes);
                        dbContext.SaveChanges();


                    }

                }
                return RedirectToAction("Snack2", "AgregarMenu", new { id = idlocal, dia = dialocal });
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }
        //SNACK 2
        [HttpGet]

        public ActionResult Snack2(int id, int dia)
        {
            if (Session["UserName"] != null)
            {
                List<AgregarMenu> agregarMenus = new List<AgregarMenu>();
                
                var comidas = (from c in dbContext.comidas
                               select c).ToList();

                foreach (var comida in comidas)
                {
                    AgregarMenu menu = new AgregarMenu();
                    menu.ID = comida.ID;
                    menu.Descripcion = comida.Descripcion;
                    menu.tiempoID = 4;
                    menu.menuID = id;
                    menu.diaID = dia;
                    agregarMenus.Add(menu);


                }

                return View(agregarMenus.ToList());

            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }

        }

        [HttpPost]
        public ActionResult Snack2(List<AgregarMenu> agregarMenus)
        {
            if (Session["UserName"] != null)
            {
                int idlocal = 0;
                int dialocal = 0;
                int flag = 0;
                foreach (var comida in agregarMenus)
                {

                    if (flag == 0)
                    {
                        var query = (from md in dbContext.MenuDes
                                     where md.MenuSemanalID == comida.menuID && md.DiaID == comida.diaID && md.TiempoID == comida.tiempoID
                                     select md).ToList();


                        if (query.Count > 0)
                        {
                            foreach (var q in query)
                            {
                                dbContext.MenuDes.Remove(q);
                                dbContext.SaveChanges();
                            }
                        }

                        flag = 1;
                    }
                    idlocal = comida.menuID;
                    dialocal = comida.diaID;

                    if (comida.isSelected == true)
                    {
                        MenuDes menuDes = new MenuDes();
                        menuDes.MenuSemanalID = comida.menuID;
                        menuDes.DiaID = comida.diaID;
                        menuDes.TiempoID = comida.tiempoID;
                        menuDes.ComidaID = comida.ID;

                        dbContext.MenuDes.Add(menuDes);
                        dbContext.SaveChanges();


                    }

                }
                return RedirectToAction("Cena", "AgregarMenu", new { id = idlocal, dia = dialocal });
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }

        //CENA

        [HttpGet]

        public ActionResult Cena(int id, int dia)
        {
            if (Session["UserName"] != null)
            {
                List<AgregarMenu> agregarMenus = new List<AgregarMenu>();


                var comidas = (from c in dbContext.comidas
                               select c).ToList();

                foreach (var comida in comidas)
                {
                    AgregarMenu menu = new AgregarMenu();
                    menu.ID = comida.ID;
                    menu.Descripcion = comida.Descripcion;
                    menu.tiempoID = 5;
                    menu.menuID = id;
                    menu.diaID = dia;
                    agregarMenus.Add(menu);


                }

                return View(agregarMenus.ToList());

            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }

        }

        [HttpPost]
        public ActionResult Cena(List<AgregarMenu> agregarMenus)
        {
            if (Session["UserName"] != null)
            {
                int idlocal = 0;
                int dialocal = 0;
                int flag = 0;
                foreach (var comida in agregarMenus)
                {

                    if (flag == 0)
                    {
                        var query = (from md in dbContext.MenuDes
                                     where md.MenuSemanalID == comida.menuID && md.DiaID == comida.diaID && md.TiempoID == comida.tiempoID
                                     select md).ToList();


                        if (query.Count > 0)
                        {
                            foreach (var q in query)
                            {
                                dbContext.MenuDes.Remove(q);
                                dbContext.SaveChanges();
                            }
                        }

                        flag = 1;
                    }
                    idlocal = comida.menuID;
                    dialocal = comida.diaID;

                    if (comida.isSelected == true)
                    {
                        MenuDes menuDes = new MenuDes();
                        menuDes.MenuSemanalID = comida.menuID;
                        menuDes.DiaID = comida.diaID;
                        menuDes.TiempoID = comida.tiempoID;
                        menuDes.ComidaID = comida.ID;

                        dbContext.MenuDes.Add(menuDes);
                        dbContext.SaveChanges();


                    }

                }
                var querylogin = (from ms in dbContext.mi_Menus
                                  join l in dbContext.Logins on ms.LoginID equals l.ID
                                  where ms.ID == idlocal
                                  select new { login = l.ID }).SingleOrDefault();

                return RedirectToAction("Menu", "Menu",new {id=querylogin.login });
            }

            else
            {
                //Si no se inicio sesion no se puede acceder a esta pagina
                return RedirectToAction("Login", "Login");

            }
        }


    }

}
