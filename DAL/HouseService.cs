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

        // Create House
        public void Create(House house)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update House
        public void Update(House house)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete House
        public void Delete(House house)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read House
        public List<House> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select House
        public House Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.houses.Find(id);
            }
        }
    }
}
