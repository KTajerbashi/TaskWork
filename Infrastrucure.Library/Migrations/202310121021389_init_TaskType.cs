namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_TaskType : DbMigration
    {
        public override void Up()
        {
            AddColumn("BUS.TaskWorks", "Type", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("BUS.TaskWorks", "Type");
        }
    }
}
