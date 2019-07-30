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
                new { controller = "LoginAPP", action = "isLoged", usuario = "", contraseña = "" }
           );


            context.MapRoute(
               "Acceso Perfil",
               "Api/PerfilAPP/Inicio/{code}/{id}",
               new { controller = "PerfilAPP", action = "Inicio", code = "", id = "" }
           );

            context.MapRoute(
              "Acceso Nutriologo",
              "Api/NutriologoAPP/Nutriologo",
              new { controller = "NutriologoAPP", action = "Nutriologo" }
          );


            context.MapRoute(
             "Acceso Cita",
             "Api/CitaAPP/VerificarCita/{code}/{id}",
             new { controller = "CitaAPP", action = "VerificarCita", code = "", id = "" }
         );

            context.MapRoute(
          "Acceso Progreso",
          "Api/ProgresoAPP/Progreso/{code}/{id}",
          new { controller = "ProgresoAPP", action = "Progreso", code = "", id = "" }
      );


            context.MapRoute(
          "Acceso Grafica",
          "Api/ProgresoAPP/Grafica/{code}/{id}",
          new { controller = "ProgresoAPP", action = "Grafica", code = "", id = "" }
      );

            context.MapRoute(
         "Acceso Menu",
         "Api/MenuAPP/Menu/{id}/{Dia}/{Tiempo}",
         new { controller = "MenuAPP", action = "Menu", id = "", Dia = "", Tiempo = "" }
     );
        }
    }
}