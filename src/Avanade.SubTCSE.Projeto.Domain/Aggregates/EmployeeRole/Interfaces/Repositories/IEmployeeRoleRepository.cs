using System.Threading.Tasks;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repositories
{
    public interface IEmployeeRoleRepository : IBaseRepository<Entities.EmployeeRole, string>
    {
       
    }
}
