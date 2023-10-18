namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class __Data : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles");
            DropForeignKey("SEC.UserRoles", "UserID", "SEC.Users");
            DropIndex("SEC.UserRoles", new[] { "RoleID" });
            DropIndex("SEC.UserRoles", new[] { "UserID" });
            AlterColumn("SEC.UserRoles", "RoleID", c => c.Long(nullable: false));
            AlterColumn("SEC.UserRoles", "UserID", c => c.Long(nullable: false));
            CreateIndex("SEC.UserRoles", "RoleID");
            CreateIndex("SEC.UserRoles", "UserID");
            AddForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles", "ID", cascadeDelete: true);
            AddForeignKey("SEC.UserRoles", "UserID", "SEC.Users", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("SEC.UserRoles", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles");
            DropIndex("SEC.UserRoles", new[] { "UserID" });
            DropIndex("SEC.UserRoles", new[] { "RoleID" });
            AlterColumn("SEC.UserRoles", "UserID", c => c.Long());
            AlterColumn("SEC.UserRoles", "RoleID", c => c.Long());
            CreateIndex("SEC.UserRoles", "UserID");
            CreateIndex("SEC.UserRoles", "RoleID");
            AddForeignKey("SEC.UserRoles", "UserID", "SEC.Users", "ID");
            AddForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles", "ID");
        }
    }
}
