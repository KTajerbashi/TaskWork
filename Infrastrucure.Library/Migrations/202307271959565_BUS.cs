namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BUS : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "BES.Samana", newName: "Samanehs");
            RenameTable(name: "BES.TaskWork", newName: "TaskWorks");
            MoveTable(name: "BES.Samanehs", newSchema: "BUS");
            MoveTable(name: "BES.TaskWorks", newSchema: "BUS");
        }
        
        public override void Down()
        {
            MoveTable(name: "BUS.TaskWorks", newSchema: "BES");
            MoveTable(name: "BUS.Samanehs", newSchema: "BES");
            RenameTable(name: "BES.TaskWorks", newName: "TaskWork");
            RenameTable(name: "BES.Samanehs", newName: "Samana");
        }
    }
}
