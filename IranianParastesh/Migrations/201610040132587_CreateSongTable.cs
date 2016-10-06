namespace IranianParastesh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSongTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Lyric = c.String(),
                        Chord = c.String(),
                        Note = c.String(),
                        Audio = c.String(),
                        Lycho = c.String(),
                        Likes = c.Long(nullable: false),
                        Dislike = c.Long(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ComposerId = c.Int(nullable: false),
                        KeymId = c.Int(nullable: false),
                        PoetId = c.Int(nullable: false),
                        SingerId = c.Int(nullable: false),
                        TypemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Composers", t => t.ComposerId, cascadeDelete: true)
                .ForeignKey("dbo.Keyms", t => t.KeymId, cascadeDelete: true)
                .ForeignKey("dbo.Poets", t => t.PoetId, cascadeDelete: true)
                .ForeignKey("dbo.Singers", t => t.SingerId, cascadeDelete: true)
                .ForeignKey("dbo.Typems", t => t.TypemId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ComposerId)
                .Index(t => t.KeymId)
                .Index(t => t.PoetId)
                .Index(t => t.SingerId)
                .Index(t => t.TypemId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "TypemId", "dbo.Typems");
            DropForeignKey("dbo.Songs", "SingerId", "dbo.Singers");
            DropForeignKey("dbo.Songs", "PoetId", "dbo.Poets");
            DropForeignKey("dbo.Songs", "KeymId", "dbo.Keyms");
            DropForeignKey("dbo.Songs", "ComposerId", "dbo.Composers");
            DropForeignKey("dbo.Songs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Songs", new[] { "TypemId" });
            DropIndex("dbo.Songs", new[] { "SingerId" });
            DropIndex("dbo.Songs", new[] { "PoetId" });
            DropIndex("dbo.Songs", new[] { "KeymId" });
            DropIndex("dbo.Songs", new[] { "ComposerId" });
            DropIndex("dbo.Songs", new[] { "CategoryId" });
            DropTable("dbo.Songs");
        }
    }
}
