using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class InvoiceService
    {
        #region Singleton
        private static InvoiceService instance;
        public static InvoiceService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InvoiceService();
                }
                return instance;
            }
        }
        #endregion

        RentalContext db = new RentalContext();

        // Create Invoice
        public void Create(Invoice invoice)
        {

        }

        // Update Invoice
        public void Update(Invoice invoice)
        {

        }

        // Delete Invoice
        public void Delete(Invoice invoice)
        {

        }

        // Read Invoice
        public List<Invoice> Read()
        {
            return null;
        }

        // Select Invoice
        public Invoice Select(int id)
        {
            return db.invoices.Find(id);
        }
    }
}
