namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _init_unique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("SEC.Roles", "Title", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("SEC.Roles", new[] { "Title" });
        }
    }
}
