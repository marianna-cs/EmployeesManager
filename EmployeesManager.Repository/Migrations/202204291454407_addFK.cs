namespace EmployeesManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "KPI_Ref_Id", c => c.Int());
            CreateIndex("dbo.Employees", "KPI_Ref_Id");
            AddForeignKey("dbo.Employees", "KPI_Ref_Id", "dbo.DictKPIs", "Id");
            DropColumn("dbo.Employees", "KPI");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "KPI", c => c.Int(nullable: false));
            DropForeignKey("dbo.Employees", "KPI_Ref_Id", "dbo.DictKPIs");
            DropIndex("dbo.Employees", new[] { "KPI_Ref_Id" });
            DropColumn("dbo.Employees", "KPI_Ref_Id");
        }
    }
}
