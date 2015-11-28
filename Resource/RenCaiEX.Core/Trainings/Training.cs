using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Resumes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Trainings
{
    [Table("StsTrainings")]
    public class Training : FullAuditedEntity<Guid>
    {
        public virtual Resume AssignedResume { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string TrainingInstitution { get; set; }
        public virtual string TrainingExperience { get; set; }
    }
}
