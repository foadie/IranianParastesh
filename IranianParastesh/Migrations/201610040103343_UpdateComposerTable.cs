namespace IranianParastesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateComposerTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Composers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Composers", "Name", c => c.String());
        }
    }
}
