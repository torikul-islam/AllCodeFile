using System.Net;

namespace PlutoDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCatagoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Catagories VALUES(1, 'Web Developer')");
            Sql("INSERT INTO Catagories VALUES(2, 'Programming Languages')");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Catagories");
        }
    }
}
