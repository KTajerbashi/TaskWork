namespace Infrastrucure.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Privilege : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "SEC.Privileges",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Read = c.Boolean(nullable: false),
                        Write = c.Boolean(nullable: false),
                        Update = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        Panel = c.String(),
                        Title = c.String(maxLength: 200),
                        Description = c.String(maxLength: 500),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedByUserRoleID = c.Long(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("SEC.Roles", t => t.ID)
                .Index(t => t.ID);
            
            AddColumn("SEC.Roles", "PrivilegID", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("SEC.Privileges", "ID", "SEC.Roles");
            DropIndex("SEC.Privileges", new[] { "ID" });
            DropColumn("SEC.Roles", "PrivilegID");
            DropTable("SEC.Privileges");
        }
    }
}
