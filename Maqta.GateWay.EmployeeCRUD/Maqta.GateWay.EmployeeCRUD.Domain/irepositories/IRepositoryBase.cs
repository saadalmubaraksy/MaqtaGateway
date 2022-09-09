using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Maqta.GateWay.EmployeeCRUD.Domain
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> FindAllAsync();
        Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task CreateAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
