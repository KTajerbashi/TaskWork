namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            DropColumn("BUS.TaskWorks", "Created");
        }

        public override void Down()
        {
            AddColumn("BUS.TaskWorks", "Created", c => c.DateTime(nullable: false));
        }
    }
}
