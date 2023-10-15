namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _Init_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("SEC.Users", "Username", c => c.String());
            AddColumn("SEC.Users", "Password", c => c.String());
            CreateIndex("BUS.Samanehs", "Title", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("BUS.Samanehs", new[] { "Title" });
            DropColumn("SEC.Users", "Password");
            DropColumn("SEC.Users", "Username");
        }
    }
}
