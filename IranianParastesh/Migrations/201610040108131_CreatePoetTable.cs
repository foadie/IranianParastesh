namespace IranianParastesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePoetTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Poets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Poets");
        }
    }
}
