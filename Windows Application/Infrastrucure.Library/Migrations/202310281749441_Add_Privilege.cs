namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Privilege : DbMigration
    {
        public override void Up()
        {
            AddColumn("SEC.Roles", "PrivilegeID", c => c.Long(nullable: false));
            CreateIndex("SEC.Roles", new[] { "ID", "PrivilegeID" }, unique: true);
        }
        
        public override void Down()
        {
            DropIndex("SEC.Roles", new[] { "ID", "PrivilegeID" });
            DropColumn("SEC.Roles", "PrivilegeID");
        }
    }
}
