namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "FinishedTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "FinishedTime", c => c.DateTime(nullable: false));
        }
    }
}
