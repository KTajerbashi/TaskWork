namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _changeModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "LOG.BackupLogs", newName: "Backups");
            MoveTable(name: "LOG.Backups", newSchema: "BAC");
            DropIndex("SEC.Roles", new[] { "Title" });
            DropIndex("BUS.Samanehs", new[] { "Title" });
            CreateTable(
                "LOG.Loggers",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("LOG.Loggers");
            CreateIndex("BUS.Samanehs", "Title", unique: true);
            CreateIndex("SEC.Roles", "Title", unique: true);
            MoveTable(name: "BAC.Backups", newSchema: "LOG");
            RenameTable(name: "LOG.Backups", newName: "BackupLogs");
        }
    }
}
