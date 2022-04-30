namespace EmployeesManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DictKPIs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KPI = c.String(maxLength: 2),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DictKPIs");
        }
    }
}
