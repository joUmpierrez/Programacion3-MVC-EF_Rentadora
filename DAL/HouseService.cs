using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class HouseService
    {
        #region Singleton
        private static HouseService instance;
        public static HouseService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HouseService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create House
        public void Create(House house)
        {

        }

        // Update House
        public void Update(House house)
        {

        }

        // Delete House
        public void Delete(House house)
        {

        }

        // Read House
        public List<House> Read()
        {
            return null;
        }

        // Select House
        public House Select(int id)
        {
            return db.houses.Find(id);
        }
    }
}
