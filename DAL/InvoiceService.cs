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

        // Create Invoice
        public void Create(Invoice invoice)
        {
            using (RentalContext db = new RentalContext())
            {
                
            }
        }

        // Update Invoice
        public void Update(Invoice invoice)
        {
            using (RentalContext db = new RentalContext())
            {
                
            }
        }

        // Delete Invoice
        public void Delete(Invoice invoice)
        {
            using (RentalContext db = new RentalContext())
            {
                
            }
        }

        // Read Invoice
        public List<Invoice> Read()
        {
            using (RentalContext db = new RentalContext())
            {
                return null;
            }
        }

        // Select Invoice
        public Invoice Select(int id)
        {
            using (RentalContext db = new RentalContext())
            {
                return db.invoices.Find(id);
            }
        }
    }
}
