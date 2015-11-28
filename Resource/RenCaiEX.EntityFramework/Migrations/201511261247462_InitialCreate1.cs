namespace RenCaiEX.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StsRecruitments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JobName = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ZPCategory = c.Byte(nullable: false),
                        State = c.Byte(nullable: false),
                        PublicationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        AssignedCorporation_Id = c.Guid(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Recruitment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StsCorporations", t => t.AssignedCorporation_Id)
                .Index(t => t.AssignedCorporation_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StsRecruitments", "AssignedCorporation_Id", "dbo.StsCorporations");
            DropIndex("dbo.StsRecruitments", new[] { "AssignedCorporation_Id" });
            DropTable("dbo.StsRecruitments",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_Recruitment_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
