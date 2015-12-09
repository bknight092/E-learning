using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ELearning.EntityFramework.Repositories
{
    public abstract class ELearningRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ELearningDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ELearningRepositoryBase(IDbContextProvider<ELearningDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ELearningRepositoryBase<TEntity> : ELearningRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ELearningRepositoryBase(IDbContextProvider<ELearningDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
