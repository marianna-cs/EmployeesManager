﻿namespace EmployeesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Department = c.String(),
                        Position = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KPI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
