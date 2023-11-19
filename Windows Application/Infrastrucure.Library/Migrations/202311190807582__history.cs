namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _history : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("BUS.TaskWorkHistories", "TaskWorkId", "BUS.TaskWorks");
            DropIndex("BUS.TaskWorkHistories", new[] { "TaskWorkId" });
            DropTable("BUS.TaskWorkHistories");
        }
    }
}
