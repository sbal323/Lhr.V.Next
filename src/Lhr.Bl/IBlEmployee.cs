using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lhr.Types.CoreHr;

namespace Lhr.Bl
{
    public interface IBlEmployee
    {
        Employee Get(int id);
        List<Employee> GetManagers(int employeeId);
        List<Employee> GetEmployees(Types.Base.FilterValue fValue);
        Employee GetByDepartment(int departmentId);
        Employee GetByCountry(int countryId);
    }
}
