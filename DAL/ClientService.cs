using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ClientService
    {
        #region Singleton
        private static ClientService instance;
        public static ClientService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientService();
                }
                return instance;
            }
        }
        #endregion

        // Create Client
        public void Create(Client client)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Update Client
        public void Update(Client client)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Delete Client
        public void Delete(Client client)
        {
            using (RentalContext db = new RentalContext())
            {

            }
        }

        // Read Client
        public List<Client> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select Client
        public Client Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.clients.Find(id);
            }
        }
    }
}
