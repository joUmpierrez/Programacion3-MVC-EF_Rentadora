using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class BoatService
    {
        #region Singleton
        private static BoatService instance;
        public static BoatService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BoatService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create Boat
        public void Create(Boat boat)
        {
            db.boats.Add(boat);
            db.SaveChanges();
        }

        // Update Boat
        public void Update(Boat boat)
        {
            Boat findBoat = db.boats.Find(boat.id);
            findBoat = boat;
            db.SaveChanges();
        }

        // Delete Boat
        public void Delete(Boat boat)
        {
            Boat findBoat = db.boats.Find(boat.id);
            db.boats.Remove(findBoat);
            db.SaveChanges();
        }

        // Read Boat
        public List<Boat> Read()
        {
            List<Boat> boats = new List<Boat>();

            foreach (Boat item in db.boats)
            {
                boats.Add(item);
            }
            return boats;
        }

        // Select Boat
        public Boat Select (int id)
        {
            return db.boats.Find(id);
        }
    }
}
