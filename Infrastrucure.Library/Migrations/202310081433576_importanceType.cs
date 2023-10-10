namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class importanceType : DbMigration
    {
        public override void Up()
        {
            AddColumn("BUS.TaskWorks", "ImportanceType", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("BUS.TaskWorks", "ImportanceType");
        }
    }
}
