using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Educations;
using RenCaiEX.Experiences;
using RenCaiEX.Trainings;
using RenCaiEX.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Resumes
{
    [Table("StsResumes")]
    public class Resume : FullAuditedEntity<Guid>
    {
        public virtual string ResumeName { get; set; }
        public virtual JobHunter AssignedUser { get; set; }
        public virtual ICollection<Education> EducationList { get; set; }
        public virtual ICollection<Training> TrainingList { get; set; }
        public virtual ICollection<Experience> ExperienceList { get; set; }
    }
}
