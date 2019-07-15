using HealthyApp.Helper;
using HealthyApp.Models;
using HealthyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity.Validation;
using System.Web.Security;

namespace HealthyApp.Controllers
{
    public class LoginController : Controller
    {
        #region Log In
        // GET: Login
        public ActionResult Login(UserModel usm)
        {
            if (Session["UserName"] == null)
            {
                if (ModelState.IsValid)
                {
                    using (HealthyAppDataBaseDbContext dbCtx = new HealthyAppDataBaseDbContext())
                    {
                        //string encryptedPass = EncryptionDecryption.EncriptarSHA1(usm.Password);

                        var isLogged = dbCtx.Logins
                                .Where(x => x.Usuario.Equals(usm.UserName)
                                && x.Password.Equals(usm.Password))
                                .FirstOrDefault();


                        if (isLogged != null)
                        {
                            Session["UserName"] = usm.UserName.ToString();

                            Session["LoginID"] = 3;                                

                            var path = Server.MapPath("~") + @"Files";
                            var fileName = "/Log.txt";
                            StreamWriter sw = new StreamWriter(path + fileName, true);
                            sw.WriteLine("Login -" + DateTime.Now + " " + "El usuario : " + usm.UserName + " ingresó");
                            sw.Close();

                            return RedirectToAction("Usuarios", "HomePage");
                        }
                        else
                        {
                            //return RedirectToAction("Registrar","Login");
                        }

                    }
                }
            }


            return View(usm);
        }
        #endregion
    }
}