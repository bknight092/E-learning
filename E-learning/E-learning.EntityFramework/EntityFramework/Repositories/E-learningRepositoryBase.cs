using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace E-learning.EntityFramework.Repositories
{
    public abstract class E-learningRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<E-learningDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected E-learningRepositoryBase(IDbContextProvider<E-learningDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class E-learningRepositoryBase<TEntity> : E-learningRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected E-learningRepositoryBase(IDbContextProvider<E-learningDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
