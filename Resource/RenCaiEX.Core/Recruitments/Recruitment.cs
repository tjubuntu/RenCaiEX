using Abp.Domain.Entities.Auditing;
using RenCaiEX.Corporations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Recruitments
{
    [Table("StsRecruitments")]
    public class Recruitment : FullAuditedEntity<Guid>
    {
        public virtual string JobName { get; set; }
        public virtual decimal Salary { get; set; }
        public virtual Category ZPCategory { get; set; }
        public virtual RecruitmentState State { get; set; }
        public virtual DateTime PublicationDate { get; set; }
        public virtual Corporation AssignedCorporation { get; set; }

        public Recruitment(Corporation assCorporation)
        {
            AssignedCorporation = assCorporation;
            State = RecruitmentState.New;
            PublicationDate = DateTime.Now;
            
        }
    }
}
