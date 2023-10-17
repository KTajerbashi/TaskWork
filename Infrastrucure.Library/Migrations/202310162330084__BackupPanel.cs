namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _BackupPanel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "LOG.BackupLogs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        BackupType = c.Byte(nullable: false),
                        FileName = c.String(),
                        FileAddress = c.String(),
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
            DropTable("LOG.BackupLogs");
        }
    }
}
