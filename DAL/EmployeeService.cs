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

        // Create Employee
        public void Create(Employee employee)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update Employee
        public void Update(Employee employee)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete Employee
        public void Delete(Employee employee)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read Employee
        public List<Employee> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select Employee
        public Employee Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.employees.Find(id);
            }
        }
    }
}
