using System.Web.Mvc;

namespace HealthyApp.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "Acceso Login",
               "Api/LoginAPP/isLoged/{usuario}/{contraseña}",
               new { controller = "LoginAPP", action="isLoged", usuario="",contraseña=""}
           );


            context.MapRoute(
               "Acceso Perfil",
               "Api/PerfilAPP/Inicio/{code}/{id}",
               new { controller = "PerfilAPP", action = "Inicio", code = "", id = "" }
           );

            context.MapRoute(
              "Acceso Nutriologo",
              "Api/NutriologoAPP/Nutriologo",
              new { controller = "NutriologoAPP", action = "Nutriologo"}
          );
        }

    }
}