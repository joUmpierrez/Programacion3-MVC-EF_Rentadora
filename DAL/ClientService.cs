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

        RentalContext db = new RentalContext();

        // Create Client
        public void Create(Client client)
        {

        }

        // Update Client
        public void Update(Client client)
        {

        }

        // Delete Client
        public void Delete(Client client)
        {

        }

        // Read Client
        public List<Client> Read()
        {
            return null;
        }

        // Select Client
        public Client Select(int id)
        {
            return db.clients.Find(id);
        }
    }
}
