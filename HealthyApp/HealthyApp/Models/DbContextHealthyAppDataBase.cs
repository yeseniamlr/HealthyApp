using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HealthyApp.Models
{

        [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class DbContextHealthyAppDataBase:DbContext


    {
        public DbContextHealthyAppDataBase() : base("DbContextHealthyAppDataBase")
        {


        }

        public virtual ICollection<Cita> Citas { get; set; }
        public virtual ICollection<Mi_Nutriologo> Mi_Nutriologos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}