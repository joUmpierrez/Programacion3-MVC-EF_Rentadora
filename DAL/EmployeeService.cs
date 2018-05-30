using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class EmployeeService
    {
        #region Singleton
        private static EmployeeService instance;
        public static EmployeeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create Employee
        public void Create(Employee employee)
        {

        }

        // Update Employee
        public void Update(Employee employee)
        {

        }

        // Delete Employee
        public void Delete(Employee employee)
        {

        }

        // Read Employee
        public List<Employee> Read()
        {
            return null;
        }

        // Select Employee
        public Employee Select(int id)
        {
            return db.employees.Find(id);
        }
    }
}
