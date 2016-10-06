namespace IranianParastesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKeymTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Keyms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 6),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Keyms");
        }
    }
}
