namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Saamaneh_Change : DbMigration
    {
        public override void Up()
        {
            AddColumn("BUS.TaskWorks", "Answer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("BUS.TaskWorks", "Answer");
        }
    }
}
