namespace Fuzzyminds.ResumeAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makepositionrecordenddatenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PositionRecords", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PositionRecords", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
