namespace ZeroAedes.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefocus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Focus", "Name", c => c.String());
            AddColumn("dbo.Focus", "Address", c => c.String());
            DropColumn("dbo.Photo", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Photo", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Focus", "Address");
            DropColumn("dbo.Focus", "Name");
        }
    }
}
