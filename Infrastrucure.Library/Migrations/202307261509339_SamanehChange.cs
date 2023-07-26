namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SamanehChange : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "BES.Samanehs", newSchema: "BUS");
            MoveTable(name: "BES.TaskWorks", newSchema: "BUS");
        }
        
        public override void Down()
        {
            MoveTable(name: "BUS.TaskWorks", newSchema: "BES");
            MoveTable(name: "BUS.Samanehs", newSchema: "BES");
        }
    }
}
