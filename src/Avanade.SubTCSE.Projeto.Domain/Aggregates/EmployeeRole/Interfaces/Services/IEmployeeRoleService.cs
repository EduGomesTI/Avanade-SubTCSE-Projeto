﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    interface IEmployeeRoleService
    {
        Task<Entities.EmployeeRole> AddemplyeeRole(Entities.EmployeeRole employeeRole);
    }
}
