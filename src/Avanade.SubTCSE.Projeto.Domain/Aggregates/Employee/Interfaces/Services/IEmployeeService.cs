using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEMployee(Entities.Employee employee);
    }
}
