namespace HealthyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Mi_Nutriologo", "Foto", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mi_Nutriologo", "Foto", c => c.String(nullable: false, unicode: false));
        }
    }
}
