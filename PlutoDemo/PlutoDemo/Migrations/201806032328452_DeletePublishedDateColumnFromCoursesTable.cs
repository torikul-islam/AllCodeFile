namespace PlutoDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePublishedDateColumnFromCoursesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "PublishedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "PublishedDate", c => c.DateTime());
        }
    }
}
