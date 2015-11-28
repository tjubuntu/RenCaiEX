using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Resumes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Experiences
{
    [Table("StsExperiences")]
    public class Experience : FullAuditedEntity<Guid>
    {
        public virtual Resume AssignedResume { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string CorporateName { get; set; }
        public virtual string ExperientialDescription { get; set; }
    }
}
