using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, Tid>
       : IBaseRepository<TEntity, Tid> where TEntity : BaseEntity<Tid>
    {
        public virtual async Task<TEntity> Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TEntity> FindById(Tid id)
        {
            throw new System.NotImplementedException();
        }
    }
}
