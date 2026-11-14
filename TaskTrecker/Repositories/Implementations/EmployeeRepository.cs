using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrecker.Entities;

namespace TaskTrecker.Repositories.Implementations
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        public void Add(Employee employee)
        {
        }

        public void Delete(int id)
        {
        }

        public Employee GetById(int id)
        {
            return Employee.CreateEntity(0, string.Empty, string.Empty);
        }

        public IEnumerable<Employee> GetAll()
        {
            return [];
        }

        public void Update(Employee employee) 
        {
        }
    }
}