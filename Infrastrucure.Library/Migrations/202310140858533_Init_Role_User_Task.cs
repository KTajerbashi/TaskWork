namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_Role_User_Task : DbMigration
    {
        public override void Up()
        {
            AddColumn("BUS.TaskWorks", "UserId", c => c.Long());
            AddColumn("BUS.TaskWorks", "RoleId", c => c.Long());
            CreateIndex("BUS.TaskWorks", "UserId");
            CreateIndex("BUS.TaskWorks", "RoleId");
            AddForeignKey("BUS.TaskWorks", "RoleId", "SEC.Roles", "ID");
            AddForeignKey("BUS.TaskWorks", "UserId", "SEC.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("BUS.TaskWorks", "UserId", "SEC.Users");
            DropForeignKey("BUS.TaskWorks", "RoleId", "SEC.Roles");
            DropIndex("BUS.TaskWorks", new[] { "RoleId" });
            DropIndex("BUS.TaskWorks", new[] { "UserId" });
            DropColumn("BUS.TaskWorks", "RoleId");
            DropColumn("BUS.TaskWorks", "UserId");
        }
    }
}
