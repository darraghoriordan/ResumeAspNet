namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addgeneralsummarytomainresume : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResumeRecords", "Summary", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResumeRecords", "Summary");
        }
    }
}
