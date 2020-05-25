namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "Deadline");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "Deadline", c => c.DateTime(nullable: false));
        }
    }
}
