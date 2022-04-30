namespace EmployeesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "KPI", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "KPI", c => c.Int(nullable: false));
        }
    }
}
