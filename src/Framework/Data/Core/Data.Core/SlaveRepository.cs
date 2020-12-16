using System;
using NetModular.Lib.Data.Abstractions;

namespace NetModular.Lib.Data.Core
{
    public class SlaveRepository<TRepository> : ISlaveRepository<TRepository> where TRepository : IRepository
    {
        public TRepository Value { get;  }

        public SlaveRepository(IDbContext dbContext)
        {
            Value = (TRepository) Activator.CreateInstance(typeof(TRepository), dbContext);
        }
    }
}
