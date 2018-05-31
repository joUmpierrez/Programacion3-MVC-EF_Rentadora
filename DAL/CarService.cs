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

        // Create Car
        public void Create(Car car)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update Car
        public void Update(Car car)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete Car
        public void Delete(Car car)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read Car
        public List<Car> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select Car
        public Car Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.cars.Find(id);
            }
        }
    }
}
