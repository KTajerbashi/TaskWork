namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_RoadmapLesson : DbMigration
    {
        public override void Up()
        {
            AddColumn("BUS.RoadmapLessons", "IsStarted", c => c.Boolean(nullable: false));
            AddColumn("BUS.RoadmapLessons", "InProgress", c => c.Boolean(nullable: false));
            AddColumn("BUS.RoadmapLessons", "IsFinishid", c => c.Boolean(nullable: false));
            AddColumn("BUS.RoadmapLessons", "IsImplemented", c => c.Boolean(nullable: false));
            AddColumn("BUS.RoadmapLessons", "HasFile", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("BUS.RoadmapLessons", "HasFile");
            DropColumn("BUS.RoadmapLessons", "IsImplemented");
            DropColumn("BUS.RoadmapLessons", "IsFinishid");
            DropColumn("BUS.RoadmapLessons", "InProgress");
            DropColumn("BUS.RoadmapLessons", "IsStarted");
        }
    }
}
