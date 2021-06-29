using System;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<String>
    {
        public Employee(
            string firstName,
            string surName,
            DateTime birtday,
            bool active,
            decimal salary,
            EmployeeRole.Entities.EmployeeRole employeeRole)
        {
            FirstName = firstName;
            SurName = surName;
            Birthday = birtday;
            Active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string FirstName { get; init; }

        public string SurName { get; init; }

        public DateTime Birthday { get; init; }

        public bool Active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }
    }
}
