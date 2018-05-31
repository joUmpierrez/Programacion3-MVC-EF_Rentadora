using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class BoatController
    {
        #region Singleton
        private static BoatController instance;
        public static BoatController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BoatController();
                }
                return instance;
            }
        }
        #endregion

        BoatService boatService = BoatService.Instance;

        // Create Boat
        public void Create(Boat boat)
        {
            boatService.Create(boat);
        }

        // Update Boat
        public void Update (Boat boat)
        {
            boatService.Update(boat);
        }

        // Delete Boat
        public void Delete (int id)
        {
            boatService.Delete(id);
        }

        // Read Boat
        public List<Boat> Read ()
        {
            return boatService.Read();
        }

        // Select Boat
        public Boat Select(int id)
        {
            return boatService.Select(id);
        }
    }
}
