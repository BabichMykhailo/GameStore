namespace GameStoreDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Discription = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ReleaseDate = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeveloperId = c.Int(nullable: false),
                        PublisherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Developers", t => t.DeveloperId, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.DeveloperId)
                .Index(t => t.PublisherId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GameGenres",
                c => new
                    {
                        Game_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_Id, t.Genre_Id })
                .ForeignKey("dbo.Games", t => t.Game_Id, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .Index(t => t.Game_Id)
                .Index(t => t.Genre_Id);
            
            CreateTable(
                "dbo.GameOrders",
                c => new
                    {
                        Game_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Game_Id, t.Order_Id })
                .ForeignKey("dbo.Games", t => t.Game_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.Game_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.GameOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.GameOrders", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.GameGenres", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.GameGenres", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Games", "DeveloperId", "dbo.Developers");
            DropIndex("dbo.GameOrders", new[] { "Order_Id" });
            DropIndex("dbo.GameOrders", new[] { "Game_Id" });
            DropIndex("dbo.GameGenres", new[] { "Genre_Id" });
            DropIndex("dbo.GameGenres", new[] { "Game_Id" });
            DropIndex("dbo.Games", new[] { "PublisherId" });
            DropIndex("dbo.Games", new[] { "DeveloperId" });
            DropTable("dbo.GameOrders");
            DropTable("dbo.GameGenres");
            DropTable("dbo.Publishers");
            DropTable("dbo.Orders");
            DropTable("dbo.Genres");
            DropTable("dbo.Games");
            DropTable("dbo.Developers");
        }
    }
}
