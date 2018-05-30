using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class EmployeeController
    {
        #region Singleton
        private static EmployeeController instance;
        public static EmployeeController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeController();
                }
                return instance;
            }
        }
        #endregion

        EmployeeService employeeService = EmployeeService.Instance;

        // Create Employee
        public void Create(Employee employee)
        {
            employeeService.Create(employee);
        }

        // Update Employee
        public void Update(Employee employee)
        {
            employeeService.Update(employee);
        }

        // Delete Employee
        public void Delete(Employee employee)
        {
            employeeService.Delete(employee);
        }

        // Read Employee
        public List<Employee> Read()
        {
            return employeeService.Read();
        }

        // Select Employee
        public Employee Select(int id)
        {
            return employeeService.Select(id);
        }
    }
}
