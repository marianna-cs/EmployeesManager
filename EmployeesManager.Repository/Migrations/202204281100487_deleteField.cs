namespace EmployeesManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteField : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            AlterColumn("dbo.Employees", "Department_Id", c => c.Int());
            AlterColumn("dbo.Employees", "KPI", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            AlterColumn("dbo.Employees", "KPI", c => c.Int());
            AlterColumn("dbo.Employees", "Department_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
