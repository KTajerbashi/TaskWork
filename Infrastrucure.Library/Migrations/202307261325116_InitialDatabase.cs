namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
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
                "BES.Samana",
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
                "BES.TaskWork",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        Created = c.DateTime(nullable: false),
                        IsPassed = c.Boolean(nullable: false),
                        IsDeliver = c.Boolean(nullable: false),
                        SamanaID = c.Long(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("BES.Samana", t => t.SamanaID, cascadeDelete: true)
                .Index(t => t.SamanaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("BES.TaskWork", "SamanaID", "BES.Samana");
            DropForeignKey("SEC.UserRoles", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles");
            DropIndex("BES.TaskWork", new[] { "SamanaID" });
            DropIndex("BES.Samana", new[] { "Title" });
            DropIndex("SEC.UserRoles", new[] { "UserID" });
            DropIndex("SEC.UserRoles", new[] { "RoleID" });
            DropTable("BES.TaskWork");
            DropTable("BES.Samana");
            DropTable("SEC.Users");
            DropTable("SEC.UserRoles");
            DropTable("SEC.Roles");
        }
    }
}
