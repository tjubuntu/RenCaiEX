using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Logos;
using RenCaiEX.Recruitments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Corporations
{
    [Table("StsCorporations")]
    public class Corporation : FullAuditedEntity<Guid>
    {
        public virtual string CorporationName { get; set; }
        public virtual string CorporationAddress { get; set; }
        public virtual string TelephoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual Logo AssignedLogo { get; set; }
        public virtual ICollection<Recruitment> RecruitmentList { get; set; }
    }
}
