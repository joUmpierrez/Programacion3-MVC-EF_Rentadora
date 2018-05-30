using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class CarController
    {
        #region Singleton
        private static CarController instance;
        public static CarController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarController();
                }
                return instance;
            }
        }
        #endregion

        CarService carService = CarService.Instance;

        // Create Car
        public void Create(Car car)
        {
            carService.Create(car);
        }

        // Update Car
        public void Update(Car car)
        {
            carService.Update(car);
        }

        // Delete Car
        public void Delete(Car car)
        {
            carService.Delete(car);
        }

        // Read Car
        public List<Car> Read()
        {
            return carService.Read();
        }

        // Select Car
        public Car Select(int id)
        {
            return carService.Select(id);
        }
    }
}
