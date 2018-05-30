using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL;

namespace BLL
{
    public class ClientController
    {
        #region Singleton
        private static ClientController instance;
        public static ClientController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClientController();
                }
                return instance;
            }
        }
        #endregion

        ClientService clientService = ClientService.Instance;

        // Create Client
        public void Create(Client client)
        {
            clientService.Create(client);
        }

        // Update Client
        public void Update(Client client)
        {
            clientService.Update(client);
        }

        // Delete Client
        public void Delete(Client client)
        {
            clientService.Delete(client);
        }

        // Read Client
        public List<Client> Read()
        {
            return clientService.Read();
        }

        // Select Client
        public Client Select(int id)
        {
            return clientService.Select(id);
        }
    }
}
