namespace PRUEBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcampoFechaN1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AlumnosDatos", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AlumnosDatos", "FechaNacimiento");
        }
    }
}
