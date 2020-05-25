namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "FinishedTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "FinishedTime", c => c.DateTime());
        }
    }
}
