namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AwardRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.ResumeRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                        Location = c.String(),
                        LastModifiedTimestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.EducationRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        FieldOfStudy = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Degree = c.String(),
                        Notes = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.InterestRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.PhoneNumberRecords",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PositionRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        IsCurrent = c.Boolean(nullable: false),
                        ResumeRecordId = c.Int(nullable: false),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CompanyRecords", t => t.Company_Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.CompanyRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.RecommendationRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Summary = c.String(),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
            CreateTable(
                "dbo.SkillRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AbilityOutOfTen = c.Int(nullable: false),
                        YearsOfUse = c.Int(nullable: false),
                        ResumeRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ResumeRecords", t => t.ResumeRecordId, cascadeDelete: true)
                .Index(t => t.ResumeRecordId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SkillRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.RecommendationRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.PositionRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.PositionRecords", "Company_Id", "dbo.CompanyRecords");
            DropForeignKey("dbo.CompanyRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.PhoneNumberRecords", "Id", "dbo.ResumeRecords");
            DropForeignKey("dbo.InterestRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.EducationRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.CourseRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropForeignKey("dbo.AwardRecords", "ResumeRecordId", "dbo.ResumeRecords");
            DropIndex("dbo.SkillRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.RecommendationRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.CompanyRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.PositionRecords", new[] { "Company_Id" });
            DropIndex("dbo.PositionRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.PhoneNumberRecords", new[] { "Id" });
            DropIndex("dbo.InterestRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.EducationRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.CourseRecords", new[] { "ResumeRecordId" });
            DropIndex("dbo.AwardRecords", new[] { "ResumeRecordId" });
            DropTable("dbo.SkillRecords");
            DropTable("dbo.RecommendationRecords");
            DropTable("dbo.CompanyRecords");
            DropTable("dbo.PositionRecords");
            DropTable("dbo.PhoneNumberRecords");
            DropTable("dbo.InterestRecords");
            DropTable("dbo.EducationRecords");
            DropTable("dbo.CourseRecords");
            DropTable("dbo.ResumeRecords");
            DropTable("dbo.AwardRecords");
        }
    }
}
