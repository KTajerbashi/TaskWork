namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("SEC.Roles", "Key", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("SEC.Roles", "Key");
        }
    }
}
