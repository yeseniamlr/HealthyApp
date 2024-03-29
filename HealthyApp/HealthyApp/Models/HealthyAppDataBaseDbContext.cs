﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HealthyApp.Models
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class HealthyAppDataBaseDbContext : DbContext


    {
        public HealthyAppDataBaseDbContext() : base("HealthyAppDataBaseDbContext")
        {


        }

        public DbSet<Cita> citas { get; set; }
        public DbSet<Comida> comidas { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<MenuSemanal> mi_Menus { get; set; }
        public DbSet<Mi_Nutriologo> mi_Nutriologos { get; set; }
        public DbSet<Perfil> Perfils { get; set; }
        public DbSet<Progreso> progresos { get; set; }
        public DbSet<Rol> rols { get; set; }
        public DbSet<MenuDes> MenuDes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}