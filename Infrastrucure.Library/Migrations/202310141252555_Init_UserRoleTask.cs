namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_UserRoleTask : DbMigration
    {
        public override void Up()
        {
            DropIndex("BUS.TaskWorks", new[] { "UserId" });
            CreateIndex("BUS.TaskWorks", "UserID");
        }
        
        public override void Down()
        {
            DropIndex("BUS.TaskWorks", new[] { "UserID" });
            CreateIndex("BUS.TaskWorks", "UserId");
        }
    }
}
