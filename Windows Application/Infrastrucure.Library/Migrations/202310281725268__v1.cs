namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _v1 : DbMigration
    {
        public override void Up()
        {
        }
        
        public override void Down()
        {
            DropForeignKey("BUS.TaskWorks", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles");
            DropForeignKey("BUS.TaskWorks", "SamanaID", "BUS.Samanehs");
            DropForeignKey("BUS.TaskWorks", "RoleId", "SEC.Roles");
            DropIndex("SEC.UserRoles", new[] { "UserID" });
            DropIndex("SEC.UserRoles", new[] { "RoleID" });
            DropIndex("BUS.TaskWorks", new[] { "RoleId" });
            DropIndex("BUS.TaskWorks", new[] { "UserID" });
            DropIndex("BUS.TaskWorks", new[] { "SamanaID" });
            DropTable("SEC.UserRoles");
            DropTable("SEC.Users");
            DropTable("BUS.Samanehs");
            DropTable("BUS.TaskWorks");
            DropTable("SEC.Roles");
            DropTable("SEC.Privileges");
            DropTable("LOG.Loggers");
            DropTable("BAC.Backups");
        }
    }
}
