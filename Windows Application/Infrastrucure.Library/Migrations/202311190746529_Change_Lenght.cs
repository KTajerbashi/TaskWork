namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Lenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("BAC.Backups", "Description", c => c.String());
            AlterColumn("LOG.Loggers", "Description", c => c.String());
            AlterColumn("SEC.Privileges", "Description", c => c.String());
            AlterColumn("BUS.RoadmapLessons", "Description", c => c.String());
            AlterColumn("SEC.Roles", "Description", c => c.String());
            AlterColumn("BUS.TaskWorks", "Description", c => c.String());
            AlterColumn("BUS.Samanehs", "Description", c => c.String());
            AlterColumn("SEC.Users", "Description", c => c.String());
            AlterColumn("SEC.UserRoles", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("SEC.UserRoles", "Description", c => c.String(maxLength: 500));
            AlterColumn("SEC.Users", "Description", c => c.String(maxLength: 500));
            AlterColumn("BUS.Samanehs", "Description", c => c.String(maxLength: 500));
            AlterColumn("BUS.TaskWorks", "Description", c => c.String(maxLength: 500));
            AlterColumn("SEC.Roles", "Description", c => c.String(maxLength: 500));
            AlterColumn("BUS.RoadmapLessons", "Description", c => c.String(maxLength: 500));
            AlterColumn("SEC.Privileges", "Description", c => c.String(maxLength: 500));
            AlterColumn("LOG.Loggers", "Description", c => c.String(maxLength: 500));
            AlterColumn("BAC.Backups", "Description", c => c.String(maxLength: 500));
        }
    }
}
