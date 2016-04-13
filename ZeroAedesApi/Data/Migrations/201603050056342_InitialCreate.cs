namespace ZeroAedes.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Focus",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    Latitude = c.Double(nullable: false),
                    Longitude = c.Double(nullable: false),
                    Active = c.Boolean(nullable: false, defaultValue: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Photo",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Url = c.String(),
                    FocusId = c.Int(nullable: false),
                    MyProperty = c.Int(nullable: false),
                    Active = c.Boolean(nullable: false, defaultValue: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Focus", t => t.FocusId, cascadeDelete: true)
                .Index(t => t.FocusId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Photo", "FocusId", "dbo.Focus");
            DropIndex("dbo.Photo", new[] { "FocusId" });
            DropTable("dbo.Photo");
            DropTable("dbo.Focus");
        }
    }
}
