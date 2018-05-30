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

        }

        // Update Rent
        public void Update(Rent rent)
        {

        }

        // Delete Rent
        public void Delete(Rent rent)
        {

        }

        // Read Rent
        public List<Rent> Read()
        {
            return null;
        }

        // Select Rent
        public Rent Select(int id)
        {
            return db.rents.Find(id);
        }
    }
}
