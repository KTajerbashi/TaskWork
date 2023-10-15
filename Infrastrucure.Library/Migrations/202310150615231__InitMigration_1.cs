namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _InitMigration_1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "SEC.Roles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "BUS.TaskWorks",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        IsPassed = c.Boolean(nullable: false),
                        IsDeliver = c.Boolean(nullable: false),
                        Answer = c.String(),
                        ImportanceType = c.Byte(nullable: false),
                        Type = c.Byte(nullable: false),
                        SamanaID = c.Long(nullable: false),
                        UserID = c.Long(),
                        RoleId = c.Long(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("SEC.Roles", t => t.RoleId)
                .ForeignKey("BUS.Samanehs", t => t.SamanaID, cascadeDelete: true)
                .ForeignKey("SEC.Users", t => t.UserID)
                .Index(t => t.SamanaID)
                .Index(t => t.UserID)
                .Index(t => t.RoleId);
            
            CreateTable(
                "BUS.Samanehs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Title, unique: true);
            
            CreateTable(
                "SEC.Users",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        DisplayName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "SEC.UserRoles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        RoleID = c.Long(),
                        UserID = c.Long(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("SEC.Roles", t => t.RoleID)
                .ForeignKey("SEC.Users", t => t.UserID)
                .Index(t => t.RoleID)
                .Index(t => t.UserID);
            
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
            DropIndex("BUS.Samanehs", new[] { "Title" });
            DropIndex("BUS.TaskWorks", new[] { "RoleId" });
            DropIndex("BUS.TaskWorks", new[] { "UserID" });
            DropIndex("BUS.TaskWorks", new[] { "SamanaID" });
            DropTable("SEC.UserRoles");
            DropTable("SEC.Users");
            DropTable("BUS.Samanehs");
            DropTable("BUS.TaskWorks");
            DropTable("SEC.Roles");
        }
    }
}
