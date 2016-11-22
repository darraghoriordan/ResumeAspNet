namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movecompanyrecordstomanypositions : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CompanyRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropIndex("dbo.CompanyRecords", new[] { "ResumeRecordId" });
            DropColumn("dbo.CompanyRecords", "ResumeRecordId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CompanyRecords", "ResumeRecordId", c => c.Int(nullable: false));
            CreateIndex("dbo.CompanyRecords", "ResumeRecordId");
            AddForeignKey("dbo.CompanyRecords", "ResumeRecordId", "dbo.ResumeRecords", "Id", cascadeDelete: true);
        }
    }
}
