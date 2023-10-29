namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_RoadmapLesson : DbMigration
    {
        public override void Up()
        {
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
                        Description = c.String(maxLength: 500),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("BUS.RoadmapLessons", "ParentId", "BUS.RoadmapLessons");
            DropIndex("BUS.RoadmapLessons", new[] { "ParentId" });
            DropTable("BUS.RoadmapLessons");
        }
    }
}
