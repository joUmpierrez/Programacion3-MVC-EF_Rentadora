using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class RentService
    {
        #region Singleton
        private static RentService instance;
        public static RentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create Rent
        public void Create(Rent rent)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update Rent
        public void Update(Rent rent)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete Rent
        public void Delete(Rent rent)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read Rent
        public List<Rent> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select Rent
        public Rent Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.rents.Find(id);
            }
        }
    }
}
