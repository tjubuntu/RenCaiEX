using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Resumes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Educations
{
    [Table("StsEducations")]
    public class Education : FullAuditedEntity<Guid>
    {
        public virtual Resume AssignedResume { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string SchoolName { get; set; }
        public virtual string EducationalInformation { get; set; }
    }
}
