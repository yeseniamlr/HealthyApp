namespace HealthyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cita",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    LoginID = c.Int(nullable: false),
                    Horario = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    Dia = c.Int(nullable: false),
                    Mes = c.Int(nullable: false),
                    Año = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Login", t => t.LoginID, cascadeDelete: true);
               // .Index(t => t.LoginID);

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
            //  .Index(t => t.RolID);

            CreateTable(
                "dbo.MenuSemanal",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    LoginID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Login", t => t.LoginID, cascadeDelete: true);
            //  .Index(t => t.LoginID);

            CreateTable(
                "dbo.MenuDes",
                c => new
                {
                    MenuSemanalID = c.Int(nullable: false),
                    DiaID = c.Int(nullable: false),
                    TiempoID = c.Int(nullable: false),
                    ComidaID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.MenuSemanalID, t.DiaID, t.TiempoID, t.ComidaID })
                .ForeignKey("dbo.Comida", t => t.ComidaID, cascadeDelete: true)
                .ForeignKey("dbo.Dia", t => t.DiaID, cascadeDelete: true)
                .ForeignKey("dbo.MenuSemanal", t => t.MenuSemanalID, cascadeDelete: true)
                .ForeignKey("dbo.Tiempo", t => t.TiempoID, cascadeDelete: true);
               // .Index(t => t.ComidaID)
               // .Index(t => t.DiaID)
                //.Index(t => t.MenuSemanalID)
               // .Index(t => t.TiempoID);
            
            CreateTable(
                "dbo.Comida",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 255, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dia",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 26, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tiempo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Mi_Nutriologo",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    LoginID = c.Int(nullable: false),
                    Foto = c.String(nullable: false, unicode: false),
                    Nombre = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    Apellido = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    Cedula = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Telefono = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    Descripcion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                    Calle = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                    Numero_Exterior = c.Int(nullable: false),
                    Numero_Interior = c.Int(nullable: false),
                    Municipio = c.String(nullable: false, maxLength: 40, unicode: false, storeType: "nvarchar"),
                    Estado = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Codigo_Postal = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Login", t => t.LoginID, cascadeDelete: true);
            // .Index(t => t.LoginID);

            CreateTable(
                "dbo.Perfil",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    LoginID = c.Int(nullable: false),
                    Nombre = c.String(nullable: false, maxLength: 55, unicode: false, storeType: "nvarchar"),
                    Apellido = c.String(nullable: false, maxLength: 55, unicode: false, storeType: "nvarchar"),
                    Edad = c.Int(nullable: false),
                    Genero = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                    Foto_paciente = c.String(nullable: false, unicode: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Login", t => t.LoginID, cascadeDelete: true);
            //    .Index(t => t.LoginID);

            CreateTable(
                "dbo.Progreso",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    PerfilID = c.Int(nullable: false),
                    IMC = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Medida_Cintura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Medida_Cadera = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Estatura = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Edad_Metabolica = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Fecha = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Perfil", t => t.PerfilID, cascadeDelete: true);
               // .Index(t => t.PerfilID);
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TipoRol = c.String(nullable: false, maxLength: 45, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cita", "LoginID", "dbo.Login");
            DropForeignKey("dbo.Login", "RolID", "dbo.Rol");
            DropForeignKey("dbo.Progreso", "PerfilID", "dbo.Perfil");
            DropForeignKey("dbo.Perfil", "LoginID", "dbo.Login");
            DropForeignKey("dbo.Mi_Nutriologo", "LoginID", "dbo.Login");
            DropForeignKey("dbo.MenuDes", "TiempoID", "dbo.Tiempo");
            DropForeignKey("dbo.MenuDes", "MenuSemanalID", "dbo.MenuSemanal");
            DropForeignKey("dbo.MenuDes", "DiaID", "dbo.Dia");
            DropForeignKey("dbo.MenuDes", "ComidaID", "dbo.Comida");
            DropForeignKey("dbo.MenuSemanal", "LoginID", "dbo.Login");
            DropIndex("dbo.Cita", new[] { "LoginID" });
            DropIndex("dbo.Login", new[] { "RolID" });
            DropIndex("dbo.Progreso", new[] { "PerfilID" });
            DropIndex("dbo.Perfil", new[] { "LoginID" });
            DropIndex("dbo.Mi_Nutriologo", new[] { "LoginID" });
            DropIndex("dbo.MenuDes", new[] { "TiempoID" });
            DropIndex("dbo.MenuDes", new[] { "MenuSemanalID" });
            DropIndex("dbo.MenuDes", new[] { "DiaID" });
            DropIndex("dbo.MenuDes", new[] { "ComidaID" });
            DropIndex("dbo.MenuSemanal", new[] { "LoginID" });
            DropTable("dbo.Rol");
            DropTable("dbo.Progreso");
            DropTable("dbo.Perfil");
            DropTable("dbo.Mi_Nutriologo");
            DropTable("dbo.Tiempo");
            DropTable("dbo.Dia");
            DropTable("dbo.Comida");
            DropTable("dbo.MenuDes");
            DropTable("dbo.MenuSemanal");
            DropTable("dbo.Login");
            DropTable("dbo.Cita");
        }
    }
}
