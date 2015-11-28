using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using RenCaiEX.Corporations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenCaiEX.Logos
{
    [Table("StsLogos")]
    public class Logo : FullAuditedEntity<Guid>
    {
        public virtual string LogoName { get; set; }
        public virtual string LogoUrl { get; set; }
    }
}
