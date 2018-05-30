using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CarService
    {
        #region Singleton
        private static CarService instance;
        public static CarService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create Car
        public void Create(Car car)
        {

        }

        // Update Car
        public void Update(Car car)
        {

        }

        // Delete Car
        public void Delete(Car car)
        {

        }

        // Read Car
        public List<Car> Read()
        {
            return null;
        }

        // Select Car
        public Car Select(int id)
        {
            return db.cars.Find(id);
        }
    }
}
