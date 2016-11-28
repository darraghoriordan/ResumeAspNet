namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstatetocmpany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CompanyRecords", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CompanyRecords", "State");
        }
    }
}
