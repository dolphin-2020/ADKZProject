namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haha1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Priority", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Priority");
        }
    }
}
