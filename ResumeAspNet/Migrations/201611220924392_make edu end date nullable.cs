namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeeduenddatenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseRecords", "EndDate", c => c.DateTime());
            AlterColumn("dbo.EducationRecords", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EducationRecords", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.CourseRecords", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
