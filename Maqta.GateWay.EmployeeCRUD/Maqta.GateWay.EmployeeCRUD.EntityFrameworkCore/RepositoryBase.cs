using Maqta.GateWay.EmployeeCRUD.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.EntityFrameworkCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MaqtaGateWayDbContext MaqtaGateWayDbContext { get; set; }
        public RepositoryBase(MaqtaGateWayDbContext repositoryContext)
        {
            MaqtaGateWayDbContext = repositoryContext;
        }
        public Task<List<T>> FindAllAsync() => MaqtaGateWayDbContext.Set<T>().AsNoTracking().ToListAsync();
        public Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression) =>
            MaqtaGateWayDbContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        public async Task CreateAsync(T entity) => await MaqtaGateWayDbContext.Set<T>().AddAsync(entity);
        public void Update(T entity) => MaqtaGateWayDbContext.Set<T>().Update(entity);
        public void Delete(T entity) => MaqtaGateWayDbContext.Set<T>().Remove(entity);
    }
}
