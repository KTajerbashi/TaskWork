namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "BAC.Backups",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        BackupType = c.Byte(nullable: false),
                        FileName = c.String(),
                        FileAddress = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "LOG.Loggers",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "SEC.Privileges",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Read = c.Boolean(nullable: false),
                        Write = c.Boolean(nullable: false),
                        Update = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        Panel = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "BUS.RoadmapLessons",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ParentId = c.Long(),
                        IsStarted = c.Boolean(nullable: false),
                        InProgress = c.Boolean(nullable: false),
                        IsFinishid = c.Boolean(nullable: false),
                        IsImplemented = c.Boolean(nullable: false),
                        HasFile = c.Boolean(nullable: false),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("BUS.RoadmapLessons", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "SEC.Roles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Key = c.String(),
                        PrivilegeID = c.Long(nullable: false),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.ID, t.PrivilegeID }, unique: true);
            
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
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
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
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "BUS.TaskWorkHistories",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        TaskWorkId = c.Long(nullable: false),
                        Message = c.String(),
                        TaskActionType = c.Byte(nullable: false),
                        FromUser = c.Long(nullable: false),
                        ToUser = c.Long(nullable: false),
                        ByUser = c.Long(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("BUS.TaskWorks", t => t.TaskWorkId, cascadeDelete: true)
                .Index(t => t.TaskWorkId);
            
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
                        Hash = c.String(),
                        Salt = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "SEC.UserRoles",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        RoleID = c.Long(nullable: false),
                        UserID = c.Long(nullable: false),
                        Title = c.String(maxLength: 200),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("SEC.Roles", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("SEC.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("BUS.TaskWorks", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "UserID", "SEC.Users");
            DropForeignKey("SEC.UserRoles", "RoleID", "SEC.Roles");
            DropForeignKey("BUS.TaskWorkHistories", "TaskWorkId", "BUS.TaskWorks");
            DropForeignKey("BUS.TaskWorks", "SamanaID", "BUS.Samanehs");
            DropForeignKey("BUS.TaskWorks", "RoleId", "SEC.Roles");
            DropForeignKey("BUS.RoadmapLessons", "ParentId", "BUS.RoadmapLessons");
            DropIndex("SEC.UserRoles", new[] { "UserID" });
            DropIndex("SEC.UserRoles", new[] { "RoleID" });
            DropIndex("BUS.TaskWorkHistories", new[] { "TaskWorkId" });
            DropIndex("BUS.TaskWorks", new[] { "RoleId" });
            DropIndex("BUS.TaskWorks", new[] { "UserID" });
            DropIndex("BUS.TaskWorks", new[] { "SamanaID" });
            DropIndex("SEC.Roles", new[] { "ID", "PrivilegeID" });
            DropIndex("BUS.RoadmapLessons", new[] { "ParentId" });
            DropTable("SEC.UserRoles");
            DropTable("SEC.Users");
            DropTable("BUS.TaskWorkHistories");
            DropTable("BUS.Samanehs");
            DropTable("BUS.TaskWorks");
            DropTable("SEC.Roles");
            DropTable("BUS.RoadmapLessons");
            DropTable("SEC.Privileges");
            DropTable("LOG.Loggers");
            DropTable("BAC.Backups");
        }
    }
}
