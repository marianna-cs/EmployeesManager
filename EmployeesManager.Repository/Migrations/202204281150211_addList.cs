namespace EmployeesManager.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addList : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "Department_Id" });
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            RenameColumn(table: "dbo.Employees", name: "Department_Id", newName: "Departmant_Id");
            AlterColumn("dbo.Employees", "Departmant_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "Position_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Departmant_Id");
            CreateIndex("dbo.Employees", "Position_Id");
            AddForeignKey("dbo.Employees", "Departmant_Id", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "Position_Id", "dbo.Positions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropForeignKey("dbo.Employees", "Departmant_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropIndex("dbo.Employees", new[] { "Departmant_Id" });
            AlterColumn("dbo.Employees", "Position_Id", c => c.Int());
            AlterColumn("dbo.Employees", "Departmant_Id", c => c.Int());
            RenameColumn(table: "dbo.Employees", name: "Departmant_Id", newName: "Department_Id");
            CreateIndex("dbo.Employees", "Position_Id");
            CreateIndex("dbo.Employees", "Department_Id");
            AddForeignKey("dbo.Employees", "Position_Id", "dbo.Positions", "Id");
            AddForeignKey("dbo.Employees", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
