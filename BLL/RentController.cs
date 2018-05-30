using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class RentController
    {
        #region Singleton
        private static RentController instance;
        public static RentController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RentController();
                }
                return instance;
            }
        }
        #endregion

        RentService rentService = RentService.Instance;

        // Create Rent
        public void Create(Rent rent)
        {
            rentService.Create(rent);
        }

        // Update Rent
        public void Update(Rent rent)
        {
            rentService.Update(rent);
        }

        // Delete Rent
        public void Delete(Rent rent)
        {
            rentService.Delete(rent);
        }

        // Read Rent
        public List<Rent> Read()
        {
            return rentService.Read();
        }

        // Select Rent
        public Rent Select(int id)
        {
            return rentService.Select(id);
        }
    }
}
