namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _InitPassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("SEC.Users", "Hash", c => c.String());
            AddColumn("SEC.Users", "Salt", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("SEC.Users", "Salt");
            DropColumn("SEC.Users", "Hash");
        }
    }
}
