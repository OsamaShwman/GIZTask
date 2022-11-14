namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sec : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "DepId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Department_Id", c => c.Int());
            CreateIndex("dbo.Users", "Department_Id");
            AddForeignKey("dbo.Users", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Users", new[] { "Department_Id" });
            DropColumn("dbo.Users", "Department_Id");
            DropColumn("dbo.Users", "DepId");
            DropTable("dbo.Departments");
        }
    }
}
