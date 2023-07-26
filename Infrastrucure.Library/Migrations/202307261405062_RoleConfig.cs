namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleConfig : DbMigration
    {
        public override void Up()
        {
            DropIndex("BES.Samana", new[] { "Title" });
        }
        
        public override void Down()
        {
            CreateIndex("BES.Samana", "Title", unique: true);
        }
    }
}
