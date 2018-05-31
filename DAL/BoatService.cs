using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Data.Entity;

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

        // Create Boat
        public void Create(Boat boat)
        {
            using (RentalContext db = new RentalContext())
            {
                db.boats.Add(boat);
                db.SaveChanges();
            }
        }

        // Update Boat
        public void Update(Boat boat)
        {
            using (RentalContext db = new RentalContext())
            {
                Boat findBoat = db.boats.Find(boat.id);
                findBoat.brand = boat.brand;
                findBoat = boat;
                db.SaveChanges();
            }
        }

        // Delete Boat
        public void Delete(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                Boat findBoat = db.boats.Find(id);
                
                db.SaveChanges();
            }
        }

        // Read Boat
        public List<Boat> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                List<Boat> boats = new List<Boat>();

                foreach (Boat item in db.boats)
                {
                    boats.Add(item);
                }
                return boats;
            }
        }

        // Select Boat
        public Boat Select (int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.boats.Find(id);
            }
        }
    }
}
