namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Samaneh : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "BES.Samana", newName: "Samanehs");
            RenameTable(name: "BES.TaskWork", newName: "TaskWorks");
        }
        
        public override void Down()
        {
            RenameTable(name: "BES.TaskWorks", newName: "TaskWork");
            RenameTable(name: "BES.Samanehs", newName: "Samana");
        }
    }
}
