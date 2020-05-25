namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Tasks", "Content", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Content", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Tasks", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
