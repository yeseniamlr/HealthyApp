using HealthyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyApp.Areas.Api.Models
{
    public class NutriologoManager
    {

        public static NutriologoResult Nutriologo()
        {

            HealthyAppDataBaseDbContext dbContext = new HealthyAppDataBaseDbContext();

            var query = (from mn in dbContext.mi_Nutriologos
                         select new
                         {
                           
                             foto = mn.Foto,
                             nombre = mn.Nombre+" "+mn.Apellido,
                             cedula = mn.Cedula,
                             telefono = mn.Telefono,
                             descripcion = mn.Descripcion,
                             calle = mn.Calle,
                             numeroext = mn.Numero_Exterior,
                             numeroint = mn.Numero_Interior,
                             municipio = mn.Municipio,
                             estado = mn.Estado,
                             codigopostal = mn.Codigo_Postal
                         }).SingleOrDefault();


            NutriologoResult nutriologo = new NutriologoResult();

            nutriologo.Foto = query.foto;
            nutriologo.Nombre = query.nombre;
            nutriologo.Cedula = query.cedula;
            nutriologo.Telefono = query.telefono;
            nutriologo.Descripcion = query.descripcion;
            nutriologo.Calle = query.calle;
            nutriologo.Numero_Exterior = query.numeroext;
            nutriologo.Numero_Interior = query.numeroint;
            nutriologo.Municipio = query.municipio;
            nutriologo.Estado = query.estado;
            nutriologo.Codigo_Postal = query.codigopostal;


            return nutriologo;
        }
    }
}