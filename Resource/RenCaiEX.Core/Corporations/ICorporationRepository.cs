using Abp.Domain.Repositories;
using System;

namespace RenCaiEX.Corporations
{
    public interface ICorporationRepository:IRepository<Corporation,Guid>
    {
    }
}
