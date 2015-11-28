using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace RenCaiEX.EntityFramework.Repositories
{
    public abstract class RenCaiEXRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<RenCaiEXDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected RenCaiEXRepositoryBase(IDbContextProvider<RenCaiEXDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class RenCaiEXRepositoryBase<TEntity> : RenCaiEXRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected RenCaiEXRepositoryBase(IDbContextProvider<RenCaiEXDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
