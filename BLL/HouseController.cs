using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class HouseController
    {
        #region Singleton
        private static HouseController instance;
        public static HouseController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HouseController();
                }
                return instance;
            }
        }
        #endregion

        HouseService houseService = HouseService.Instance;

        // Create House
        public void Create(House house)
        {
            houseService.Create(house);
        }

        // Update House
        public void Update(House house)
        {
            houseService.Update(house);
        }

        // Delete House
        public void Delete(House house)
        {
            houseService.Delete(house);
        }

        // Read House
        public List<House> Read()
        {
            return houseService.Read();
        }

        // Select House
        public House Select(int id)
        {
            return houseService.Select(id);
        }
    }
}
