namespace GameStoreDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change_Models : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "UserId", c => c.String());
            AddColumn("dbo.Orders", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "DateTime");
            DropColumn("dbo.Orders", "UserId");
        }
    }
}
