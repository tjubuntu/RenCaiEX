namespace RenCaiEX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StsCorporations", "AssignedLogo_Id", "dbo.StsLogos");
            DropForeignKey("dbo.StsEducations", "AssignedResume_Id", "dbo.StsResumes");
            DropForeignKey("dbo.StsExperiences", "AssignedResume_Id", "dbo.StsResumes");
            DropForeignKey("dbo.StsTrainings", "AssignedResume_Id", "dbo.StsResumes");
            DropIndex("dbo.StsCorporations", new[] { "AssignedLogo_Id" });
            DropIndex("dbo.StsEducations", new[] { "AssignedResume_Id" });
            DropIndex("dbo.StsExperiences", new[] { "AssignedResume_Id" });
            DropIndex("dbo.StsTrainings", new[] { "AssignedResume_Id" });
            DropPrimaryKey("dbo.StsCorporations");
            DropPrimaryKey("dbo.StsLogos");
            DropPrimaryKey("dbo.StsEducations");
            DropPrimaryKey("dbo.StsResumes");
            DropPrimaryKey("dbo.StsExperiences");
            DropPrimaryKey("dbo.StsTrainings");
            AlterColumn("dbo.StsCorporations", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsCorporations", "AssignedLogo_Id", c => c.Guid());
            AlterColumn("dbo.StsLogos", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsEducations", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsEducations", "AssignedResume_Id", c => c.Guid());
            AlterColumn("dbo.StsResumes", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsExperiences", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsExperiences", "AssignedResume_Id", c => c.Guid());
            AlterColumn("dbo.StsTrainings", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.StsTrainings", "AssignedResume_Id", c => c.Guid());
            AddPrimaryKey("dbo.StsCorporations", "Id");
            AddPrimaryKey("dbo.StsLogos", "Id");
            AddPrimaryKey("dbo.StsEducations", "Id");
            AddPrimaryKey("dbo.StsResumes", "Id");
            AddPrimaryKey("dbo.StsExperiences", "Id");
            AddPrimaryKey("dbo.StsTrainings", "Id");
            CreateIndex("dbo.StsCorporations", "AssignedLogo_Id");
            CreateIndex("dbo.StsEducations", "AssignedResume_Id");
            CreateIndex("dbo.StsExperiences", "AssignedResume_Id");
            CreateIndex("dbo.StsTrainings", "AssignedResume_Id");
            AddForeignKey("dbo.StsCorporations", "AssignedLogo_Id", "dbo.StsLogos", "Id");
            AddForeignKey("dbo.StsEducations", "AssignedResume_Id", "dbo.StsResumes", "Id");
            AddForeignKey("dbo.StsExperiences", "AssignedResume_Id", "dbo.StsResumes", "Id");
            AddForeignKey("dbo.StsTrainings", "AssignedResume_Id", "dbo.StsResumes", "Id");
            DropColumn("dbo.StsCorporations", "CorporationID");
            DropColumn("dbo.StsLogos", "LogoID");
            DropColumn("dbo.StsEducations", "EducationID");
            DropColumn("dbo.StsResumes", "ResumeID");
            DropColumn("dbo.StsExperiences", "TrainingID");
            DropColumn("dbo.StsTrainings", "TrainingID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StsTrainings", "TrainingID", c => c.String());
            AddColumn("dbo.StsExperiences", "TrainingID", c => c.String());
            AddColumn("dbo.StsResumes", "ResumeID", c => c.String());
            AddColumn("dbo.StsEducations", "EducationID", c => c.String());
            AddColumn("dbo.StsLogos", "LogoID", c => c.String());
            AddColumn("dbo.StsCorporations", "CorporationID", c => c.String());
            DropForeignKey("dbo.StsTrainings", "AssignedResume_Id", "dbo.StsResumes");
            DropForeignKey("dbo.StsExperiences", "AssignedResume_Id", "dbo.StsResumes");
            DropForeignKey("dbo.StsEducations", "AssignedResume_Id", "dbo.StsResumes");
            DropForeignKey("dbo.StsCorporations", "AssignedLogo_Id", "dbo.StsLogos");
            DropIndex("dbo.StsTrainings", new[] { "AssignedResume_Id" });
            DropIndex("dbo.StsExperiences", new[] { "AssignedResume_Id" });
            DropIndex("dbo.StsEducations", new[] { "AssignedResume_Id" });
            DropIndex("dbo.StsCorporations", new[] { "AssignedLogo_Id" });
            DropPrimaryKey("dbo.StsTrainings");
            DropPrimaryKey("dbo.StsExperiences");
            DropPrimaryKey("dbo.StsResumes");
            DropPrimaryKey("dbo.StsEducations");
            DropPrimaryKey("dbo.StsLogos");
            DropPrimaryKey("dbo.StsCorporations");
            AlterColumn("dbo.StsTrainings", "AssignedResume_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.StsTrainings", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StsExperiences", "AssignedResume_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.StsExperiences", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StsResumes", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StsEducations", "AssignedResume_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.StsEducations", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StsLogos", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StsCorporations", "AssignedLogo_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.StsCorporations", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.StsTrainings", "Id");
            AddPrimaryKey("dbo.StsExperiences", "Id");
            AddPrimaryKey("dbo.StsResumes", "Id");
            AddPrimaryKey("dbo.StsEducations", "Id");
            AddPrimaryKey("dbo.StsLogos", "Id");
            AddPrimaryKey("dbo.StsCorporations", "Id");
            CreateIndex("dbo.StsTrainings", "AssignedResume_Id");
            CreateIndex("dbo.StsExperiences", "AssignedResume_Id");
            CreateIndex("dbo.StsEducations", "AssignedResume_Id");
            CreateIndex("dbo.StsCorporations", "AssignedLogo_Id");
            AddForeignKey("dbo.StsTrainings", "AssignedResume_Id", "dbo.StsResumes", "Id");
            AddForeignKey("dbo.StsExperiences", "AssignedResume_Id", "dbo.StsResumes", "Id");
            AddForeignKey("dbo.StsEducations", "AssignedResume_Id", "dbo.StsResumes", "Id");
            AddForeignKey("dbo.StsCorporations", "AssignedLogo_Id", "dbo.StsLogos", "Id");
        }
    }
}
