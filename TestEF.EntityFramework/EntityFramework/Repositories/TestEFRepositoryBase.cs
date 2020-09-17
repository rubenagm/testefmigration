using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestEF.EntityFramework.Repositories
{
    public abstract class TestEFRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestEFDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestEFRepositoryBase(IDbContextProvider<TestEFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestEFRepositoryBase<TEntity> : TestEFRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestEFRepositoryBase(IDbContextProvider<TestEFDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
