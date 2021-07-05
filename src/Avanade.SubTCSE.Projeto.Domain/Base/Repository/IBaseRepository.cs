using System.Collections.Generic;
using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Aggregates;

namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(TId id);
    }
}
