namespace HealthyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cita",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    MesID = c.Int(nullable: false),
                    Dia_SemanaID = c.Int(nullable: false),
                    Horario = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                    Dia_Numero = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dia_Semana", t => t.Dia_SemanaID, cascadeDelete: true)
                .ForeignKey("dbo.Mes", t => t.MesID, cascadeDelete: true);
                //.Index(t => t.Dia_SemanaID)
                //.Index(t => t.MesID);
            
            CreateTable(
                "dbo.Dia_Semana",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Dia = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Mi_Menu",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ComidaID = c.Int(nullable: false),
                    Dia_SemanaID = c.Int(nullable: false),
                    Horario = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Comida", t => t.ComidaID, cascadeDelete: true)
                .ForeignKey("dbo.Dia_Semana", t => t.Dia_SemanaID, cascadeDelete: true);
                //.Index(t => t.ComidaID)
                //.Index(t => t.Dia_SemanaID);
            
            CreateTable(
                "dbo.Comida",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Platillo = c.String(nullable: false, maxLength: 45, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Mese = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Consultorio",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Calle = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                        Numero_Exterior = c.Int(nullable: false),
                        Numero_Interior = c.Int(nullable: false),
                        Municipio = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                        Estado = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                        Codigo_Postal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Mi_Nutriologo",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ConsultorioID = c.Int(nullable: false),
                    Foto = c.String(nullable: false, unicode: false),
                    Nombre = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    Apellido = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    Cedula = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Telefono = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    Descripcion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Consultorio", t => t.ConsultorioID, cascadeDelete: true);
            //.Index(t => t.ConsultorioID);

            CreateTable(
                "dbo.Login",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    RolID = c.Int(nullable: false),
                    Usuario = c.String(nullable: false, maxLength: 45, unicode: false, storeType: "nvarchar"),
                    Password = c.String(nullable: false, maxLength: 45, unicode: false, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rol", t => t.RolID, cascadeDelete: true);
                //.Index(t => t.RolID);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoRol = c.String(nullable: false, maxLength: 45, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Perfil",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ProgresoID = c.Int(nullable: false),
                    Nombre = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Apellido = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Edad = c.Int(nullable: false),
                    Genero = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    Foto_paciente = c.String(nullable: false, unicode: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Progreso", t => t.ProgresoID, cascadeDelete: true);
            //.Index(t => t.ProgresoID);

            CreateTable(
                "dbo.Progreso",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    IMC = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Medida_Cintura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Medida_Cadera = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Estatura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Edad_Metabolica = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Fecha = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    Progreso_ID = c.Int(),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Progreso", t => t.Progreso_ID);
                //.Index(t => t.Progreso_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Perfil", "ProgresoID", "dbo.Progreso");
            DropForeignKey("dbo.Progreso", "Progreso_ID", "dbo.Progreso");
            DropForeignKey("dbo.Login", "RolID", "dbo.Rol");
            DropForeignKey("dbo.Mi_Nutriologo", "ConsultorioID", "dbo.Consultorio");
            DropForeignKey("dbo.Cita", "MesID", "dbo.Mes");
            DropForeignKey("dbo.Cita", "Dia_SemanaID", "dbo.Dia_Semana");
            DropForeignKey("dbo.Mi_Menu", "Dia_SemanaID", "dbo.Dia_Semana");
            DropForeignKey("dbo.Mi_Menu", "ComidaID", "dbo.Comida");
            DropIndex("dbo.Perfil", new[] { "ProgresoID" });
            DropIndex("dbo.Progreso", new[] { "Progreso_ID" });
            DropIndex("dbo.Login", new[] { "RolID" });
            DropIndex("dbo.Mi_Nutriologo", new[] { "ConsultorioID" });
            DropIndex("dbo.Cita", new[] { "MesID" });
            DropIndex("dbo.Cita", new[] { "Dia_SemanaID" });
            DropIndex("dbo.Mi_Menu", new[] { "Dia_SemanaID" });
            DropIndex("dbo.Mi_Menu", new[] { "ComidaID" });
            DropTable("dbo.Progreso");
            DropTable("dbo.Perfil");
            DropTable("dbo.Rol");
            DropTable("dbo.Login");
            DropTable("dbo.Mi_Nutriologo");
            DropTable("dbo.Consultorio");
            DropTable("dbo.Mes");
            DropTable("dbo.Comida");
            DropTable("dbo.Mi_Menu");
            DropTable("dbo.Dia_Semana");
            DropTable("dbo.Cita");
        }
    }
}
