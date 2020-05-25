namespace ADKZProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Tasks", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Notifications", "StaffId", "dbo.Staffs");
            AddColumn("dbo.Staffs", "ManagerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Staffs", "ManagerId");
            AddForeignKey("dbo.Staffs", "ManagerId", "dbo.Managers", "Id");
            AddForeignKey("dbo.Projects", "ManagerId", "dbo.Managers", "Id");
            AddForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects", "Id");
            AddForeignKey("dbo.Tasks", "StaffId", "dbo.Staffs", "Id");
            AddForeignKey("dbo.Notifications", "StaffId", "dbo.Staffs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notifications", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Tasks", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Staffs", "ManagerId", "dbo.Managers");
            DropIndex("dbo.Staffs", new[] { "ManagerId" });
            DropColumn("dbo.Staffs", "ManagerId");
            AddForeignKey("dbo.Notifications", "StaffId", "dbo.Staffs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tasks", "StaffId", "dbo.Staffs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tasks", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "ManagerId", "dbo.Managers", "Id", cascadeDelete: true);
        }
    }
}
